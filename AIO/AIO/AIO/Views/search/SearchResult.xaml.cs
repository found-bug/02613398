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
    public partial class SearchResult : ContentPage
    {
        public SearchResult(string result)
        {
            InitializeComponent();
        }
    }
}