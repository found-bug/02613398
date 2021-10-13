using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AIO.ViewModels.ads
{
    class CarCategoryListViewModel
    {
        public CarCategoryListViewModel()
        {
            Car_BrandName_List = new List<CarBrand>
            {
                new CarBrand
                {
                    id = 1,
                    CategoryName = "Maruti Suzuki"
                },
                new CarBrand
                {
                      id = 2,
                    CategoryName = "Hyundai"
                },
                new CarBrand
                {
                   id = 3,
                    CategoryName = "Tata"
                },
                new CarBrand
                {
                   id = 4,
                    CategoryName = "Honda"
                },
                new CarBrand
                {
                   id = 5,
                    CategoryName = "Mahindra"
                },
                new CarBrand
                {
                   id = 6,
                    CategoryName = "Ford"
                },
                new CarBrand
                {
                   id = 7,
                    CategoryName = "Renault"
                },
                new CarBrand
                {
                   id = 8,
                    CategoryName = "Volkswagen"
                },
                new CarBrand
                {
                   id = 9,
                    CategoryName = "Skoda"
                },
                new CarBrand
                {
                   id = 10,
                    CategoryName = "Toyota"
                },
                new CarBrand
                {
                   id = 11,
                    CategoryName = "MG"
                },
                new CarBrand
                {
                   id = 12,
                    CategoryName = "KIA"
                },
                new CarBrand
                {
                   id = 13,
                    CategoryName = "Jeep"
                },
                new CarBrand
                {
                   id = 14,
                    CategoryName = "Nissan"
                },
                new CarBrand
                {
                   id = 15,
                    CategoryName = "Datsun"
                },
                new CarBrand
                {
                   id = 16,
                    CategoryName = "Hyundai"
                },
                new CarBrand
                {
                   id = 17,
                    CategoryName = "Mercedes"
                },
                new CarBrand
                {
                   id = 18,
                    CategoryName = "Mercedes"
                },
                new CarBrand
                {
                   id = 19,
                    CategoryName = "Audi"
                },
                new CarBrand
                {
                   id = 20,
                    CategoryName = "Tesla"
                }
            };


            Car_Variant_Name_List = new List<Car_Variant_Name>
            {
                new Car_Variant_Name
                {
                    id = 1,
                    CarBrand_id = 1,
                    CarVariantName = "Alto"
                },
                new Car_Variant_Name
                {
                    id = 2,
                    CarBrand_id = 1,
                    CarVariantName = "Baleno"
                },
                new Car_Variant_Name
                {
                    id = 3,
                    CarBrand_id = 1,
                    CarVariantName = "Celerio"
                },
                new Car_Variant_Name
                {
                    id = 4,
                    CarBrand_id = 1,
                    CarVariantName = "Ciaz"
                },
                new Car_Variant_Name
                {
                    id = 5,
                    CarBrand_id = 1,
                    CarVariantName = "Dzire"
                },
                new Car_Variant_Name
                {
                    id = 6,
                    CarBrand_id = 1,
                    CarVariantName = "Eeco"
                },
                new Car_Variant_Name
                {
                    id = 7,
                    CarBrand_id = 1,
                    CarVariantName = "Ertiga"
                },
                new Car_Variant_Name
                {
                    id = 8,
                    CarBrand_id = 1,
                    CarVariantName = "Ignis"
                },
                new Car_Variant_Name
                {
                    id = 9,
                    CarBrand_id = 1,
                    CarVariantName = "S-Cross"
                },
                new Car_Variant_Name
                {
                    id = 10,
                    CarBrand_id = 1,
                    CarVariantName = "S-Presso"
                },
                new Car_Variant_Name
                {
                    id = 11,
                    CarBrand_id = 1,
                    CarVariantName = "Vitara Brezza"
                },
                new Car_Variant_Name
                {
                    id = 12,
                    CarBrand_id = 1,
                    CarVariantName = "Swift"
                },
                new Car_Variant_Name
                {
                    id = 13,
                    CarBrand_id = 1,
                    CarVariantName = "Wagon-R"
                },
                new Car_Variant_Name
                {
                    id = 14,
                    CarBrand_id = 1,
                    CarVariantName = "XL6"
                },
                new Car_Variant_Name
                {
                    id = 15,
                    CarBrand_id = 1,
                    CarVariantName = "XL5"
                },
                new Car_Variant_Name
                {
                    id = 16,
                    CarBrand_id = 1,
                    CarVariantName = "Jimny (New Gypsy)"
                },
                new Car_Variant_Name
                {
                    id = 17,
                    CarBrand_id = 2,
                    CarVariantName = "Creta"
                },
                new Car_Variant_Name
                {
                    id = 18,
                    CarBrand_id = 2,
                    CarVariantName = "Elantra"
                },
                new Car_Variant_Name
                {
                    id = 19,
                    CarBrand_id = 2,
                    CarVariantName = "Santro"
                },
                new Car_Variant_Name
                {
                    id = 20,
                    CarBrand_id = 2,
                    CarVariantName = "Tucson"
                },
                new Car_Variant_Name
                {
                    id = 21,
                    CarBrand_id = 2,
                    CarVariantName = "Venue"
                },
                new Car_Variant_Name
                {
                    id = 22,
                    CarBrand_id = 2,
                    CarVariantName = "Verna"
                },
                new Car_Variant_Name
                {
                    id = 23,
                    CarBrand_id = 2,
                    CarVariantName = "Elite i20"
                },
                new Car_Variant_Name
                {
                    id = 24,
                    CarBrand_id = 2,
                    CarVariantName = "Grand i10"
                },
                new Car_Variant_Name
                {
                    id = 25,
                    CarBrand_id = 2,
                    CarVariantName = "Kona Electric"
                },
                new Car_Variant_Name
                {
                    id = 26,
                    CarBrand_id = 2,
                    CarVariantName = "Aura"
                },
                new Car_Variant_Name
                {
                    id = 27,
                    CarBrand_id = 3,
                    CarVariantName = "Nexon"
                },
                new Car_Variant_Name
                {
                    id = 28,
                    CarBrand_id = 3,
                    CarVariantName = "Tiago"
                },
                new Car_Variant_Name
                {
                    id = 29,
                    CarBrand_id = 3,
                    CarVariantName = "Harrier"
                },
                new Car_Variant_Name
                {
                    id = 30,
                    CarBrand_id = 3,
                    CarVariantName = "Altro"
                },
                new Car_Variant_Name
                {
                    id = 31,
                    CarBrand_id = 4,
                    CarVariantName = "City"
                },
                new Car_Variant_Name
                {
                    id = 32,
                    CarBrand_id = 4,
                    CarVariantName = "Amaze"
                },
                new Car_Variant_Name
                {
                    id = 33,
                    CarBrand_id = 4,
                    CarVariantName = "Civic"
                },
                new Car_Variant_Name
                {
                    id = 34,
                    CarBrand_id = 4,
                    CarVariantName = "Jazz"
                },
                new Car_Variant_Name
                {
                    id = 35,
                    CarBrand_id = 4,
                    CarVariantName = "WR-V"
                },
                new Car_Variant_Name
                {
                    id = 36,
                    CarBrand_id = 4,
                    CarVariantName = "CR-V"
                },
                new Car_Variant_Name
                {
                    id = 37,
                    CarBrand_id = 5,
                    CarVariantName = "Thar"
                },
                new Car_Variant_Name
                {
                    id = 38,
                    CarBrand_id = 5,
                    CarVariantName = "Scorpio"
                },
                new Car_Variant_Name
                {
                    id = 39,
                    CarBrand_id = 5,
                    CarVariantName = "XUV 300"
                },
                new Car_Variant_Name
                {
                    id = 40,
                    CarBrand_id = 5,
                    CarVariantName = "XUV 500"
                },
                new Car_Variant_Name
                {
                    id = 41,
                    CarBrand_id = 5,
                    CarVariantName = "Bolero"
                },
                new Car_Variant_Name
                {
                    id = 42,
                    CarBrand_id = 5,
                    CarVariantName = "Marazzo"
                },
                new Car_Variant_Name
                {
                    id = 43,
                    CarBrand_id = 5,
                    CarVariantName = "KUV 100 NXT"
                },
                new Car_Variant_Name
                {
                    id = 44,
                    CarBrand_id = 5,
                    CarVariantName = "Alturas G4"
                },
                new Car_Variant_Name
                {
                    id = 45,
                    CarBrand_id = 6,
                    CarVariantName = "Ecosport"
                },
                new Car_Variant_Name
                {
                    id = 46,
                    CarBrand_id = 6,
                    CarVariantName = "Endeavor"
                },
                new Car_Variant_Name
                {
                    id = 47,
                    CarBrand_id = 6,
                    CarVariantName = "Figo"
                },
                new Car_Variant_Name
                {
                    id = 48,
                    CarBrand_id = 6,
                    CarVariantName = "Freestyle"
                },
                new Car_Variant_Name
                {
                    id = 49,
                    CarBrand_id = 6,
                    CarVariantName = "Aspire"
                },
                new Car_Variant_Name
                {
                    id = 50,
                    CarBrand_id = 7,
                    CarVariantName = "Kwid"
                },
                new Car_Variant_Name
                {
                    id = 51,
                    CarBrand_id = 7,
                    CarVariantName = "Triber"
                },
                new Car_Variant_Name
                {
                    id = 52,
                    CarBrand_id = 7,
                    CarVariantName = "Duster"
                },
                new Car_Variant_Name
                {
                    id = 53,
                    CarBrand_id = 8,
                    CarVariantName = "Tiguan Allspace"
                },
                new Car_Variant_Name
                {
                    id = 54,
                    CarBrand_id = 8,
                    CarVariantName = "Passat"
                },
                new Car_Variant_Name
                {
                    id = 55,
                    CarBrand_id = 8,
                    CarVariantName = "Polo"
                },
                new Car_Variant_Name
                {
                    id = 56,
                    CarBrand_id = 8,
                    CarVariantName = "Vento"
                },
                new Car_Variant_Name
                {
                    id = 57,
                    CarBrand_id = 8,
                    CarVariantName = "T-Roc"
                },
                new Car_Variant_Name
                {
                    id = 58,
                    CarBrand_id = 9,
                    CarVariantName = "Rapid"
                },
                new Car_Variant_Name
                {
                    id = 59,
                    CarBrand_id = 9,
                    CarVariantName = "Superb"
                },
                new Car_Variant_Name
                {
                    id = 60,
                    CarBrand_id = 9,
                    CarVariantName = "Octavia"
                },
                new Car_Variant_Name
                {
                    id = 61,
                    CarBrand_id = 9,
                    CarVariantName = "Karoq"
                },
                new Car_Variant_Name
                {
                    id = 62,
                    CarBrand_id = 10,
                    CarVariantName = "Fortuner"
                },
                new Car_Variant_Name
                {
                    id = 63,
                    CarBrand_id = 10,
                    CarVariantName = "Innova Crysta"
                },
                new Car_Variant_Name
                {
                    id = 64,
                    CarBrand_id = 10,
                    CarVariantName = "Glanza"
                },
                new Car_Variant_Name
                {
                    id = 65,
                    CarBrand_id = 10,
                    CarVariantName = "Yaris"
                },
                new Car_Variant_Name
                {
                    id = 66,
                    CarBrand_id = 10,
                    CarVariantName = "Camry"
                },
                new Car_Variant_Name
                {
                    id = 67,
                    CarBrand_id = 10,
                    CarVariantName = "Urban Cruiser"
                },
                new Car_Variant_Name
                {
                    id = 68,
                    CarBrand_id = 10,
                    CarVariantName = "Vellfire"
                },
                new Car_Variant_Name
                {
                    id = 69,
                    CarBrand_id = 11,
                    CarVariantName = "Hector"
                },
                new Car_Variant_Name
                {
                    id = 70,
                    CarBrand_id = 11,
                    CarVariantName = "Hector Plus"
                },
                new Car_Variant_Name
                {
                    id = 71,
                    CarBrand_id = 11,
                    CarVariantName = "ZS EV"
                },
                new Car_Variant_Name
                {
                    id = 72,
                    CarBrand_id = 11,
                    CarVariantName = "Gloster"
                },
                new Car_Variant_Name
                {
                    id = 73,
                    CarBrand_id = 12,
                    CarVariantName = "Seltos"
                },
                new Car_Variant_Name
                {
                    id = 74,
                    CarBrand_id = 12,
                    CarVariantName = "Sonet"
                },
                new Car_Variant_Name
                {
                    id = 75,
                    CarBrand_id = 12,
                    CarVariantName = "Carnival"
                },
                new Car_Variant_Name
                {
                    id = 76,
                    CarBrand_id = 13,
                    CarVariantName = "Compass"
                },
                new Car_Variant_Name
                {
                    id = 77,
                    CarBrand_id = 13,
                    CarVariantName = "Wrangler"
                },
                new Car_Variant_Name
                {
                    id = 78,
                    CarBrand_id = 13,
                    CarVariantName = "ompass Trailhawk"
                },
                new Car_Variant_Name
                {
                    id = 79,
                    CarBrand_id = 14,
                    CarVariantName = "Magnite"
                },
                new Car_Variant_Name
                {
                    id = 80,
                    CarBrand_id = 14,
                    CarVariantName = "Kicks"
                },
                new Car_Variant_Name
                {
                    id = 81,
                    CarBrand_id = 14,
                    CarVariantName = "GT-R"
                },
                new Car_Variant_Name
                {
                    id = 82,
                    CarBrand_id = 15,
                    CarVariantName = "Redi-Go"
                },
                new Car_Variant_Name
                {
                    id = 83,
                    CarBrand_id = 15,
                    CarVariantName = "Go"
                },
                new Car_Variant_Name
                {
                    id = 84,
                    CarBrand_id = 15,
                    CarVariantName = "Go+"
                },
                new Car_Variant_Name
                {
                    id = 85,
                    CarBrand_id = 16,
                    CarVariantName = "i10"
                },
                new Car_Variant_Name
                {
                    id = 86,
                    CarBrand_id = 16,
                    CarVariantName = "i10 Nios"
                },
                new Car_Variant_Name
                {
                    id = 87,
                    CarBrand_id = 16,
                    CarVariantName = "Santro"
                },
                new Car_Variant_Name
                {
                    id = 88,
                    CarBrand_id = 16,
                    CarVariantName = "i20"
                },
                new Car_Variant_Name
                {
                    id = 89,
                    CarBrand_id = 16,
                    CarVariantName = "Aura"
                },
                new Car_Variant_Name
                {
                    id = 90,
                    CarBrand_id = 16,
                    CarVariantName = "Venue"
                },
                new Car_Variant_Name
                {
                    id = 91,
                    CarBrand_id = 16,
                    CarVariantName = "Verna"
                },
                new Car_Variant_Name
                {
                    id = 92,
                    CarBrand_id = 16,
                    CarVariantName = "Creta"
                },
                new Car_Variant_Name
                {
                    id = 93,
                    CarBrand_id = 16,
                    CarVariantName = "Tucson"
                },
                new Car_Variant_Name
                {
                    id = 94,
                    CarBrand_id = 16,
                    CarVariantName = "Elantra"
                },
                new Car_Variant_Name
                {
                    id = 95,
                    CarBrand_id = 16,
                    CarVariantName = "Kona Electric"
                },
                new Car_Variant_Name
                {
                    id = 96,
                    CarBrand_id = 16,
                    CarVariantName = "Nexo"
                },
                new Car_Variant_Name
                {
                    id = 97,
                    CarBrand_id = 17,
                    CarVariantName = "Benz C-Class"
                },
                new Car_Variant_Name
                {
                    id = 98,
                    CarBrand_id = 17,
                    CarVariantName = "Benz S-Class"
                },
                new Car_Variant_Name
                {
                    id = 99,
                    CarBrand_id = 17,
                    CarVariantName = "Benz E-Class"
                },
                new Car_Variant_Name
                {
                    id = 100,
                    CarBrand_id = 17,
                    CarVariantName = "Benz GLS"
                },
                new Car_Variant_Name
                {
                    id = 101,
                    CarBrand_id = 17,
                    CarVariantName = "Benz GLC"
                },
                new Car_Variant_Name
                {
                    id = 102,
                    CarBrand_id = 17,
                    CarVariantName = "Benz EQC"
                },
                new Car_Variant_Name
                {
                    id = 103,
                    CarBrand_id = 17,
                    CarVariantName = "Benz GLE"
                },
                new Car_Variant_Name
                {
                    id = 104,
                    CarBrand_id = 17,
                    CarVariantName = "Benz V-CLass"
                },
                new Car_Variant_Name
                {
                    id = 105,
                    CarBrand_id = 17,
                    CarVariantName = "Benz AMG GT"
                },
                new Car_Variant_Name
                {
                    id = 106,
                    CarBrand_id = 17,
                    CarVariantName = "Benz AMG GLE 53"
                },
                new Car_Variant_Name
                {
                    id = 107,
                    CarBrand_id = 17,
                    CarVariantName = "Benz AMG GT 4-door Coupe"
                },
                new Car_Variant_Name
                {
                    id = 108,
                    CarBrand_id = 17,
                    CarVariantName = "Benz CLS"
                },
                new Car_Variant_Name
                {
                    id = 109,
                    CarBrand_id = 17,
                    CarVariantName = "Benz E-Class All-Terrain"
                },
                new Car_Variant_Name
                {
                    id = 110,
                    CarBrand_id = 18,
                    CarVariantName = "X1"
                },
                new Car_Variant_Name
                {
                    id = 111,
                    CarBrand_id = 18,
                    CarVariantName = "X5"
                },
                new Car_Variant_Name
                {
                    id = 112,
                    CarBrand_id = 18,
                    CarVariantName = "3 Series"
                },
                new Car_Variant_Name
                {
                    id = 113,
                    CarBrand_id = 18,
                    CarVariantName = "X7"
                },
                new Car_Variant_Name
                {
                    id = 114,
                    CarBrand_id = 18,
                    CarVariantName = "X3"
                },
                new Car_Variant_Name
                {
                    id = 115,
                    CarBrand_id = 18,
                    CarVariantName = "2 Series"
                },
                new Car_Variant_Name
                {
                    id = 116,
                    CarBrand_id = 18,
                    CarVariantName = "5 Series"
                },
                new Car_Variant_Name
                {
                    id = 117,
                    CarBrand_id = 18,
                    CarVariantName = "X6"
                },
                new Car_Variant_Name
                {
                    id = 118,
                    CarBrand_id = 18,
                    CarVariantName = "Z4"
                },
                new Car_Variant_Name
                {
                    id = 119,
                    CarBrand_id = 18,
                    CarVariantName = "6 Series"
                },
                new Car_Variant_Name
                {
                    id = 120,
                    CarBrand_id = 18,
                    CarVariantName = "7 Series"
                },
                new Car_Variant_Name
                {
                    id = 121,
                    CarBrand_id = 18,
                    CarVariantName = "M5"
                },
                new Car_Variant_Name
                {
                    id = 122,
                    CarBrand_id = 18,
                    CarVariantName = "M2"
                },
                new Car_Variant_Name
                {
                    id = 123,
                    CarBrand_id = 18,
                    CarVariantName = "3 Series GT"
                },
                new Car_Variant_Name
                {
                    id = 124,
                    CarBrand_id = 19,
                    CarVariantName = "A6"
                },
                new Car_Variant_Name
                {
                    id = 125,
                    CarBrand_id = 19,
                    CarVariantName = "Q2"
                },
                new Car_Variant_Name
                {
                    id = 126,
                    CarBrand_id = 19,
                    CarVariantName = "Q8"
                },
                new Car_Variant_Name
                {
                    id = 127,
                    CarBrand_id = 19,
                    CarVariantName = "A8"
                },
                new Car_Variant_Name
                {
                    id = 128,
                    CarBrand_id = 19,
                    CarVariantName = "RS7"
                },
                new Car_Variant_Name
                {
                    id = 129,
                    CarBrand_id = 19,
                    CarVariantName = "RS Q8"
                },
                new Car_Variant_Name
                {
                    id = 130,
                    CarBrand_id = 20,
                    CarVariantName = "Model S"
                },
                new Car_Variant_Name
                {
                    id = 131,
                    CarBrand_id = 20,
                    CarVariantName = "Model 3"
                },
                new Car_Variant_Name
                {
                    id = 132,
                    CarBrand_id = 20,
                    CarVariantName = "Model X"
                },
                new Car_Variant_Name
                {
                    id = 133,
                    CarBrand_id = 20,
                    CarVariantName = "Model Y"
                }
            };


            Fuel_Type = new List<Fuel_Type>
            {
                new Fuel_Type
                {
                    id =1,
                    _fuel_type = "CNG & Hybrids"
                },
                new Fuel_Type
                {
                    id = 2,
                    _fuel_type = "Diesel"
                },
                new Fuel_Type
                {
                    id = 3,
                    _fuel_type = "Electric"
                },
                new Fuel_Type
                {
                    id = 4,
                    _fuel_type = "LPG"
                },
                new Fuel_Type
                {
                    id = 5,
                    _fuel_type = "Petrol"
                }
            };


            onwership_list = new List<onwership_type_>
            {
                new onwership_type_
                {
                    _onwer_ship_number = "1st onwer"
                },
                new onwership_type_
                {
                    _onwer_ship_number = "2nd onwer"
                },
                new onwership_type_
                {
                    _onwer_ship_number = "3rd onwer"
                },
                new onwership_type_
                {
                    _onwer_ship_number = "4th onwer"
                },
                new onwership_type_
                {
                    _onwer_ship_number = "4th+ onwer"
                }
            };


        }

        public List<CarBrand> Car_BrandName_List { get; }
        public List<Car_Variant_Name> Car_Variant_Name_List { get; }
        public List<Fuel_Type> Fuel_Type { get; set; } = new List<Fuel_Type>();
        public List<onwership_type_> onwership_list { get; set; } = new List<onwership_type_>();
      
    }
}
