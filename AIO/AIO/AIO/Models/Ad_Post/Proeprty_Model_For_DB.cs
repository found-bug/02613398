using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.Ad_Post
{
    class Proeprty_Model_For_DB
    {
        public string Property_Category { get; set; }
        public string Property_is_for_sale_or_on_rent { get; set; }
        public string property_listed_by { get; set; }
        public string Property_Site_Facing { get; set; }

        //Appartment,Builder Floors, Farm House or House & Villa
        public string Property_Type { get; set; }
        public int Bedroom_count { get; set; }
        public int bathroom_count { get; set; }
        public string Furnished_or_not { get; set; }
        public string how_old_property_construction { get; set; }
        public int house_Builtup_Area { get; set; }
        public int house_Carpet_Area { get; set; }
        public double Maintenance_Cost { get; set; }
        public int house_Total_Floors { get; set; }
        public int number_of_Car_Parking { get; set; }
        public string Project_Name { get; set; }
        public int MPlot_Area { get; set; }
        public int plot_Length { get; set; }
        public int plot_Breadth { get; set; }
        public int Shop_Area { get; set; }
        public int Shop_Length { get; set; }
        public int Shop_Breadth { get; set; }

        //Llike pg, Guest House or Roommate
        public string Building_Sub_Type { get; set; }
        public string Meals_included_or_not { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> img_string64_path { get; set; } 
    }
}
