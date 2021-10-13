using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AIO.Models;

namespace AIO.Views._browse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowsePage : ContentPage
    {
        string _search = string.Empty;

        public BrowsePage()
        {
            InitializeComponent();
            Browser.Source = "https://www.google.com";
        }


        public void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            _search = e.NewTextValue;
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }

        }

        //private void Forward_Clicked(object sender, EventArgs e)
        //{
        //    if (Browser.CanGoForward)
        //    {
        //        Browser.GoForward();
        //    }
        //}

        private void Go_Clicked(object sender, EventArgs e)
        {
            Browser.Source = _search;
        }

        private void Browser_Navigating(object sender, WebNavigatedEventArgs e)
        {
            LoadingLable.IsVisible = true;
        }

        private void Browser_Navigated_1(object sender, WebNavigatedEventArgs e)
        {
            LoadingLable.IsVisible = true;
        }
    }
     
}
