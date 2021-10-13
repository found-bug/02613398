using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.OTT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YTCardView : ContentView
    {
        public YTCardView()
        {
            InitializeComponent();
        }

        private void Video_Thumbnail_Clicked(object sender, EventArgs e)
        {
            try
            {
                var _url = (sender as ImageButton).CommandParameter.ToString();
                int _a = 0;
            }
            catch (Exception e1)
            {
            }
        }
    }
}