using AIO.Helper;
using AIO.Models.Account;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AIO.Models;
using AIO.ViewModels.User;
using AIO.ViewModels;
using AIO.ViewModels.Account;
using System.Linq;
using AIO.Models.Ad_Post;

namespace AIO.Services.Api
{
    public class ApiServices
    {

        //public async Task<List<string>> RegisterAsync(
        //  string email_phoneNumber, string password, string customerName)
        //{

        //    Settings.AccessToken = "";
        //    Settings.Username = "";
        //    Settings.Password = "";
        //    List<string> listResponse = new List<string>();

        //    var client = new HttpClient();


        //    var model = new RegisterBindingModel
        //    {
        //        CustomerName = customerName,
        //        Password = password,
        //        email_phoneNumber = email_phoneNumber
        //    };

        //    var json = JsonConvert.SerializeObject(model);

        //    HttpContent content = new StringContent(json);

        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var response = await client.PostAsync("http://bakers.halkut.in/api/Account/Register", content);
        //    //var response = await client.PostAsync("http://192.168.43.84:45459/api/Account/Register", content);
        //    if (response.IsSuccessStatusCode)
        //    {

        //        //var responseReq = await response.Content.ReadAsStringAsync();
        //        listResponse.Add("Success");
        //        Settings.Username = email_phoneNumber;
        //        Settings.Password = password;
        //        return listResponse;
        //    }
        //    else
        //    {
        //        //var responseReq = await response.Content.ReadAsStringAsync();
        //        listResponse.Add("This Email ID has already registered with us.");
        //        return listResponse;
        //    } 
        //}


        //public async Task<string> LoginAsync(string userName, string password)
        //{
        //    //string URL = "http://172.17.245.177:45459/token";
        //    string URL = "http://bakers.halkut.in/token";

        //    var accesstoken = string.Empty;
        //    await Task.Run(() =>
        //    {
        //        try
        //        {
        //            var keyValue = new List<KeyValuePair<string, string>>
        //            {
        //                new KeyValuePair<string, string>("userName",userName),
        //                new KeyValuePair<string, string>("password",password),
        //                new KeyValuePair<string, string>("grant_type","password")
        //            };
        //            var request = new HttpRequestMessage(HttpMethod.Post, URL);
        //            request.Content = new FormUrlEncodedContent(keyValue);

        //            var client = new HttpClient();
        //            var response = client.SendAsync(request).Result;
        //            using (HttpContent content = response.Content)
        //            {
        //                var json = content.ReadAsStringAsync();
        //                JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(json.Result);
        //                var accessTokenExpiration = jwtDynamic.Value<DateTime>(".expires");
        //                accesstoken = jwtDynamic.Value<string>("access_token");
        //                var UserName = jwtDynamic.Value<string>("userName");
        //                var AccesstokenExpirationDate = accessTokenExpiration;

        //                if (accesstoken != "")
        //                {
        //                    Settings.Username = userName;
        //                    //Settings.Password = password;
        //                    //if (Settings.Username == "")
        //                    //{
        //                    //    Settings.Username = userName;
        //                    //    Settings.Password = password;
        //                    //}

        //                    getCurrentUserData(userName);
        //                    Settings.AccessToken = accesstoken;
        //                }

        //            }

        //        }
        //        catch (Exception e1)
        //        {

        //            /// throw;
        //        }
        //    });
        //    return accesstoken;
        //}

        //private async void getCurrentUserData(string userName)
        //{
        //    await userPoints();

        //    await CurrentUserphoneNumber(userName);
        //}

        //public async Task<List<ProductModel>> GetProducts()
        //{
        //    var client = new HttpClient(); 

        //    List<ProductModel> list = new List<ProductModel>();
        //    var result = await client.GetAsync("http://bakers.halkut.in/api/Account/getProducts");

        //    if (result.IsSuccessStatusCode)
        //    {
        //        var responseReq = await result.Content.ReadAsStringAsync();
        //        Settings.myProductList = JsonConvert.DeserializeObject<List<ProductModel>>(responseReq);
        //    }
        //    //Your code here
        //    return Settings.myProductList;
        //}


        //public async Task<List<ProductModel>> getNewArrivialProducts()
        //{
        //    var client = new HttpClient();

        //    List<ProductModel> list = new List<ProductModel>();
        //    var result = await client.GetAsync("http://bakers.halkut.in/api/Account/getNewArrivialProducts");

        //    if (result.IsSuccessStatusCode)
        //    {
        //        var responseReq = await result.Content.ReadAsStringAsync();
        //        list = JsonConvert.DeserializeObject<List<ProductModel>>(responseReq);
        //    }
        //    //Your code here
        //    return list; ;
        //}


        //public async Task<List<ProductModel>> getTodaysSpecialProducts()
        //{
        //    var client = new HttpClient();

        //    List<ProductModel> list = new List<ProductModel>();
        //    var result = await client.GetAsync("http://bakers.halkut.in/api/Account/getTodaysSpecialProducts");
        //    if (result.IsSuccessStatusCode)
        //    {
        //        var responseReq = await result.Content.ReadAsStringAsync();
        //        list = JsonConvert.DeserializeObject<List<ProductModel>>(responseReq);
        //    }
        //    //Your code here
        //    return list; 
        //}


        //public async Task<ProductTable> GetSingleProduct(string _productCode)
        //{
        //    ProductTable list = new ProductTable();
        //    var client = new HttpClient();
        //    var _accessToken = Settings.AccessToken;

        //    var model = new ProductBindingModel
        //    {
        //        ProductCode = _productCode
        //    };

        //    var json = JsonConvert.SerializeObject(model);

        //    HttpContent content = new StringContent(json);

        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

        //    //var response = await client.PostAsync("http://192.168.42.8:45473/api/Account/singleproduct", content);
        //    var response = await client.PostAsync("http://bakers.halkut.in/api/Account/singleproduct", content);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseReq = await response.Content.ReadAsStringAsync();
        //        list = JsonConvert.DeserializeObject<ProductTable>(responseReq);
        //        return list;
        //    }
        //    return list;
        //}


        //public async Task<string> userPoints()
        //{

        //    var client = new HttpClient();
        //    var _accessToken = Settings.AccessToken;
        //    var _UserName = Settings.Username;
        //    string Items = string.Empty;

        //    var model = new GetUserPointsBindingModel
        //    {
        //        UserName = _UserName 
        //    };

        //    var json = JsonConvert.SerializeObject(model);

        //    HttpContent content = new StringContent(json);

        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);


        //    var response = await client.PostAsync("http://bakers.halkut.in/api/Account/userPointsr", content);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        string responseReq = await response.Content.ReadAsStringAsync();
        //        Settings.CurrentUserPoints = JsonConvert.DeserializeObject<string>(responseReq);
        //    }
        //    return Settings.CurrentUserPoints;
        //}

        //public async Task<string> CurrentUserDetails(string _userName)
        //{
        //    string list = string.Empty;
        //    var client = new HttpClient();
        //    var _accessToken = Settings.AccessToken;

        //    var model = new currentuserdetailsBindingModel
        //    {
        //        Phone_Email = _userName
        //    };

        //    var json = JsonConvert.SerializeObject(model);

        //    HttpContent content = new StringContent(json);

        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

        //    //var response = await client.PostAsync("http://192.168.42.8:45473/api/Account/currentusername", content);
        //    var response = await client.PostAsync("http://bakers.halkut.in/api/Account/currentusername", content);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseReq = await response.Content.ReadAsStringAsync();
        //        Settings.CurrentUserName = JsonConvert.DeserializeObject<string>(responseReq);
        //        return list;
        //    }
        //    return Settings.CurrentUserName;
        //}


        //public async Task<string> CurrentUserphoneNumber(string _userName)
        //{
        //    string list = string.Empty;
        //    var client = new HttpClient();
        //    var _accessToken = Settings.AccessToken;

        //    var model = new currentuserdetailsBindingModel
        //    {
        //        Phone_Email = _userName
        //    };

        //    var json = JsonConvert.SerializeObject(model);

        //    HttpContent content = new StringContent(json);

        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

        //    //var response = await client.PostAsync("http://192.168.42.8:45473/api/Account/currentuser/phonenumber", content);
        //    var response = await client.PostAsync("http://bakers.halkut.in/api/Account/currentuser/phonenumber", content);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseReq = await response.Content.ReadAsStringAsync();
        //        Settings.CurrentUserPhoneNumber = JsonConvert.DeserializeObject<string>(responseReq);
        //        return list;
        //    }
        //    return Settings.CurrentUserPhoneNumber;
        //}


        ////public async Task<string> CurrentUserPoints(string _userName)
        ////{
        ////    string list = string.Empty;
        ////    var client = new HttpClient();
        ////    var _accessToken = Settings.AccessToken;

        ////    var model = new GetUserPointsBindingModel
        ////    {
        ////        UserName = _userName
        ////    };

        ////    var json = JsonConvert.SerializeObject(model);

        ////    HttpContent content = new StringContent(json);

        ////    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        ////    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

        ////    //var response = await client.PostAsync("http://192.168.42.8:45473/api/Account/userPoints", content);
        ////    var response = await client.PostAsync("http://bakers.halkut.in/api/Account/userPoints", content);

        ////    if (response.IsSuccessStatusCode)
        ////    {
        ////        var responseReq = await response.Content.ReadAsStringAsync();
        ////        list = JsonConvert.DeserializeObject<string>(responseReq);
        ////        return list;
        ////    }
        ////    return list;
        ////}


        //public async Task<List<ProductModel>> ChangeHomeCategory_Four_Icons()
        //{

        //    var client = new HttpClient();

        //    List<ProductModel> list = new List<ProductModel>();
        //    var result = await client.GetAsync("http://bakers.halkut.in/api/Account/getTodaysSpecialProducts");
        //    if (result.IsSuccessStatusCode)
        //    {
        //        var responseReq = await result.Content.ReadAsStringAsync();
        //        list = JsonConvert.DeserializeObject<List<ProductModel>>(responseReq);
        //    }
        //    //Your code here
        //    return list; 
        //}




        //public async Task<string> SendOtp(
        //   string emailID_PhoneNumber)
        //{
        //    var otp = string.Empty;
        //    var client = new HttpClient();
        //    ForgotPasswordBindingModel mol = new ForgotPasswordBindingModel
        //    {
        //        UserName = emailID_PhoneNumber
        //    };
        //    var _json = JsonConvert.SerializeObject(mol);
        //    string str = JToken.Parse(_json).ToString(); // Now You will get the Normal String with "NO SLASHES" 
        //    HttpContent contentPost = new StringContent(str, Encoding.UTF8, "application/json");
        //    var result = await client.PostAsync("http://bakers.halkut.in/api/Account/password/forgot/user/emp/100333", contentPost);

        //    if (result.IsSuccessStatusCode)
        //    {
        //        var responseReq = await result.Content.ReadAsStringAsync();
        //        otp = JsonConvert.DeserializeObject<string>(responseReq);
        //    }

        //    return otp.ToString();

        //}



        //Currently this is for car category only
        public async Task<string> changepassword(Car_Bike_Model _model, List<string> _img_source)
        {
            var confirmation = string.Empty;
            var client = new HttpClient();
            Car_Bike_Model mol = new Car_Bike_Model
            {
                User_ID = "",
                Product_Type = _model.Product_Type,
                Product_Brand_Name = _model.Product_Brand_Name,
                ProducT_Brand_Model = _model.ProducT_Brand_Model,
                ProducT_Brand_Model_Variant_Name = _model.ProducT_Brand_Model_Variant_Name,
                Manufacturer_Year = _model.Manufacturer_Year,
                Fuel_Type = _model.Fuel_Type,
                Transmisstion_Type = _model.Transmisstion_Type,
                KM_Driven = _model.KM_Driven,
                Number_Of_Onwers = _model.Number_Of_Onwers,
                _location = _model._location,
                _title = _model._title,
                _description = _model._description,
                price = _model.price,
                img_source = _img_source
            };
            var _json = JsonConvert.SerializeObject(mol);
            string str = JToken.Parse(_json).ToString(); // Now You will get the Normal String with "NO SLASHES" 
            HttpContent contentPost = new StringContent(str, Encoding.UTF8, "application/json");
            var result = await client.PostAsync("http://bakers.halkut.in/api/Account/password/change/user/emp/3333333", contentPost);

            if (result.IsSuccessStatusCode)
            {
                var responseReq = await result.Content.ReadAsStringAsync();
                confirmation = JsonConvert.DeserializeObject<string>(responseReq);
            }

            return confirmation.ToString();

        }



        //public async Task<string> Get_Delivery_Charges()
        //{
        //    var client = new HttpClient();

        //    string list = string.Empty;
        //    var result = await client.GetAsync("http://bakers.halkut.in/api/Account/get/delivery/charges");

        //    if (result.IsSuccessStatusCode)
        //    {
        //        var responseReq = await result.Content.ReadAsStringAsync();
        //        list = JsonConvert.DeserializeObject<string>(responseReq);

        //        if (list == "" || list == null)
        //        {
        //            list = "no data";
        //        }
        //    }
        //    //Your code here
        //    return list.ToString();
        //}

    }
}
