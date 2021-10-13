using AIO.Models._hotel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views._hotel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Hotel_List : ContentPage
	{
        string send_city_for_hotel = string.Empty;
        List<HotelListModel> _hotel_data = null;
        public Hotel_List(string _city)
        {
			InitializeComponent();
            _hotel_data = new List<HotelListModel>();
            get_data();
            send_city_for_hotel = _city;
        }


		async void get_data()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://hotels4.p.rapidapi.com/locations/search?query="+ send_city_for_hotel + "&locale=en_US"),
                    Headers =
    {
        { "x-rapidapi-key", "602c3b1643mshff008b790f25e9cp16d323jsn9b32c8d6f3bf" },
        { "x-rapidapi-host", "hotels4.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    dynamic fetch = JsonConvert.DeserializeObject(body);

                    foreach (var obj in fetch.Properties())
                    {
                        if (obj.Name == "suggestions")
                        {
                            foreach (var obj2 in obj.Value)
                            {
                                if (obj2.Name == "entities")
                                {

                                }
                                HotelListModel _Articles_Data = new HotelListModel();

                                // dynamic fetch1 = obj2;
                                string _data_ = Convert.ToString(obj2);

                                _data_.Replace("{", ""); // Replace the left curly braces
                                _data_.Replace("}", ""); // Replace the right curly braces

                                dynamic fetch1 = JsonConvert.DeserializeObject(_data_);



                                //foreach (var obj3 in fetch1.Properties())
                                //{
                                //    if (obj3.Name == "id")
                                //    {
                                //        _Articles_Data.id = obj3.Value;
                                //    }

                                //    else if (obj3.Name == "title")
                                //    {
                                //        _Articles_Data.title = obj3.Value;
                                //    }

                                //    else if (obj3.Name == "datePublished")
                                //    {
                                //        _Articles_Data.datePublished = obj3.Value;
                                //    }

                                //    else if (obj3.Name == "description")
                                //    {
                                //        _Articles_Data.description = obj3.Value;
                                //    }

                                //    else if (obj3.Name == "language")
                                //    {
                                //        _Articles_Data.language = obj3.Value;
                                //    }

                                //    else if (obj3.Name == "image")
                                //    {

                                //        foreach (var obj4 in obj3.Value)
                                //        {
                                //            if (obj4.Name == "url")
                                //            {
                                //                _Articles_Data.image = obj4.Value;
                                //            }

                                //            if (obj4.Name == "thumbnail")
                                //            {
                                //                _Articles_Data.thumbnail = obj4.Value;
                                //            }
                                //        }
                                //    }

                                //}
                                _hotel_data.Add(_Articles_Data);
                                _Articles_Data = null;


                            }
                        }
                    }
                    //loading_label.IsVisible = false;
                    //loading.IsVisible = false;
                    //_news_list.ItemsSource = __articles_data.OrderByDescending(x => x.datePublished).Select(x => x).ToList();
                }
            }
            catch (Exception e1)
            {
            }
        }

        private void Add_New_Post_Clicked(object sender, EventArgs e)
        {

        }
    }
}