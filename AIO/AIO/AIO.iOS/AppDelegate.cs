using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading.Forms.Platform;
using Foundation;
using LibVLCSharp.Forms.Shared;

using UIKit;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace AIO.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //Getting Screen Width and Height
            App.screenWidth = (int)UIScreen.MainScreen.Bounds.Width;
            App.screenHeight = (int)UIScreen.MainScreen.Bounds.Height;



            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAwODU1QDMxMzgyZTMyMmUzMEd3dTlCM3dsYW5jNEIvajBsbUMrUmhpQis2MHRkajBxRjNqQjB4ajRvSG89");
            Xamarin.Forms.Forms.SetFlags(new string[] { "Brush_Experimental", "CarouselView_Experimental", "IndicatorView_Experimental", "Shapes_Experimental" });

            UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView; if (statusBar != null && statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = UIColor.FromRGB(216, 32, 58); // change to your desired color }
            }

            LibVLCSharpFormsRenderer.Init();
            global::Xamarin.Forms.Forms.Init();

            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();

            LoadApplication(new App());



            return base.FinishedLaunching(app, options);
        }



        //Below code is for desable screenshot from IOS Device
        public override void OnResignActivation(UIApplication uiApplication)
        {
            base.OnResignActivation(uiApplication);
            // Prevent taking snapshot
            uiApplication.IgnoreSnapshotOnNextApplicationLaunch();
            var bgView = new UIView(uiApplication.KeyWindow.Frame) { Tag = 42, Alpha = 0, BackgroundColor = Color.FromHex("#449CD5").ToUIColor() };
            uiApplication.KeyWindow.AddSubview(bgView);
            uiApplication.KeyWindow.BringSubviewToFront(bgView);
            UIView.Animate(0.5, () =>
            {
                bgView.Alpha = 1;
            });
        }
        public override void OnActivated(UIApplication uiApplication)
        {
            base.OnActivated(uiApplication);
            var view = uiApplication.KeyWindow.ViewWithTag(42);
            if (view != null)
            {
                UIView.Animate(0.5, () =>
                {
                    view.Alpha = 0;
                }, () =>
                {
                    view.RemoveFromSuperview();
                });
            }
        }
    }
}
