using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class PetsCategoryListViewModel
    {
        public List<Furniture_Type_Model> _pets_list = null;

        public PetsCategoryListViewModel()
        {
            _pets_list = new List<Furniture_Type_Model>()
            {
                new Furniture_Type_Model
                {
                    ID = 1,
                    Furniture_Type_Name = "Fishes & Aquarium"
                },
                new Furniture_Type_Model
                {
                    ID = 2,
                    Furniture_Type_Name = "Pet Food & Accessories"
                },
                new Furniture_Type_Model
                {
                    ID = 3,
                    Furniture_Type_Name = "Dogs"
                },
                new Furniture_Type_Model
                {
                    ID = 4,
                    Furniture_Type_Name = "Other Pets"
                }
            };
        }
    }
}
