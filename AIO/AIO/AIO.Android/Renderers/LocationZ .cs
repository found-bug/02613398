using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AIO.Droid.Renderers;
using AIO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(LocationZ))]
namespace AIO.Droid.Renderers
{
    using System.Runtime.Remoting.Messaging;

    using Android.Support.V4.View;
    using Android.Support.V7.App;

    using Xamarin.Forms;
    using AIO;
    using Android.Locations;

    public class LocationZ : ILocSettings
    {
        [Obsolete]
        public void OpenSettings()
        {
            LocationManager LM = (LocationManager)Forms.Context.GetSystemService(Context.LocationService);


            if (LM.IsProviderEnabled(LocationManager.GpsProvider) == false)
            {
                Context ctx = Forms.Context;
                ctx.StartActivity(new Intent(Android.Provider.Settings.ActionLocationSourceSettings));
            }
            else
            {
                //this is handled in the PCL
            }
        }
    }
}