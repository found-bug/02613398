using AIO.Views.general_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetworkNotConnectedPage : ContentPage
    {
        public NetworkNotConnectedPage()
        {
            InitializeComponent();
        }

        private async void try_again_Clicked(object sender, EventArgs e)
        {
            try
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    App.Current.MainPage = new SplashPage(); 
                }
                else
                {
                    await DisplayAlert("Alert", "No internet found", "Okay");
                }
            }
            catch (Exception e1)
            {
            }
        }
    }
}