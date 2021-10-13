using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Plugin.Media; 
using LibVLCSharp.Forms.Shared;
using FFImageLoading.Forms.Platform;
using Android.Content;
using Android.Views;

namespace AIO.Droid
{
    [Activity(Label = "Aazmao", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize /*| ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.FullSensor*/)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            //base.OnCreate(savedInstanceState);

            //This plugin is for selecting multiple images from gallery
            NativeMedia.Platform.Init(this, savedInstanceState);

            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //LoadApplication(new App());
             

            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);

            base.OnCreate(savedInstanceState);

            //Getting Screen Width and Height
            var pixels = Resources.DisplayMetrics.WidthPixels;
            var scale = Resources.DisplayMetrics.Density;
            var dps = (double)((pixels - 0.5f) / scale);
            var ScreenWidth = (int)dps;
            App.screenWidth = ScreenWidth;
            pixels = Resources.DisplayMetrics.HeightPixels;
            dps = (double)((pixels - 0.5f) / scale);
            var ScreenHeight = (int)dps;
            App.screenHeight = ScreenHeight;


            //Official Release : 18.2.0.44 Key
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAwODU1QDMxMzgyZTMyMmUzMEd3dTlCM3dsYW5jNEIvajBsbUMrUmhpQis2MHRkajBxRjNqQjB4ajRvSG89");
            Xamarin.Forms.Forms.SetFlags(new string[] { "Brush_Experimental", "CarouselView_Experimental", "IndicatorView_Experimental", "Shapes_Experimental" });


            //Stop taking screenshot from phone
            Window.SetFlags(WindowManagerFlags.Secure, WindowManagerFlags.Secure);



            LibVLCSharpFormsRenderer.Init();

            global::Xamarin.Forms.Forms.SetFlags("Shell_Experimental", "Visual_Experimental", "CollectionView_Experimental", "FastRenderers_Experimental");

            //Xamarin.FormsGoogleMaps.Init(this, savedInstanceState);

            //for upload or click image from mobile device
            await CrossMedia.Current.Initialize();

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //for upload or click image from mobile device
            await CrossMedia.Current.Initialize();

            Xamarin.FormsMaps.Init(this, savedInstanceState);

            LoadApplication(new App());
        }


        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (NativeMedia.Platform.CheckCanProcessResult(requestCode, resultCode, data))
            {
                NativeMedia.Platform.OnActivityResult(requestCode, resultCode, data);
            }

            base.OnActivityResult(requestCode, resultCode, data);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}