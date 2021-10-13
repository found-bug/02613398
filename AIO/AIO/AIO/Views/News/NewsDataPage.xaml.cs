using AIO.Models.News;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.News
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsDataPage : ContentPage
    {
        List<_articles_data_new> __articles_data = null;
        public NewsDataPage()
        {
            InitializeComponent();

            getdata();

            __articles_data = new List<_articles_data_new>();
        }

        private async void getdata()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://contextualwebsearch-websearch-v1.p.rapidapi.com/api/search/TrendingNewsAPI?pageNumber="+ NewsPageNumber.PageNumber + "&pageSize=50&withThumbnails=true&location=in"),
                Headers =
                {
                    { "x-rapidapi-key", "602c3b1643mshff008b790f25e9cp16d323jsn9b32c8d6f3bf" },
                    { "x-rapidapi-host", "contextualwebsearch-websearch-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                dynamic fetch = JsonConvert.DeserializeObject(body);

                foreach (var obj in fetch.Properties())
                {
                    if (obj.Name == "value")
                    {
                        foreach (var obj2 in obj.Value)
                        {
                            _articles_data_new _Articles_Data = new _articles_data_new();

                            // dynamic fetch1 = obj2;
                            string _data_ = Convert.ToString(obj2);

                            _data_.Replace("{", ""); // Replace the left curly braces
                            _data_.Replace("}", ""); // Replace the right curly braces

                            dynamic fetch1 = JsonConvert.DeserializeObject(_data_);



                            foreach (var obj3 in fetch1.Properties())
                            {
                                if (obj3.Name == "id")
                                {
                                    _Articles_Data.id = obj3.Value;
                                }

                                else if (obj3.Name == "title")
                                {
                                    _Articles_Data.title = obj3.Value;
                                }

                                else if (obj3.Name == "datePublished")
                                {
                                    _Articles_Data.datePublished = obj3.Value;
                                }

                                else if (obj3.Name == "description")
                                {
                                    _Articles_Data.description = obj3.Value;
                                }

                                else if (obj3.Name == "language")
                                {
                                    _Articles_Data.language = obj3.Value;
                                }

                                else if (obj3.Name == "image")
                                {

                                    foreach (var obj4 in obj3.Value)
                                    {
                                        if (obj4.Name == "url")
                                        {
                                            _Articles_Data.image = obj4.Value;
                                        }

                                        if (obj4.Name == "thumbnail")
                                        {
                                            _Articles_Data.thumbnail = obj4.Value;
                                        }
                                    }
                                }
                                 
                            }
                                __articles_data.Add(_Articles_Data);
                                _Articles_Data = null;
                            
                          
                        }
                    }
                }
                loading_label.IsVisible = false;
                loading.IsVisible = false;
                _news_list.ItemsSource = __articles_data.OrderByDescending(x => x.datePublished).Select(x => x).ToList();
            }
        }

        private async void news_img_Clicked(object sender, EventArgs e)
        {
            try
            {
                var _id = (sender as ImageButton).CommandParameter.ToString();

                _articles_data_new _get_data = __articles_data.Where(x => x.id == _id).Select(x => x).FirstOrDefault();

                await Navigation.PushAsync(new SingleNewsPage(_get_data));
            }
            catch (Exception e1)
            { 
            }
        }

        private void btn_Pervious_Clicked(object sender, EventArgs e)
        {
            if (NewsPageNumber.PageNumber > 1)
            {
                int _count = NewsPageNumber.PageNumber;
                NewsPageNumber.PageNumber = 0;
                NewsPageNumber.PageNumber = _count - 1;
                getdata();

                if (NewsPageNumber.PageNumber == 1)
                {
                    btn_Pervious.IsEnabled = false;
                }
            }
            
        }

        private void btn_Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                int _count = NewsPageNumber.PageNumber;
                NewsPageNumber.PageNumber = 0;
                NewsPageNumber.PageNumber = _count + 1;

                if (NewsPageNumber.PageNumber == 1)
                {
                    btn_Pervious.IsEnabled = false;
                }
                else if (NewsPageNumber.PageNumber > 1)
                {
                    btn_Pervious.IsEnabled = true;
                }


                getdata();
            }
            catch (Exception e1)
            {
            }
        }
    }

    public static class NewsPageNumber
    {
        public static int PageNumber = 1;
    }
}