using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class MobileCategoryListViewModel
    {
    }

    class mobile_brands
    {
        public List<Mobile_Model> mobile_Models_List = new List<Mobile_Model>();
        public List<Mobile_Model> Tab_Type_List = new List<Mobile_Model>();
        public List<Mobile_Model> Ad_Category_Type_List = new List<Mobile_Model>();

        public mobile_brands()
        {
            mobile_Models_List = new List<Mobile_Model>()
            {
                new Mobile_Model
                {
                    ID = 1,
                    phone_brand_name = "Asus"
                },
                new Mobile_Model
                {
                    ID = 2,
                    phone_brand_name = "BlackBerry"
                },
                new Mobile_Model
                {
                    ID = 3,
                    phone_brand_name = "Gionee"
                },
                new Mobile_Model
                {
                    ID = 4,
                    phone_brand_name = "Google Pixel"
                },
                new Mobile_Model
                {
                    ID = 5,
                    phone_brand_name = "Honor"
                },
                new Mobile_Model
                {
                    ID = 6,
                    phone_brand_name = "Huawei"
                },
                new Mobile_Model
                {
                    ID = 7,
                    phone_brand_name = "Infinix"
                },
                new Mobile_Model
                {
                    ID = 8,
                    phone_brand_name = "Intex"
                },
                new Mobile_Model
                {
                    ID = 9,
                    phone_brand_name = "iPhone"
                },
                new Mobile_Model
                {
                    ID = 10,
                    phone_brand_name = "Karbon"
                },
                new Mobile_Model
                {
                    ID = 11,
                    phone_brand_name = "Lava"
                },
                new Mobile_Model
                {
                    ID = 12,
                    phone_brand_name = "Lenovo"
                },
                new Mobile_Model
                {
                    ID = 13,
                    phone_brand_name = "LG"
                },
                new Mobile_Model
                {
                    ID = 14,
                    phone_brand_name = "Mi"
                },
                new Mobile_Model
                {
                    ID = 15,
                    phone_brand_name = "Micromax"
                },
                new Mobile_Model
                {
                    ID = 16,
                    phone_brand_name = "Motorola"
                },
                new Mobile_Model
                {
                    ID = 17,
                    phone_brand_name = "Nokia"
                },
                new Mobile_Model
                {
                    ID = 18,
                    phone_brand_name = "One Plus"
                },
                new Mobile_Model
                {
                    ID = 19,
                    phone_brand_name = "Oppo"
                },
                new Mobile_Model
                {
                    ID = 20,
                    phone_brand_name = "Realme"
                },
                new Mobile_Model
                {
                    ID = 21,
                    phone_brand_name = "Samsung"
                },
                new Mobile_Model
                {
                    ID = 22,
                    phone_brand_name = "Sony"
                },
                new Mobile_Model
                {
                    ID = 23,
                    phone_brand_name = "Techno"
                },
                new Mobile_Model
                {
                    ID = 24,
                    phone_brand_name = "Vivo"
                },
                new Mobile_Model
                {
                    ID = 25,
                    phone_brand_name = "Other Mobiles"
                }
            };


            Tab_Type_List = new List<Mobile_Model>()
            {
                new Mobile_Model
                {
                    ID = 1,
                    phone_brand_name = "iPads"
                },
                new Mobile_Model
                {
                    ID = 2,
                    phone_brand_name = "Samsung"
                },
                new Mobile_Model
                {
                    ID = 3,
                    phone_brand_name = "Other Tablets"
                },
            };

            Ad_Category_Type_List = new List<Mobile_Model>()
            {
                new Mobile_Model
                {
                    ID = 1,
                    phone_brand_name = "Mobile Phones"
                },
                new Mobile_Model
                {
                    ID = 2,
                    phone_brand_name = "Accessories"
                },
                new Mobile_Model
                {
                    ID = 3,
                    phone_brand_name = "Tablets"
                },
            };


        }
    }
}
