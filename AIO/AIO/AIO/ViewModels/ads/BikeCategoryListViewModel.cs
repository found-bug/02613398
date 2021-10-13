using AIO.Models.Ad_Post;
using System.Collections.Generic;

namespace AIO.ViewModels.ads
{
    class BikeCategoryListViewModel
    {
        public List<Bike_Category> _ad_post_type = new List<Bike_Category>();
        public List<Bike_Category> _bike_caategory = new List<Bike_Category>();
        public List<Bike_model> _bike_model = new List<Bike_model>();


        public List<Bike_Category> _scooter_scooty_category = new List<Bike_Category>();
        public List<Bike_model> _scooter_scooty_model = new List<Bike_model>();


        public List<Bike_Category> bicycle_category = new List<Bike_Category>();


        public BikeCategoryListViewModel()
        {


            _ad_post_type = new List<Bike_Category>()
            {
                new Bike_Category
                {
                    id = 1,
                    CategoryName = "Motorcycle"
                },
                new Bike_Category
                {
                    id = 2,
                    CategoryName = "Scooter & Scooty"
                },
                new Bike_Category
                {
                    id = 3,
                    CategoryName = "Spare Parts"
                },
                new Bike_Category
                {
                    id = 4,
                    CategoryName = "Bicycles"
                }
            };


            _bike_caategory = new List<Bike_Category>()
            {
                new Bike_Category
                {
                    id = 1,
                    CategoryName = "Bajaj"
                },
                new Bike_Category
                {
                    id = 2,
                    CategoryName = "Hero"
                },
                new Bike_Category
                {
                    id = 3,
                    CategoryName = "Hero Honda"
                },
                new Bike_Category
                {
                    id = 4,
                    CategoryName = "Honda"
                },
                new Bike_Category
                {
                    id = 5,
                    CategoryName = "KTM"
                },
                new Bike_Category
                {
                    id = 6,
                    CategoryName = "Royal Enfield"
                },
                new Bike_Category
                {
                    id = 7,
                    CategoryName = "Suzuki"
                },
                new Bike_Category
                {
                    id = 8,
                    CategoryName = "TVS"
                },
                new Bike_Category
                {
                    id = 9,
                    CategoryName = "Yamaha"
                },
                new Bike_Category
                {
                    id = 10,
                    CategoryName = "Other Brands"
                }
            };


            _bike_model = new List<Bike_model>()
            {
                new Bike_model
                {
                    id = 1,
                    Bike_Category_id = 1,
                    modelName = "Avenger"
                },
                new Bike_model
                {
                    id = 2,
                    Bike_Category_id = 1,
                    modelName = "CT 100"
                },
                new Bike_model
                {
                    id = 3,
                    Bike_Category_id = 1,
                    modelName = "Discover"
                },
                new Bike_model
                {
                    id = 4,
                    Bike_Category_id = 1,
                    modelName = "Platina"
                },
                new Bike_model
                {
                    id = 5,
                    Bike_Category_id = 1,
                    modelName = "Pulsar"
                },
                new Bike_model
                {
                    id = 6,
                    Bike_Category_id = 1,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 7,
                    Bike_Category_id = 2,
                    modelName = "Achiver"
                },
                new Bike_model
                {
                    id = 8,
                    Bike_Category_id = 2,
                    modelName = "Ambition"
                },
                new Bike_model
                {
                    id = 9,
                    Bike_Category_id = 2,
                    modelName = "CBZ"
                },
                new Bike_model
                {
                    id = 10,
                    Bike_Category_id = 2,
                    modelName = "CD 100"
                },
                new Bike_model
                {
                    id = 11,
                    Bike_Category_id = 2,
                    modelName = "CD Dawn"
                },
                new Bike_model
                {
                    id = 12,
                    Bike_Category_id = 2,
                    modelName = "CD Deluxe"
                },
                new Bike_model
                {
                    id = 13,
                    Bike_Category_id = 2,
                    modelName = "Dawn"
                },
                new Bike_model
                {
                    id = 14,
                    Bike_Category_id = 2,
                    modelName = "Deluxe"
                },
                new Bike_model
                {
                    id = 15,
                    Bike_Category_id = 2,
                    modelName = "Glamour"
                },
                new Bike_model
                {
                    id = 16,
                    Bike_Category_id = 2,
                    modelName = "Hunk"
                },
                new Bike_model
                {
                    id = 17,
                    Bike_Category_id = 2,
                    modelName = "HX 250 R"
                },
                new Bike_model
                {
                    id = 18,
                    Bike_Category_id = 2,
                    modelName = "Ignitor"
                },
                new Bike_model
                {
                    id = 19,
                    Bike_Category_id = 2,
                    modelName = "Impulse"
                },
                new Bike_model
                {
                    id = 20,
                    Bike_Category_id = 2,
                    modelName = "Joy"
                },
                new Bike_model
                {
                    id = 21,
                    Bike_Category_id = 2,
                    modelName = "Karizma"
                },
                new Bike_model
                {
                    id = 22,
                    Bike_Category_id = 2,
                    modelName = "Passion"
                },
                new Bike_model
                {
                    id = 23,
                    Bike_Category_id = 2,
                    modelName = "Sleek"
                },
                new Bike_model
                {
                    id = 24,
                    Bike_Category_id = 2,
                    modelName = "Splendor"
                },
                new Bike_model
                {
                    id = 25,
                    Bike_Category_id = 2,
                    modelName = "Street"
                },
                new Bike_model
                {
                    id = 26,
                    Bike_Category_id = 2,
                    modelName = "Super Splendor"
                },
                new Bike_model
                {
                    id = 27,
                    Bike_Category_id = 2,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 28,
                    Bike_Category_id = 3,
                    modelName = "Achiver"
                },
                new Bike_model
                {
                    id = 29,
                    Bike_Category_id = 3,
                    modelName = "Ambition"
                },
                new Bike_model
                {
                    id = 30,
                    Bike_Category_id = 3,
                    modelName = "CBZ"
                },
                new Bike_model
                {
                    id = 31,
                    Bike_Category_id = 3,
                    modelName = "CD 100"
                },
                new Bike_model
                {
                    id = 32,
                    Bike_Category_id = 3,
                    modelName = "CD Dawn"
                },
                new Bike_model
                {
                    id = 33,
                    Bike_Category_id = 3,
                    modelName = "CD Deluxe"
                },
                new Bike_model
                {
                    id = 34,
                    Bike_Category_id = 3,
                    modelName = "Dawn"
                },
                new Bike_model
                {
                    id = 35,
                    Bike_Category_id = 3,
                    modelName = "Deluxe"
                },
                new Bike_model
                {
                    id = 36,
                    Bike_Category_id = 3,
                    modelName = "Glamour"
                },
                new Bike_model
                {
                    id = 37,
                    Bike_Category_id = 3,
                    modelName = "Hunk"
                },
                new Bike_model
                {
                    id = 38,
                    Bike_Category_id = 3,
                    modelName = "HX 250 R"
                },
                new Bike_model
                {
                    id = 39,
                    Bike_Category_id = 3,
                    modelName = "Ignitor"
                },
                new Bike_model
                {
                    id = 40,
                    Bike_Category_id = 3,
                    modelName = "Impulse"
                },
                new Bike_model
                {
                    id = 41,
                    Bike_Category_id = 3,
                    modelName = "Joy"
                },
                new Bike_model
                {
                    id = 42,
                    Bike_Category_id = 3,
                    modelName = "Karizma"
                },
                new Bike_model
                {
                    id = 43,
                    Bike_Category_id = 3,
                    modelName = "Passion"
                },
                new Bike_model
                {
                    id = 44,
                    Bike_Category_id = 3,
                    modelName = "Sleek"
                },
                new Bike_model
                {
                    id = 45,
                    Bike_Category_id = 3,
                    modelName = "Splendor"
                },
                new Bike_model
                {
                    id = 46,
                    Bike_Category_id = 3,
                    modelName = "Street"
                },
                new Bike_model
                {
                    id = 47,
                    Bike_Category_id = 3,
                    modelName = "Super Splendor"
                },
                new Bike_model
                {
                    id = 48,
                    Bike_Category_id = 3,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 49,
                    Bike_Category_id = 4,
                    modelName = "CB"
                },
                new Bike_model
                {
                    id = 50,
                    Bike_Category_id = 4,
                    modelName = "CBF Stunner"
                },
                new Bike_model
                {
                    id = 51,
                    Bike_Category_id = 4,
                    modelName = "CBR"
                },
                new Bike_model
                {
                    id = 52,
                    Bike_Category_id = 4,
                    modelName = "CD 110 Dream"
                },
                new Bike_model
                {
                    id = 53,
                    Bike_Category_id = 4,
                    modelName = "Dream Yuga"
                },
                new Bike_model
                {
                    id = 54,
                    Bike_Category_id = 4,
                    modelName = "Goldwing GL 1800"
                },
                new Bike_model
                {
                    id = 55,
                    Bike_Category_id = 4,
                    modelName = "VFR 1200 F"
                },
                new Bike_model
                {
                    id = 56,
                    Bike_Category_id = 4,
                    modelName = "VT 1300 CX"
                },
                new Bike_model
                {
                    id = 57,
                    Bike_Category_id = 4,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 58,
                    Bike_Category_id = 5,
                    modelName = "390 DUke ABS"
                },
                new Bike_model
                {
                    id = 59,
                    Bike_Category_id = 5,
                    modelName = "Duke 200"
                },
                new Bike_model
                {
                    id = 60,
                    Bike_Category_id = 5,
                    modelName = "RC"
                },
                new Bike_model
                {
                    id = 61,
                    Bike_Category_id = 5,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 62,
                    Bike_Category_id = 6,
                    modelName = "Bullet"
                },
                new Bike_model
                {
                    id = 63,
                    Bike_Category_id = 6,
                    modelName = "Classic"
                },
                new Bike_model
                {
                    id = 64,
                    Bike_Category_id = 6,
                    modelName = "Continental GT"
                },
                new Bike_model
                {
                    id = 65,
                    Bike_Category_id = 6,
                    modelName = "Thunderbird"
                },
                new Bike_model
                {
                    id = 66,
                    Bike_Category_id = 6,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 67,
                    Bike_Category_id = 7,
                    modelName = "Bandit"
                },
                new Bike_model
                {
                    id = 67,
                    Bike_Category_id = 7,
                    modelName = "Gixxer"
                },
                new Bike_model
                {
                    id = 68,
                    Bike_Category_id = 7,
                    modelName = "GS"
                },
                new Bike_model
                {
                    id = 69,
                    Bike_Category_id = 7,
                    modelName = "GSX"
                },
                new Bike_model
                {
                    id = 70,
                    Bike_Category_id = 7,
                    modelName = "Hayabusa"
                },
                new Bike_model
                {
                    id = 71,
                    Bike_Category_id = 7,
                    modelName = "Hayate"
                },
                new Bike_model
                {
                    id = 72,
                    Bike_Category_id = 7,
                    modelName = "Inazuma"
                },
                new Bike_model
                {
                    id = 73,
                    Bike_Category_id = 7,
                    modelName = "M1800 R"
                },
                new Bike_model
                {
                    id = 74,
                    Bike_Category_id = 7,
                    modelName = "M800"
                },
                new Bike_model
                {
                    id = 75,
                    Bike_Category_id = 7,
                    modelName = "Slingshot"
                },
                new Bike_model
                {
                    id = 76,
                    Bike_Category_id = 7,
                    modelName = "V Strom"
                },
                new Bike_model
                {
                    id = 77,
                    Bike_Category_id = 7,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 78,
                    Bike_Category_id = 8,
                    modelName = "Apache RTR"
                },
                new Bike_model
                {
                    id = 79,
                    Bike_Category_id = 8,
                    modelName = "Heavy Duty Super XL"
                },
                new Bike_model
                {
                    id = 80,
                    Bike_Category_id = 8,
                    modelName = "Phoenix"
                },
                new Bike_model
                {
                    id = 81,
                    Bike_Category_id = 8,
                    modelName = "Star City Plus"
                },
                new Bike_model
                {
                    id = 82,
                    Bike_Category_id = 8,
                    modelName = "Star Sport"
                },
                new Bike_model
                {
                    id = 83,
                    Bike_Category_id = 8,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 84,
                    Bike_Category_id = 9,
                    modelName = "Crux"
                },
                new Bike_model
                {
                    id = 85,
                    Bike_Category_id = 9,
                    modelName = "Fazer"
                },
                new Bike_model
                {
                    id = 86,
                    Bike_Category_id = 9,
                    modelName = "FZ"
                },
                new Bike_model
                {
                    id = 87,
                    Bike_Category_id = 9,
                    modelName = "FZS"
                },
                new Bike_model
                {
                    id = 88,
                    Bike_Category_id = 9,
                    modelName = "Saluto"
                },
                new Bike_model
                {
                    id = 89,
                    Bike_Category_id = 9,
                    modelName = "SS 125"
                },
                new Bike_model
                {
                    id = 90,
                    Bike_Category_id = 9,
                    modelName = "SZ"
                },
                new Bike_model
                {
                    id = 91,
                    Bike_Category_id = 9,
                    modelName = "Vmax"
                },
                new Bike_model
                {
                    id = 92,
                    Bike_Category_id = 9,
                    modelName = "YBR"
                },
                new Bike_model
                {
                    id = 93,
                    Bike_Category_id = 9,
                    modelName = "YZF R"
                },
                new Bike_model
                {
                    id = 94,
                    Bike_Category_id = 9,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 95,
                    Bike_Category_id = 10,
                    modelName = "Others"
                },
            };


            _scooter_scooty_category = new List<Bike_Category>()
            {
                new Bike_Category
                {
                    id = 1,
                    CategoryName = "Bajaj"
                },
                new Bike_Category
                {
                    id = 2,
                    CategoryName = "Hero"
                },
                new Bike_Category
                {
                    id = 3,
                    CategoryName = "Honda"
                },
                new Bike_Category
                {
                    id = 4,
                    CategoryName = "Mahindra"
                },
                new Bike_Category
                {
                    id = 5,
                    CategoryName = "Suzuki"
                },
                new Bike_Category
                {
                    id = 6,
                    CategoryName = "TVS"
                },
                new Bike_Category
                {
                    id = 7,
                    CategoryName = "Other Brands"
                }
            };


            _scooter_scooty_model = new List<Bike_model>()
            {
                new Bike_model
                {
                    id = 1,
                    Bike_Category_id = 1,
                    modelName = "Chetak"
                },
                new Bike_model
                {
                    id = 2,
                    Bike_Category_id = 1,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 3,
                    Bike_Category_id = 2,
                    modelName = "Maestro"
                },
                new Bike_model
                {
                    id = 4,
                    Bike_Category_id = 2,
                    modelName = "Pleasure"
                },
                new Bike_model
                {
                    id = 5,
                    Bike_Category_id = 2,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 6,
                    Bike_Category_id = 3,
                    modelName = "Activa"
                },
                new Bike_model
                {
                    id = 7,
                    Bike_Category_id = 3,
                    modelName = "Avaitor"
                },
                new Bike_model
                {
                    id = 8,
                    Bike_Category_id = 3,
                    modelName = "Dio"
                },
                new Bike_model
                {
                    id = 9,
                    Bike_Category_id = 3,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 10,
                    Bike_Category_id = 4,
                    modelName = "Duro"
                },
                new Bike_model
                {
                    id = 11,
                    Bike_Category_id = 4,
                    modelName = "Gusto"
                },
                new Bike_model
                {
                    id = 12,
                    Bike_Category_id = 4,
                    modelName = "Kine"
                },
                new Bike_model
                {
                    id = 13,
                    Bike_Category_id = 4,
                    modelName = "Rodeo"
                },
                new Bike_model
                {
                    id = 14,
                    Bike_Category_id = 4,
                    modelName = "Sym Flyte"
                },
                new Bike_model
                {
                    id = 15,
                    Bike_Category_id = 4,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 16,
                    Bike_Category_id = 5,
                    modelName = "Access"
                },
                new Bike_model
                {
                    id = 17,
                    Bike_Category_id = 5,
                    modelName = "Let's"
                },
                new Bike_model
                {
                    id = 18,
                    Bike_Category_id = 5,
                    modelName = "Swish"
                },
                new Bike_model
                {
                    id = 19,
                    Bike_Category_id = 5,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 20,
                    Bike_Category_id = 6,
                    modelName = "Jupiter"
                },
                new Bike_model
                {
                    id = 21,
                    Bike_Category_id = 6,
                    modelName = "Scooty"
                },
                new Bike_model
                {
                    id = 22,
                    Bike_Category_id = 6,
                    modelName = "Wego"
                },
                new Bike_model
                {
                    id = 23,
                    Bike_Category_id = 6,
                    modelName = "Others"
                },
                new Bike_model
                {
                    id = 24,
                    Bike_Category_id = 7,
                    modelName = "Others"
                }
            };



            bicycle_category = new List<Bike_Category>()
            {
                new Bike_Category
                {
                    id = 1,
                    CategoryName = "Hercules"
                },
                new Bike_Category
                {
                    id = 2,
                    CategoryName = "Hero"
                },
                new Bike_Category
                {
                    id = 3,
                    CategoryName = "Other Brands"
                }
            };


        }

    }
}
