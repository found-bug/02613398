using AIO.ViewModels;
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
    public partial class OTTPage : ContentPage
    {
        //string url = "https://sec.ch9.ms/ch9/e68c/690eebb1-797a-40ef-a841-c63dded4e68c/Cognitive-Services-Emotion_high.mp4";

        public OTTPage()
        {
            InitializeComponent();
            // Browser.Source = "https://www.youtube.com";

          
        }

        private async void Video_Thumbnail_Clicked(object sender, EventArgs e)
        {
            try
            {
                var _url = Convert.ToInt32((sender as ImageButton).CommandParameter.ToString());

                VIdeoViewModel _videoViewModel = new VIdeoViewModel();
                var _data = _videoViewModel.Cards.Where(x => x.ID == _url).Select(x => x).FirstOrDefault();

                if (_data != null)
                {
                    await Navigation.PushAsync(new Play_Single_Video(_data.VideoUrl, _data.Title));
                }
                else
                {
                    await DisplayAlert("Caution","Something went wrong. Please try again later","Okay");
                }
            }
            catch (Exception e1)
            {
            }
        }

         

        //private void VideoPlayer_FullScreenStatusChanged(object sender, bool value)
        //{
        //    NavigationPage.SetHasNavigationBar(this, !value);
        //}

        //private void Scrollview_Scrolled(object sender, ScrolledEventArgs e)
        //{
        //    videoPlayer.HideSeekbar();
        //}

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await Task.Delay(4000);
        //    videoPlayer.FullScreen(true);
        //    //await Task.Delay(4000);
        //    //videoPlayer.ExitFullScreen();
        //}


    }
}



////protected override void OnAppearing()
////{
////    base.OnAppearing();
////    NavigationPage.SetHasNavigationBar(this, false);
////}

////private void Browser_Navigating(object sender, WebNavigatedEventArgs e)
////{
////    LoadingLable.IsVisible = true;
////}

////private void Browser_Navigated_1(object sender, WebNavigatedEventArgs e)
////{
////    LoadingLable.IsVisible = true;
////} 
//}
//}