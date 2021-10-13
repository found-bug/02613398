using AIO.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}