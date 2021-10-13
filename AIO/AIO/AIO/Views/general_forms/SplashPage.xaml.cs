using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.general_forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();

            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(300);
            //await splashImage.ScaleTo(1, 900);
            // await splashImage.ScaleTo(1, 2000); //Time consuming process such as initialization 
            //SetMainPage();
            App.Current.MainPage = new AppShell();
        }

    }
}