using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AIO.Models.Ad_Post
{
    class CarBrand
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
    }

    class Car_Variant_Name
    {
        public int id { get; set; }
        public int CarBrand_id { get; set; }
        public string CarVariantName { get; set; }
    }

    class Car_Model_Name
    {
        public int id { get; set; }
        public int Car_Variant_Name_id { get; set; }
        public string CarModelName { get; set; }
    }

    class Fuel_Type
    {
        public int id { get; set; } 
        public string _fuel_type { get; set; }
    }
    class onwership_type_
    { 
        public string _onwer_ship_number { get; set; }
    }
    class _show_image
    { 
        public ImageSource ImageUrl { get; set; }
    }
}
