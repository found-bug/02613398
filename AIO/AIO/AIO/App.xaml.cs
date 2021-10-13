using AIO.Services;
using AIO.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 
using AIO.Views.general_forms;
using AIO.Helper;
using Xamarin.Essentials;

namespace AIO
{
    public partial class App : Application
    {
        public static int screenHeight, screenWidth;
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAwODU1QDMxMzgyZTMyMmUzMEd3dTlCM3dsYW5jNEIvajBsbUMrUmhpQis2MHRkajBxRjNqQjB4ajRvSG89");
            InitializeComponent();

            //var current = Connectivity.NetworkAccess;
            //if (current == NetworkAccess.Internet)
            //{
                DependencyService.Register<MockDataStore>();
                MainPage = new SplashPage();
            //}
            //else
            //{
            //    MainPage = new NetworkNotConnectedPage();
            //}  
        }
         

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override async void OnResume()
        {
            //Checking if user clicks on the icon of location to turn on current location through Home Page
            if (Settings._click_for_open_location == "location")
            {
                AppShell appShell = new AppShell();
                await appShell.GetGioLocation();

                Settings._click_for_open_location = "";

                App.Current.MainPage = new AppShell();
            }
        }
    }
}
