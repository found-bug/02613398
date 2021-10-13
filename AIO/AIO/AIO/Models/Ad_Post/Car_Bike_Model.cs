using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.Ad_Post
{
    public class Car_Bike_Model
    {
        public string User_ID { get; set; }

        //Means this product belongs to car, bike, job, furniture etc
        public string Product_Type { get; set; }
        public string Product_Brand_Name { get; set; }
        public string ProducT_Brand_Model { get; set; }
        public string ProducT_Brand_Model_Variant_Name { get; set; }
        public int Manufacturer_Year { get; set; }
        public string Fuel_Type { get; set; }

        // Like Automatic or Manual
        public string Transmisstion_Type { get; set; }
        public int KM_Driven { get; set; }
        public int Number_Of_Onwers { get; set; }
        public string _location { get; set; }
        public string _title { get; set; }
        public string _description { get; set; }
        public double price { get; set; }
        public List<string> img_source { get; set; }
    }
}
