using AIO.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AIO.ViewModels
{
    class VIdeoViewModel : BaseViewModel
    {
        public VIdeoViewModel()
        {
            Title = "Videos";
            Cards = new ObservableCollection<VideoCard>
            {
                new VideoCard
                {
                    ID = 1,
                    Title = "Video",
                    SubTitle = "OASIS",
                    Details = "Album by Bad Bunny & J Balvin • 8 songs",
                    ImageUrl = "https://www.radioactiva.cl/wp-content/uploads/2019/07/bad.jpg",
                    VideoUrl = "https://samplelib.com/lib/preview/mp4/sample-30s.mp4"
                },
                new VideoCard
                {
                    ID = 2,
                    Title = "Recommended new releases",
                    SubTitle = "Portratit of The Dogg",
                    Details = "Album by Snoop Dogg • 12 songs",
                    ImageUrl = "https://direct.rhapsody.com/imageserver/images/alb.394056178/500x500.jpg",
                    VideoUrl = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"
                },
                new VideoCard
                {
                    ID = 3,
                    Title = "Playing Near You",
                    SubTitle = "Alemán",
                    Details = "Friday, 18 Oct",
                    ImageUrl = "https://yt3.ggpht.com/a/AGF-l79MTIhLC8Y-EFKq2Kl7FaqihciB3geKMPnbNw=s288-c-k-c0xffffffff-no-rj-mo",
                    VideoUrl = "https://sec.ch9.ms/ch9/e68c/690eebb1-797a-40ef-a841-c63dded4e68c/Cognitive-Services-Emotion_high.mp4"
                },
                new VideoCard
                {
                    ID = 3,
                    Title = "Near You",
                    SubTitle = "Alemán",
                    Details = "Friday, 18 Oct",
                    ImageUrl = "https://www.radioactiva.cl/wp-content/uploads/2019/07/bad.jpg",
                    VideoUrl = "https://samplelib.com/lib/preview/mp4/sample-30s.mp4"
                }
            };
        }

        public ObservableCollection<VideoCard> Cards { get; }
    }
}
