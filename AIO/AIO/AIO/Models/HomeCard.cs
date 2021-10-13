using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models
{
    public class HomeCard
    {
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string category { get; set; }

        public string Details { get; set; }
        public string location { get; set; }
        public string offer_url { get; set; }
        public string command_parameter { get; set; }

        public string Country { get; set; }
        public string PhoneNumber { get; set; }
    }


    public class Second_HomeCard
    {
        public string ImageUrl { get; set; }

        public string Title { get; set; } 
        public string cmd_parameter { get; set; } 
    }
     
}
