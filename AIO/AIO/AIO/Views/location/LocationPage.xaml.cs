using AIO.Helper;
using Foundation;
using System;
using System.Threading;
using UIKit;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AIO.Views.location
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : ContentPage
    {

        CancellationTokenSource cts;


        public LocationPage()
        {
            InitializeComponent();
        }

        public LocationPage(string PageNameToBeRedirectForAdPosting)
        {
            InitializeComponent();
            getMessageBox();
        }

        private async void getMessageBox()
        {
            var _a = await DisplayAlert("Important","Please find your current location for Ad Posting","Okay","Cancel");

            if (_a)
            {

            }
            else
            {
                //await Navigation.PushAsync(new );

                App.Current.MainPage = new AppShell();
            }
        }

        //private async void search_location_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    //thats all you need to make a search  

        //    Geocoder geoCoder = new Geocoder();

        //    if (string.IsNullOrEmpty(e.NewTextValue))
        //    {
        //        //list.ItemsSource = Settings.myLocationList.ToList();


        //        //List<Position> position = approximateLocations.ToList();
        //        //string coordinates = $"{position.Latitude}, {position.Longitude}";
        //    }

        //    else
        //    {
        //        //var _data = Settings.myLocationList.ToList();
        //        //list.ItemsSource = _data.Where(x => x._country.ToLower().Contains(e.NewTextValue.ToLower()) ||
        //        //x._state.ToLower().Contains(e.NewTextValue.ToLower()) || x._city.ToLower().Contains(e.NewTextValue.ToLower())
        //        //|| x._area.ToLower().Contains(e.NewTextValue.ToLower()));

        //    }

        //    string _loc = e.NewTextValue + ", India";

        /// <summary>
        ///  Google AutoComplete API for Finding locations
        ///  
        // var address = "https://maps.googleapis.com/maps/api/place/autocomplete/xml?input="+_loc+ "+&types=(cities)&language=pt_BR&key=AIzaSyBhjYJNs9foWX2jQR0ulvXokfT3BmdJObk";
        /// </summary>




        //    var locations = await Geocoding.GetLocationsAsync(_loc);

        //    var location = locations?.Select(x => x).ToList();
        //    var location_1 = location?.FirstOrDefault();

        //    if (location_1 != null)
        //    {
        //        Position position = new Position(location_1.Latitude, location_1.Longitude);
        //        IEnumerable<string> possibleAddresses = await geoCoder.GetAddressesForPositionAsync(position);
        //        string _a = possibleAddresses.FirstOrDefault();
        //    }



        //IEnumerable<Position> approximateLocations = await geoCoder.GetPositionsForAddressAsync("Pacific Ave, San Francisco, California");
        //Position position = approximateLocations.FirstOrDefault();
        //string coordinates = $"{position.Latitude}, {position.Longitude}";
        //}

        //private async void _location_record_Tapped(object sender, EventArgs e)
        //{
        //    AppShell appShell = new AppShell();
        //    await appShell.GetGioLocation();
        //}



        async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.High, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                //var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    // Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    // await DisplayAlert("Location", "Lattitude " + location.Latitude + ". Logitude " + location.Longitude, "Okay");

                    Settings.geolocation_Latitude = location.Latitude.ToString();
                    Settings.geolocation_Longitude = location.Longitude.ToString();

                    //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
                    Settings._click_for_open_location = "location";

                    //Because of this current location function at AppShell page will not work if this would be true.
                    Settings._location_already_selected_through_map = "";

                    App.Current.MainPage = new AppShell();

                    //string isSaved = await _apiServices.LocationSaving(location.Latitude, location.Longitude);

                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                await DisplayAlert("Service", "This device not supported", "Okay");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception

                if (Device.RuntimePlatform == global::Xamarin.Forms.Device.Android)
                {
                    //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
                    Settings._click_for_open_location = "location";

                    //Because of this current location function at AppShell page will not work if this would be true.
                    Settings._location_already_selected_through_map = "";

                    //DependencyService.Get<ISettingsService>().OpenSettings();
                    global::Xamarin.Forms.DependencyService.Get<global::AIO.Services.ILocSettings>().OpenSettings();

                }
                else if (Device.RuntimePlatform == global::Xamarin.Forms.Device.iOS)
                {
                    //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
                    Settings._click_for_open_location = "location";

                    //Because of this current location function at AppShell page will not work if this would be true.
                    Settings._location_already_selected_through_map = "";


                    //DependencyService.Get<ISettingsService>().OpenSettings();
                    var url = new NSUrl("App-Prefs:root=LOCATION_SERVICES");

                    if (UIApplication.SharedApplication.CanOpenUrl(url))
                    {
                        UIApplication.SharedApplication.OpenUrl(url);
                    }
                }
                else
                {
                    await DisplayAlert("Not responding", "Your device is not responding. Please try again later.", "Okay");
                }

            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                if (Device.RuntimePlatform == global::Xamarin.Forms.Device.Android)
                {
                    //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
                    Settings._click_for_open_location = "location";

                    //Because of this current location function at AppShell page will not work if this would be true.
                    Settings._location_already_selected_through_map = "";

                    //DependencyService.Get<ISettingsService>().OpenSettings();
                    global::Xamarin.Forms.DependencyService.Get<global::AIO.Services.ILocSettings>().OpenSettings();

                }
                else if (Device.RuntimePlatform == global::Xamarin.Forms.Device.iOS)
                {
                    //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
                    Settings._click_for_open_location = "location";

                    //Because of this current location function at AppShell page will not work if this would be true.
                    Settings._location_already_selected_through_map = "";

                    //DependencyService.Get<ISettingsService>().OpenSettings();
                    var url = new NSUrl("App-Prefs:root=LOCATION_SERVICES");

                    if (UIApplication.SharedApplication.CanOpenUrl(url))
                    {
                        UIApplication.SharedApplication.OpenUrl(url);
                    }
                }
                else
                {
                    await DisplayAlert("Device", "Please try again.", "Okay");
                }
            }
            catch (Exception ex)
            {
                // Unable to get location
                await DisplayAlert("GPS Enabled", "Something went wrong to get your location.", "Okay");
            }
        }



        private void map_MapClicked(object sender, MapClickedEventArgs e)
        {
            //var _a = e.Position;
            //int _o = 0;

            Settings.geolocation_Latitude = e.Position.Latitude.ToString();
            Settings.geolocation_Longitude = e.Position.Longitude.ToString();

            //await Navigation.PushAsync(new HomePage());

            //Because of this now on application load current location function will not fire automatically
            Settings._location_already_selected_through_map = "map";


            //With the help of this, when user switch on the current location so at the time of application resume, current location function will work
            Settings._click_for_open_location = "";

            App.Current.MainPage = new AppShell();
        }

    }


    public static class Session_Class_map_location_selected
    {
        public static bool _location_already_selected_through_map;
    }
}