using AIO.Models;
using AIO.Models.Location;
using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace AIO.Helper
{
    public static class Settings
    {
        public static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string Username
        {
            get
            {
                return AppSettings.GetValueOrDefault("Username", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Username", value);
            }
        }


        public static string Password
        {
            get
            {
                return AppSettings.GetValueOrDefault("Password", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Password", value);
            }
        }


        public static string AccessToken
        {
            get
            {
                return AppSettings.GetValueOrDefault("AccessToken", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("AccessToken", value);
            }
        }


        public static string CurrentUserName
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserName", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserName", value);
            }
        }

        public static string CurrentUserPoints
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserPoints", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserPoints", value);
            }
        }


        public static string CurrentUserPhoneNumber
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserPhoneNumber", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserPhoneNumber", value);
            }
        }

        public static string geolocation_Latitude
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserLatitude", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserLatitude", value);
            }
        }
        
        
        public static string geolocation_Area_City_Name
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUser_Area_City_State_Name", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserLatitude", value);
            }
        }
        

        public static string geolocation_Longitude
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserLongitude", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserLongitude", value);
            }
        }
        
        

        public static string _click_for_open_location
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserCurrentLocationOnOrNot", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserCurrentLocationOnOrNot", value);
            }
        }

        

        public static string _location_already_selected_through_map
        {
            get
            {
                return AppSettings.GetValueOrDefault("CurrentUserMAPLocationOnOrNot", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUserMAPLocationOnOrNot", value);
            }
        }


        private const string myProductListKey = "myproductlist_key";
        public static List<ProductModel> myProductList
        {
            get
            {
                string value = AppSettings.GetValueOrDefault(myProductListKey, string.Empty);
                List<ProductModel> myList;
                if (string.IsNullOrEmpty(value))
                    myList = new List<ProductModel>();
                else
                    myList = JsonConvert.DeserializeObject<List<ProductModel>>(value);
                return myList;
            }
            set
            {
                var listValue = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(myProductListKey, listValue);
            }
        }

        private const string myLocationListKey = "mylocationList_kKey";
        public static List<_location_list> myLocationList
        {
            get
            {
                string value = AppSettings.GetValueOrDefault(myLocationListKey, string.Empty);
                List<_location_list> myList;
                if (string.IsNullOrEmpty(value))
                    myList = new List<_location_list>();
                else
                    myList = JsonConvert.DeserializeObject<List<_location_list>>(value);
                return myList;
            }
            set
            {
                var listValue = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(myLocationListKey, listValue);
            }
        }
    }
}
