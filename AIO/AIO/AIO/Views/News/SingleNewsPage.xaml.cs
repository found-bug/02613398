using AIO.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.News
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleNewsPage : ContentPage
    {
        List<_articles_data_new> _articles = new List<_articles_data_new>();
        public SingleNewsPage(_articles_data_new _get_data)
        {
            InitializeComponent();

            _articles.Add(_get_data);

            _news_list.ItemsSource = _articles.ToList();
        }
    }
}