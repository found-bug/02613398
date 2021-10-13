using AIO.Helper;
using AIO.Models;
using AIO.ViewModels;
using AIO.Views._hotel;
using AIO.Views.Ad;
using AIO.Views.location;
using AIO.Views.News;
using AIO.Views.Search;
using Foundation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIKit;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AIO.Views.general_forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public List<search> tempdata;

        string _tabbbed_clipboard_value = string.Empty;

        private double previousScrollPosition = 30;

        Geocoder geoCoder = new Geocoder();

        public static string _city = string.Empty;
        public static string _country = string.Empty;


        public HomePage()
        {
            //Checking Location is on or not
            AppShell _appShell = new AppShell();
            _appShell.get_loaction();


            InitializeComponent();
            //data();
            onload_event();


            LocationName();

            
            //list.ItemsSource = tempdata;
        }

        //User click on hard back button from phone
        Boolean blnShouldStay = true;
        protected override bool OnBackButtonPressed()
        {
            if (blnShouldStay)
            {
                blnShouldStay = false;
                // Yes, we want to stay.
                return true;
            }
            else
            {
                // It's okay, we can leave.
                base.OnBackButtonPressed();
                return false;
            }
        }


        public async void LocationName()
        { 
            if (Settings.geolocation_Latitude != "" && Settings.geolocation_Longitude != "")
            {
                double _lat = Convert.ToDouble(Settings.geolocation_Latitude); double _long = Convert.ToDouble(Settings.geolocation_Longitude);
                //_location_name
                Position position = new Position(_lat, _long);
                IEnumerable<string> possibleAddresses = await geoCoder.GetAddressesForPositionAsync(position);
                string _a = possibleAddresses.FirstOrDefault();

                //Means if user selects something like occean or mountain so there will be no address for that so we can't show that name
                if (_a != null)
                {
                    string _ab = _a.ToString();

                    string[] authorsList = _ab.Split(new Char[] { ',' });

                    int _count = 0; bool isNumber = true;
                    foreach (string author in authorsList)
                    {
                        if (_count == authorsList.Length - 3)
                        {
                            _city = author;
                        }
                        else if (_count == authorsList.Length - 2)
                        {
                            for (int i = 0; i < author.Length; i++)
                            {
                                if (char.IsDigit(author[i]))
                                {
                                    isNumber = true;
                                    break;
                                }
                                else if (!isNumber)
                                {
                                    _city = author;
                                }
                            }
                        }
                        else if (_count == authorsList.Length - 1)
                        {
                            char[] splitChars = new[] { ' ' };
                            var splitString = author.Split(splitChars);
                            _country = splitString[1];
                        }
                        _count++;
                    }

                    if (_country != "India")
                    {
                        this.Title = "India";
                        Settings.geolocation_Latitude = "";
                        Settings.geolocation_Longitude = "";
                        _city = string.Empty; _country = string.Empty;
                        await DisplayAlert("Alert","You can't select location of outside India","Okay");
                    }
                    else
                    {
                        //  Settings.geolocation_Area_City_Name = 
                        this.Title = _city + ", " + _country;
                    }
                }
                else
                {
                    this.Title = "India";
                    Settings.geolocation_Latitude = "";
                    Settings.geolocation_Longitude = "";
                    _city = string.Empty; _country = string.Empty;
                    await DisplayAlert("Alert", "You can't select location of Mountain or Ocean", "Okay");
                }
            }
            else
            {
                this.Title = "India";
            } 
        }

        private async void onload_event()
        {
            await fade_btn.FadeTo(0, 0, Easing.SinOut);

              await hotels_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
                await flights_btn.TranslateTo(20, 0, 100, Easing.BounceOut);
                await trains_btn.TranslateTo(40, 0, 100, Easing.BounceOut);
                await cabs_btn.TranslateTo(60, 0, 100, Easing.BounceOut);
        }




        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //list.IsVisible = true;
            ////thats all you need to make a search  

            //if (string.IsNullOrEmpty(e.NewTextValue))
            //{
            //    list.ItemsSource = "";
            //}

            //else
            //{
            //    list.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
            //}
        }

        //private async void Sign_In_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new LoginPage());
        //}

        private async void _search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }

      

        private async void scroll_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (previousScrollPosition < e.ScrollY)
            {
                //scrolled down
                // previousScrollPosition = e.ScrollY;

                // Show icon
                await fade_btn.FadeTo(1, 100, Easing.SinIn);


                await hotels_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
                await flights_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
                await trains_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
                await cabs_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
                await fade_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
            }
            else if (previousScrollPosition > e.ScrollY)
            {
                //scrolled up

                //if (Convert.ToInt16(e.ScrollY) == 0)
                //    previousScrollPosition = 0;

                // await fade_btn.FadeTo(1, 1000, Easing.SinIn);

                // Hide icon
                await fade_btn.FadeTo(0, 100, Easing.SinOut);

                await hotels_btn.TranslateTo(0, 0, 100, Easing.BounceOut);
                await flights_btn.TranslateTo(20, 0, 100, Easing.BounceOut);
                await trains_btn.TranslateTo(40, 0, 100, Easing.BounceOut);
                await cabs_btn.TranslateTo(60, 0, 100, Easing.BounceOut);

            }
            //await DisplayAlert("Alert", "You have been alerted", "OK");
        }


        //This event is from olx horizontal menu option to view perticular category ad
        private void img_Clicked(object sender, EventArgs e)
        {

        }

        //Add button click for post new Ad
        private async void btnadd_new_ad_Tapped(object sender, EventArgs e)
        {
            try
            {
                //Navigation.PopAsync(false);
               // await Navigation.PushAsync(new Ad_CategoryPage());
            }
            catch (Exception ex)
            {
                var exp = ex.Message;
            }
        }

        private async void tapped_command_Tapped(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync("Hello World");
            var _a = await Clipboard.GetTextAsync();
            await DisplayAlert("Info", "You selected " + _a, "Ok");
        }

        private async void _location_Clicked(object sender, EventArgs e)
        {
            //  var myAction = await DisplayAlert("Location", "Please Turn On Location", "Okay", "CANCEL");
            //await Navigation.PushAsync(new LocationPage());

            var myAction = await DisplayAlert("Location", "Please turn on location", "Okay", "Set Manually");
            if (myAction)
            {
                //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
                Settings._click_for_open_location = "location";

                //Because of this current location function at AppShell page will not work if this would be true.
                Settings._location_already_selected_through_map = "";

                if (Device.RuntimePlatform == global::Xamarin.Forms.Device.Android)
                {

                    //DependencyService.Get<ISettingsService>().OpenSettings();
                    global::Xamarin.Forms.DependencyService.Get<global::AIO.Services.ILocSettings>().OpenSettings();


                }
                else if (Device.RuntimePlatform == global::Xamarin.Forms.Device.iOS)
                {

                    //DependencyService.Get<ISettingsService>().OpenSettings();
                    var url = new NSUrl("App-Prefs:root=LOCATION_SERVICES");

                    if (UIApplication.SharedApplication.CanOpenUrl(url))
                    {
                        UIApplication.SharedApplication.OpenUrl(url);
                    }

                }
                else
                {
                    await Navigation.PushAsync(new LocationPage());
                }               
            }
            else
            {
                await Navigation.PushAsync(new LocationPage());
            }
        }

        

        private async void hotel_booking_Clicked(object sender, EventArgs e)
        {
            try
            {
                string send_city_for_hotel = string.Empty;
                string _title_ = this.Title;
                string[] authorsList = _title_.Split(new Char[] { ',' });

                if (authorsList.Length > 1)
                {
                    int _count = 0;
                    foreach (string author in authorsList)
                    {
                        if (_count == authorsList.Length - 3)
                        {
                            send_city_for_hotel = author;
                        }
                        _count++;
                    }
                        
                    await Navigation.PushAsync(new Hotel_List(send_city_for_hotel));
                }
                else
                {
                    await Navigation.PushAsync(new Hotel_List(_title_));
                }
            }
            catch (Exception e1)
            {
            }
            
        }

        private void add_product_img_clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("Add","Do you want to add new product","Okay");
            popUpLayout.IsVisible = true;
            popUpLayout.IsOpen = true;
        }

        private async void Add_New_Post_Clicked(object sender, EventArgs e)
        {
            try
            {
                popUpLayout.IsOpen = false;
                var _para = (sender as ImageButton).CommandParameter.ToString();

                if (_para != "")
                {

                    switch (_para)
                    {
                        case "cars":
                            // code block
                            await Navigation.PushAsync(new Car_Category_Listing_Page());
                            break;
                        case "":
                            // code block
                            break;
                        case "properties":
                            // code block
                            await Navigation.PushAsync(new Property_Category_Listing_Page());
                            break;
                        case "mobile":
                            // code block
                            await Navigation.PushAsync(new Mobile_Category_Listing_Page());
                            break;
                        case "jobs":
                            // code block
                            await Navigation.PushAsync(new Jobs_Category_Listing_Page());
                            break;
                        case "bikes":
                            // code block
                            await Navigation.PushAsync(new Bike_Category_Listing_Page());
                            break;
                        case "Electronics & Appliances":
                            // code block
                            await Navigation.PushAsync(new Electronics_Category_Listing_Page());
                            break;
                        case "commercial vechicles":
                            // code block
                            await Navigation.PushAsync(new Commercial_Vehicles_Category_Listing_Page());
                            break;
                        case "furniture":
                            // code block
                            await Navigation.PushAsync(new Furniture_Category_Listing_Page());
                            break;
                        case "fashion":
                            // code block
                            await Navigation.PushAsync(new Fashion_Category_Listing_Page());
                            break;
                        case "books and sports":
                            // code block
                            await Navigation.PushAsync(new Books_And_Sports_Category_Listing_Page());
                            break;
                        case "pets":
                            // code block
                            await Navigation.PushAsync(new Pets_Category_Listing_Page());
                            break;
                        case "services":
                            // code block
                            await Navigation.PushAsync(new Services_Category_Listing_Page());
                            break;

                        default:
                            // code block
                            break;
                    }

                }
            }
            catch (Exception e1)
            {
            }
            //await DisplayAlert("Add", "Need to work on that", "Okay");
        }

        private async void get_news_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsDataPage());
        }

        private void more_category_img_Clicked(object sender, EventArgs e)
        {
            MoreCategorypopUpLayout.IsOpen = true;
        }

        private void live_stream_Clicked(object sender, EventArgs e)
        {

        }
    }

    public static class Session_Class
    {
        public static bool _click_for_open_location = false;
    }

}