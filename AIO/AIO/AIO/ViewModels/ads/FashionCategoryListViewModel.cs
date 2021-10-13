using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class FashionCategoryListViewModel
    {
        public List<Furniture_Type_Model> _fashion_is_for = null;

        public FashionCategoryListViewModel()
        {
            _fashion_is_for = new List<Furniture_Type_Model>()
            {
                new Furniture_Type_Model
                {
                    ID = 1,
                    Furniture_Type_Name = "Mens"
                },
                new Furniture_Type_Model
                {
                    ID = 2,
                    Furniture_Type_Name = "Womens"
                },
                new Furniture_Type_Model
                {
                    ID = 3,
                    Furniture_Type_Name = "Kids"
                }
            };
        }

    }
}
