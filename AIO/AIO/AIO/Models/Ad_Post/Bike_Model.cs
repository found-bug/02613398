using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.Ad_Post
{
    class Bike_Category
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
    }
    class Bike_model
    {
        public int id { get; set; }
        public int Bike_Category_id { get; set; }
        public string modelName { get; set; }
    }
}
