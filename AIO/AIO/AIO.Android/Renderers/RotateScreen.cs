using AIO.Droid.Renderers;
using AIO.Services;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace AIO.Droid.Renderers
{
    public class OrientationService : IOrientationService
    {
        [Obsolete]
        public void Landscape()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Landscape;
        }

        [Obsolete]
        public void Portrait()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Portrait;
        }
    }
}