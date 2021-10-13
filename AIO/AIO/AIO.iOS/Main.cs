using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AIO.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(216, 32, 58); //Any color


            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
