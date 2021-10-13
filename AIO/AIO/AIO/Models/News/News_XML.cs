using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.News
{
     
    public class _articles_data
    {
        public string title { get; set; }
        public string author { get; set; }
        public DateTime published_date { get; set; } 
        public string published_date_precision { get; set; }
        public string link { get; set; }
        public string clean_url { get; set; }
        public string summary { get; set; }
        public string rights { get; set; } 
        public int rank { get; set; }
        public string topic { get; set; }
        public string country { get; set; }
        public string language { get; set; }
        public string[] authors { get; set; }
        public string media { get; set; }
        public string is_opinion { get; set; }
        public string twitter_account { get; set; }
        public string _score { get; set; }
        public string _id { get; set; }
    }
    public class _articles_data_new
    {
        public string id { get; set; }
        public string title { get; set; }
        public DateTime datePublished { get; set; } 
        public string description { get; set; }
        public string language { get; set; }
        public string image { get; set; }
        public string thumbnail { get; set; } 
    }
}
