using AIO.ViewModels;
using AIO.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;


using AIO.Views.general_forms; 
using System.Threading;
using Xamarin.Essentials;
using System.Linq; 
using AIO.Helper;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Foundation;
using UIKit;
using AIO.Views.location;

namespace AIO
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        CancellationTokenSource cts;

        public static bool _permission_for_location = false;

        public AppShell()
        {
            InitializeComponent();


           // get_loaction();
        }

        public async void get_loaction()
        {
            if (Settings._location_already_selected_through_map == "")
            {
                var _a = await GetGioLocation();

                if (_a)
                {
                    Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
                }
                else
                {
                    //get_loaction();
                }
            }
        }


        public async Task<bool> GetGioLocation()
        {
            bool _found_lat_long = false;
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

                    //string isSaved = await _apiServices.LocationSaving(location.Latitude, location.Longitude);
                    _found_lat_long = true;
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
                if (!_permission_for_location)
                {

                    _permission_for_location = await DisplayAlert("Location", "Please turn on your location", "Okay", "Cancel");

                    if (_permission_for_location)
                    {
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
                            await DisplayAlert("Device", "Please try again.", "Okay");
                        }
                    }
                    else
                    {
                        //await DisplayAlert("Alert", "User Denied Permission", "Okay");

                        //If user dont want to share his live location so we can offer him to type there location

                        //if (string.IsNullOrEmpty(Settings.geolocation_Latitude) && string.IsNullOrEmpty(Settings.geolocation_Longitude))
                        //{
                        //    var _lat = "20.5937"; var _long = "78.9629";

                        //    Settings.geolocation_Latitude = _lat;
                        //    Settings.geolocation_Longitude = _long;
                        //}
                    }
                }

            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                var result = await DisplayAlert("GPS Enabled", "Please Allow GPS to get your location.", "Okay", "Cancel");
                if (result)
                {
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
                        await DisplayAlert("Device", "Please try again.", "Okay");
                    }
                }
                else
                {
                    //System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
                }
            }
            catch (Exception ex)
            {
                // Unable to get location
                await DisplayAlert("GPS Enabled", "Something went wrong to get your location.", "Okay");
            }
            return _found_lat_long;
        }



        private void Login_Clicked(object sender, EventArgs e)
        {

        }
    }
}
