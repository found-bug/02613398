using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class PropertyCategoryListViewModel
    {
        public List<Property_Category_Model> onwership_list { get; set; } = new List<Property_Category_Model>();
        public List<Property_Type_Model> property_type_list { get; set; } = new List<Property_Type_Model>();
        public List<bedroom_Model> bedroom_list { get; set; } = new List<bedroom_Model>();
        public List<furnishing_Model> furnishing_list { get; set; } = new List<furnishing_Model>();
        public List<construction_status_Model> construction_status_list { get; set; } = new List<construction_status_Model>();
        public List<construction_status_Model> listed_by_list { get; set; } = new List<construction_status_Model>();
        public List<bedroom_Model> car_parking_list { get; set; } = new List<bedroom_Model>();
        public List<bedroom_Model> facing_list { get; set; } = new List<bedroom_Model>();
        public List<bedroom_Model> pg_and_guest_house_sub_type_list { get; set; } = new List<bedroom_Model>();

        public PropertyCategoryListViewModel()
        {
            onwership_list = new List<Property_Category_Model>()
            {
                new Property_Category_Model
                {
                    ID = 1,
                    Property_Category = "House & Appartment"
                },
                new Property_Category_Model
                {
                    ID = 2,
                    Property_Category = "Lands & Plots"
                },
                new Property_Category_Model
                {
                    ID = 3,
                    Property_Category = "Shops & Offices"
                },
                new Property_Category_Model
                {
                    ID = 4,
                    Property_Category = "Guesthouse & PG"
                }
            };

            property_type_list = new List<Property_Type_Model>()
            {
                new Property_Type_Model
                {
                    Property_Type = "Appartment"
                },
                new Property_Type_Model
                {
                    Property_Type = "Builder Floors"
                },
                new Property_Type_Model
                {
                    Property_Type = "Farm House"
                },
                new Property_Type_Model
                {
                    Property_Type = "House & Villa"
                },
                 
            };

            bedroom_list = new List<bedroom_Model>()
            {
                new bedroom_Model
                {
                    bedroom_count = "1"
                },
                new bedroom_Model
                {
                    bedroom_count = "2"
                },
                new bedroom_Model
                {
                    bedroom_count = "3"
                },
                new bedroom_Model
                {
                    bedroom_count = "4"
                },
                new bedroom_Model
                {
                    bedroom_count = "4+"
                },
                 
            };

            furnishing_list = new List<furnishing_Model>()
            {
                new furnishing_Model
                {
                    furnishing_type = "Furnished"
                },
                new furnishing_Model
                {
                    furnishing_type = "Semi-Furnished"
                },
                new furnishing_Model
                {
                    furnishing_type = "Unfurnished"
                }                 
            };

            construction_status_list = new List<construction_status_Model>()
            {
                new construction_status_Model
                {
                    construction_type = "New Launch"
                },
                new construction_status_Model
                {
                    construction_type = "Ready to Move"
                },
                new construction_status_Model
                {
                    construction_type = "Under Construction"
                },
                new construction_status_Model
                {
                    construction_type = "5+ yrs old construction"
                }
            };

            listed_by_list = new List<construction_status_Model>()
            {
                new construction_status_Model
                {
                    construction_type = "Builder"
                },
                new construction_status_Model
                {
                    construction_type = "Dealer"
                },
                new construction_status_Model
                {
                    construction_type = "Onwer"
                }
            };

            car_parking_list = new List<bedroom_Model>()
            {
                new bedroom_Model
                {
                    bedroom_count = "0"
                },
                new bedroom_Model
                {
                    bedroom_count = "1"
                },
                new bedroom_Model
                {
                    bedroom_count = "2"
                },
                new bedroom_Model
                {
                    bedroom_count = "3"
                },
                new bedroom_Model
                {
                    bedroom_count = "3+"
                }
            };

            facing_list = new List<bedroom_Model>()
            {
                new bedroom_Model
                {
                    bedroom_count = "East"
                },
                new bedroom_Model
                {
                    bedroom_count = "North"
                },
                new bedroom_Model
                {
                    bedroom_count = "North-East"
                },
                new bedroom_Model
                {
                    bedroom_count = "North-West"
                },
                new bedroom_Model
                {
                    bedroom_count = "South"
                },
                new bedroom_Model
                {
                    bedroom_count = "South-East"
                },
                new bedroom_Model
                {
                    bedroom_count = "South-West"
                },
                new bedroom_Model
                {
                    bedroom_count = "West"
                }
            };


            pg_and_guest_house_sub_type_list = new List<bedroom_Model>()
            {
                new bedroom_Model
                {
                    bedroom_count = "Guest House"
                },
                new bedroom_Model
                {
                    bedroom_count = "PG"
                },
                new bedroom_Model
                {
                    bedroom_count = "Roommate"
                }
            };



        }


    }
}
