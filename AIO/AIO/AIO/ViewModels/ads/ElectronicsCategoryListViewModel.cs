using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class ElectronicsCategoryListViewModel
    {
        public List<Electronics_Category_Model> _electronics_Category_Models = null;

        public ElectronicsCategoryListViewModel()
        {
            _electronics_Category_Models = new List<Electronics_Category_Model>()
            {
                new Electronics_Category_Model()
                {
                    ID = 1,
                    CategoryName = "TVs, Video - Audio"
                },
                new Electronics_Category_Model()
                {
                    ID = 2,
                    CategoryName = "Kitchen & Other Appliances"
                },
                new Electronics_Category_Model()
                {
                    ID = 3,
                    CategoryName = "Computer & Laptops"
                },
                new Electronics_Category_Model()
                {
                    ID = 4,
                    CategoryName = "Cameras & Lenses"
                },
                new Electronics_Category_Model()
                {
                    ID = 5,
                    CategoryName = "Games & Entertainments"
                },
                new Electronics_Category_Model()
                {
                    ID = 6,
                    CategoryName = "Fridges"
                },
                new Electronics_Category_Model()
                {
                    ID = 7,
                    CategoryName = "Computer & Accessories"
                },
                new Electronics_Category_Model()
                {
                    ID = 8,
                    CategoryName = "Hard Disks, Printers & Monitors"
                },
                new Electronics_Category_Model()
                {
                    ID = 9,
                    CategoryName = "ACs"
                },
                new Electronics_Category_Model()
                {
                    ID = 10,
                    CategoryName = "Washing Machines"
                },
            };
        }
    }
}
