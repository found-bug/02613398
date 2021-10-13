using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models
{
    class YoutubeItem
    {
        public string VideoId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ChannelTitle { get; set; }

        public string DefaultThumbnailUrl { get; set; }

        public string MediumThumbnailUrl { get; set; }

        public string HighThumbnailUrl { get; set; }

        public string StandardThumbnailUrl { get; set; }

        public string MaxResThumbnailUrl { get; set; }

        public DateTime PublishedAt { get; set; }

        public int? ViewCount { get; set; }

        public int? LikeCount { get; set; }

        public int? DislikeCount { get; set; }

        public int? FavoriteCount { get; set; }

        public int? CommentCount { get; set; }

        public List<string> Tags { get; set; }
    }

    public class Artist
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }


    public class VideoCard
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Details { get; set; }
        public string VideoUrl { get; set; }
    }
}
