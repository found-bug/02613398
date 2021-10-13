using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class ServicesCategoryListViewModel
    {
        public List<Furniture_Type_Model> _services_list = null;

        public ServicesCategoryListViewModel()
        {
            _services_list = new List<Furniture_Type_Model>()
            {
                new Furniture_Type_Model
                {
                    ID = 1,
                    Furniture_Type_Name = "Electronics & Computer"
                },
                new Furniture_Type_Model
                {
                    ID = 2,
                    Furniture_Type_Name = "Education & Classes"
                },
                new Furniture_Type_Model
                {
                    ID = 3,
                    Furniture_Type_Name = "Drivers & Taxi"
                },
                new Furniture_Type_Model
                {
                    ID = 4,
                    Furniture_Type_Name = "Health & Beauty"
                },
                new Furniture_Type_Model
                {
                    ID = 5,
                    Furniture_Type_Name = "Other Services"
                }
            };
        }
    }
}
