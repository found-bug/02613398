using AIO.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }



        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //thats all you need to make a search  

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                list.ItemsSource = Settings.myProductList.ToList();
            }

            else
            {
                var _data = Settings.myProductList.ToList();
                list.ItemsSource = _data.Where(x => x.ProductName.ToLower().Contains(e.NewTextValue.ToLower()) ||
                x.ProductCategory.ToLower().Contains(e.NewTextValue.ToLower()) || x.ProductCode.ToLower().Contains(e.NewTextValue.ToLower()));
            }
        }

        private async void _search_record_Tapped(object sender, EventArgs e)
        {
            try
            {
                string _productPageCategoryType = (sender as TextCell).CommandParameter.ToString();

                //((App)Parent).MainPage = new AppShell();
                await Navigation.PushAsync(new SearchResult(_productPageCategoryType));
            }
            catch (Exception e1)
            {

                //throw;
            }
        }
    }
}