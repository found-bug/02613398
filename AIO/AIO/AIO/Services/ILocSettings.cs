using System;
using System.Collections.Generic;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(AIO.Services.ILocSettings))]
namespace AIO.Services
{
    public interface ILocSettings
    {
        void OpenSettings();

    }
}
