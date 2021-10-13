using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class FurnitureCategoryListViewModel
    {
        public List<Furniture_Type_Model> _furniture_Type_Models = null;

        public FurnitureCategoryListViewModel()
        {
            _furniture_Type_Models = new List<Furniture_Type_Model>()
            {
                new Furniture_Type_Model
                {
                    ID = 1,
                    Furniture_Type_Name = "Sofa & Dining"
                },
                new Furniture_Type_Model
                {
                    ID = 2,
                    Furniture_Type_Name = "Beds & Wardrobes"
                },
                new Furniture_Type_Model
                {
                    ID = 3,
                    Furniture_Type_Name = "Home Decor & Garden"
                },
                new Furniture_Type_Model
                {
                    ID = 4,
                    Furniture_Type_Name = "Kids Furniture"
                },
                new Furniture_Type_Model
                {
                    ID = 5,
                    Furniture_Type_Name = "Other Household Items"
                },
            };
        }

    }
}
