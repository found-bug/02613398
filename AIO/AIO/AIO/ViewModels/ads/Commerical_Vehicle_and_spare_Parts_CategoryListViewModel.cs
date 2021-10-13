using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class Commerical_Vehicle_and_spare_Parts_CategoryListViewModel
    {
        public List<Commercial_Vehicles_Ad_Type> _Ad_Types = null;
        public List<Commercial_Vehicles_Category> _commercial_Vehicles_Categories = null;
        public List<Commercial_Vehicles_Model_Type> _commercial_Vehicles_Model_Types = null;
        public List<Spare_Parts_Type> _spare_Parts_Types = null;

        public Commerical_Vehicle_and_spare_Parts_CategoryListViewModel()
        {
            _Ad_Types = new List<Commercial_Vehicles_Ad_Type>()
            {
                new Commercial_Vehicles_Ad_Type
                {
                    ID = 1,
                    Category_Name = "Commercial & Other Vehicles"
                },
                new Commercial_Vehicles_Ad_Type
                {
                    ID = 2,
                    Category_Name = "Spare Parts"
                }
            };


            _commercial_Vehicles_Categories = new List<Commercial_Vehicles_Category>()
            {
                new Commercial_Vehicles_Category
                {
                    ID = 1,
                    CategoryName = "Auto-Rickshaws & E-Rickshaws"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 2,
                    CategoryName = "Buses"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 3,
                    CategoryName = "Trucks"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 4,
                    CategoryName = "Heavy Machinery"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 5,
                    CategoryName = "Modified Jeeps"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 6,
                    CategoryName = "Pick-up vans / Pick-up trucks"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 7,
                    CategoryName = "Scrap Cars"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 8,
                    CategoryName = "Taxi Cabs"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 9,
                    CategoryName = "Tractors"
                },
                new Commercial_Vehicles_Category
                {
                    ID = 10,
                    CategoryName = "Others"
                },
            };


            _commercial_Vehicles_Model_Types = new List<Commercial_Vehicles_Model_Type>()
            {
                new Commercial_Vehicles_Model_Type
                {
                    ID = 1,
                    ID_Commercial_Vehicles_Category = 1,
                    ModelName = "Auto Rickshaw"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 2,
                    ID_Commercial_Vehicles_Category = 1,
                    ModelName = "E-Rickshaw"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 3,
                    ID_Commercial_Vehicles_Category = 2,
                    ModelName = "Ashok Leyland"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 4,
                    ID_Commercial_Vehicles_Category = 2,
                    ModelName = "Eicher"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 5,
                    ID_Commercial_Vehicles_Category = 2,
                    ModelName = "Force Motor Ltd"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 6,
                    ID_Commercial_Vehicles_Category = 2,
                    ModelName = "SML"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 7,
                    ID_Commercial_Vehicles_Category = 2,
                    ModelName = "TATA Motors"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 8,
                    ID_Commercial_Vehicles_Category = 2,
                    ModelName = "Others"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 9,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Ashok Leyland"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 10,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Bharat Benz"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 11,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Force Motors Ltd"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 12,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Mahindra"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 13,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "SML"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 14,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Eicher"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 15,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "TATA Motors"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 16,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Asia Motors Works (AMW)"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 17,
                    ID_Commercial_Vehicles_Category = 3,
                    ModelName = "Others"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 18,
                    ID_Commercial_Vehicles_Category = 4,
                    ModelName = "Heavy Machinery"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 19,
                    ID_Commercial_Vehicles_Category = 5,
                    ModelName = "Modified Jeeps"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 20,
                    ID_Commercial_Vehicles_Category = 6,
                    ModelName = "Ashok Leyland"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 21,
                    ID_Commercial_Vehicles_Category = 6,
                    ModelName = "Force Motors"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 22,
                    ID_Commercial_Vehicles_Category = 6,
                    ModelName = "Hindustan Motors"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 23,
                    ID_Commercial_Vehicles_Category = 6,
                    ModelName = "Piaggio"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 24,
                    ID_Commercial_Vehicles_Category = 6,
                    ModelName = "TATA Motors"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 25,
                    ID_Commercial_Vehicles_Category = 6,
                    ModelName = "Others"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 26,
                    ID_Commercial_Vehicles_Category = 7,
                    ModelName = "Scrap Cars"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 27,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Toyota"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 28,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Maruti Suzuki"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 29,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Honda"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 30,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Renault"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 31,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Mahindra"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 32,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Nissan"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 33,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Ford"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 34,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Others"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 35,
                    ID_Commercial_Vehicles_Category = 8,
                    ModelName = "Hyundai"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 36,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "John Deere"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 37,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "TAFE"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 38,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Escorts"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 39,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Solis"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 40,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Digitrac"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 41,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Swaraj"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 42,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Mahindra"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 43,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Messey Ferguson"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 44,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Sonalika"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 45,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "New Holland"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 46,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Ace"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 47,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Eimco"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 48,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Force"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 49,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Hindustan"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 50,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "HMT"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 51,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Indofarm"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 52,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "MF"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 53,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "MGTI"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 54,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "NH"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 55,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Preet"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 56,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Same"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 57,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Standard"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 58,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Force Motors"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 59,
                    ID_Commercial_Vehicles_Category = 9,
                    ModelName = "Others"
                },
                new Commercial_Vehicles_Model_Type
                {
                    ID = 60,
                    ID_Commercial_Vehicles_Category = 10,
                    ModelName = "Others"
                },
            };

            _spare_Parts_Types = new List<Spare_Parts_Type>()
            {
                new Spare_Parts_Type
                {
                    ID = 1,
                    Spare_Parts_Type_ = "Wheels & Tyres"
                },
                new Spare_Parts_Type
                {
                    ID = 2,
                    Spare_Parts_Type_ = "Audio & Other Accessories"
                },
                new Spare_Parts_Type
                {
                    ID = 3,
                    Spare_Parts_Type_ = "Other Spare Parts"
                },
            };

        }
    }
}
