using AIO.Services;
using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.OTT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Play_Single_Video : ContentPage
    {
        //public Play_Single_Video()
        //{
        //    InitializeComponent();
        //}

        string Url = string.Empty; string title = string.Empty;  

        LibVLC _vlc;

        public Play_Single_Video(string _url, string _title)
        {
            InitializeComponent();
            Core.Initialize();
            Url = _url;
            title = _title; 
           
            _vlc = new LibVLC();   
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.Title = title;

            var media = new Media(_vlc, Url, FromType.FromLocation);
            video_player.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(media) { EnableHardwareDecoding = true };

            
            video_player.MediaPlayer.Play();

            FlyoutItem flyoutItem = new FlyoutItem();

            Shell.SetNavBarIsVisible(flyoutItem, false);
            Shell.SetNavBarIsVisible(this, false);
           // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

            DependencyService.Get<IOrientationService>().Landscape();


            video_player.MediaPlayer.Fullscreen = true;
            video_player.MediaPlayer.Volume = 80;



            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            var _a = mainDisplayInfo.Width;
            var _b = mainDisplayInfo.Height;

            //var _c = App.screenHeight;
            //var _d = App.screenWidth;

            video_player.WidthRequest = _a;
            video_player.HeightRequest = _b+20;

            DeviceDisplay.KeepScreenOn = !DeviceDisplay.KeepScreenOn;
        }



        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            video_player.MediaPlayer.Stop();

            DependencyService.Get<IOrientationService>().Portrait();


            DeviceDisplay.KeepScreenOn = DeviceDisplay.KeepScreenOn;
        }

         

    }
}