using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class BooksAndSportsCategoryListViewModel
    {
        public List<Furniture_Type_Model> _books_and_sports_list = null;

        public BooksAndSportsCategoryListViewModel()
        {
            _books_and_sports_list = new List<Furniture_Type_Model>()
            {
                new Furniture_Type_Model
                {
                    ID = 1,
                    Furniture_Type_Name = "Books"
                },
                new Furniture_Type_Model
                {
                    ID = 2,
                    Furniture_Type_Name = "Gym & Fitness"
                },
                new Furniture_Type_Model
                {
                    ID = 3,
                    Furniture_Type_Name = "Musical Intruments"
                },
                new Furniture_Type_Model
                {
                    ID = 4,
                    Furniture_Type_Name = "Sports Equipments"
                },
                new Furniture_Type_Model
                {
                    ID = 5,
                    Furniture_Type_Name = "Other Hobbies"
                }
            };
        }
    }
}
