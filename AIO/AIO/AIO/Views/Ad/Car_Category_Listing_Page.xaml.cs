
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIO.Models.Ad_Post;
using AIO.ViewModels.ads;
using FFImageLoading.Forms;
using NativeMedia;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.Ad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Car_Category_Listing_Page : ContentPage
    {

        private static string Transmission_Type_Val = string.Empty;
      
        List<string> _string_array = new List<string>();
        List<string> _video_string_array = new List<string>();
        public Car_Category_Listing_Page()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();


            description_frame.HeightRequest = 35;

            FlyoutItem flyoutItem = new FlyoutItem();

            Shell.SetNavBarIsVisible(flyoutItem, false);
            Shell.SetNavBarIsVisible(this, false);
            // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

            CarCategoryListViewModel carCategoryListViewModel = new CarCategoryListViewModel();

          
            brand_name_picker.ItemsSource = carCategoryListViewModel.Car_BrandName_List.OrderBy(x => x.CategoryName).Select(x => x.CategoryName).ToList();
            _fuel_tupe_list.ItemsSource = carCategoryListViewModel.Fuel_Type.OrderBy(x => x._fuel_type).Select(x => x._fuel_type).ToList();
            _number_of_onwer_list.ItemsSource = carCategoryListViewModel.onwership_list.OrderBy(x => x._onwer_ship_number).Select(x => x._onwer_ship_number).ToList();
        }


        Boolean blnShouldStay = true;
        protected override bool OnBackButtonPressed()
        {
            if (blnShouldStay)
            {
                if (first_block.IsVisible == true)
                {
                    // It's okay, we can leave.
                    base.OnBackButtonPressed();
                    return false;
                }
                else
                {
                    first_block.IsVisible = true;
                    second_block.IsVisible = false;
                    post_ad_stack.IsVisible = false;
                }
                // Yes, we want to stay.
                return true;
            }
            else
            {
                // It's okay, we can leave.
                base.OnBackButtonPressed();
                return false;
            }
        }


        private async void OnPickImagesClick(object sender, EventArgs args)
        {
            try
            {
                List<_show_image> _img_list_ = new List<_show_image>();
                var results = await MediaGallery.PickAsync(15, MediaFileType.Image, MediaFileType.Video);
                //var results = await MediaGallery.PickAsync(15, MediaFileType.Image);

                if (results?.Files == null)
                {
                    return;
                }

                foreach (var media in results.Files)
                { 
                    string _slpit_val = media.ContentType.Split('/').First();

                    if (_slpit_val == "image")
                    {
                        using (MemoryStream memory = new MemoryStream())
                        {
                            var extension = media.Extension;

                            Stream stream = await media.OpenReadAsync();
                            stream.CopyTo(memory);
                            byte[] byte1 = null;
                            byte1 = memory.ToArray();
                            string imageBase64Data = Convert.ToBase64String(byte1);
                            _string_array.Add(imageBase64Data);
                            _show_image _img_name = new _show_image();
                            Image _img = new Image();
                            //string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);

                            ImageSource retSource = null;
                            retSource = ImageSource.FromStream(() => new MemoryStream(byte1));


                            _img_name.ImageUrl = retSource;
                          //  _img_name.ImageUrl = imageDataURL;
                            _img_list_.Add(_img_name);
                            _img_name = null;
                        }
                    }
                    else
                    {
                        await DisplayAlert("Alert", "Only images allowed", "Okay");
                    }
                }
                if (_img_list_.Count > 0)
                {
                    img_list.ItemsSource = _img_list_.ToList();
                    img_list_stack.IsVisible = true;
                    post_ad_stack.IsVisible = true;
                }
            }
            catch (Exception e1)
            {

            }
        }

        private async void pickVideos_Clicked(object sender, EventArgs e)
        {
            try
            {
                var results = await MediaGallery.PickAsync(2, MediaFileType.Video);

                if (results?.Files == null)
                {
                    return;
                }

                foreach (var media in results.Files)
                {

                    using (MemoryStream memory = new MemoryStream())
                    {
                        var extension = media.Extension;

                        byte[] byte2 = null;
                        Stream stream = await media.OpenReadAsync();
                        stream.CopyTo(memory);
                        byte2 = memory.ToArray();
                        string imageBase64Data = Convert.ToBase64String(byte2);
                        _video_string_array.Add(imageBase64Data);

                    }
                }
            }
            catch (Exception e1)
            {
            }
        }

        private void brand_name_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            brand_name_picker.Focus();
        }

        private void brand_name_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_brand_name_picker.IsVisible = true;
                string _selected_data = brand_name_picker.SelectedItem.ToString();
                CarCategoryListViewModel carCategoryListViewModel = new CarCategoryListViewModel();
                var _id = carCategoryListViewModel.Car_BrandName_List.Where(x => x.CategoryName == _selected_data).Select(x => x.id).FirstOrDefault();
                var _data = carCategoryListViewModel.Car_Variant_Name_List.Where(x => x.CarBrand_id == _id).Select(x => x.CarVariantName).ToList();
                brand_varient_picker.ItemsSource = _data;
                brand_name_picker.TextColor = Color.Black;
                lbl_brand_name_picker.Text = "Your car brand is";
            }
            catch (Exception e1)
            {

            }
        }

        private void brand_varient_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            brand_varient_picker.Focus();
        }
         
        private void _fuel_tupe_list_btn_Clicked(object sender, EventArgs e)
        {
            _fuel_tupe_list.Focus();
        }

        private void car_type_automatic_Clicked(object sender, EventArgs e)
        {
            Transmission_Type_Val = "Automatic";
            car_type_automatic.TextColor = Color.FromHex("#d8203a");
            car_type_manual.TextColor = Color.FromHex("#000");
            transmission_selected_val.Text = "Automatic";
        }

        private void car_type_manual_Clicked(object sender, EventArgs e)
        {
            Transmission_Type_Val = "Manual";
            car_type_automatic.TextColor = Color.FromHex("#000");
            car_type_manual.TextColor = Color.FromHex("#d8203a");
            transmission_selected_val.Text = "Manual";
        }

        private void brand_varient_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_brand_varient_picker.IsVisible = true;
            lbl_brand_varient_picker.Text = "Model is ";
            brand_varient_picker.TextColor = Color.Black;
        }

        private void _fuel_tupe_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_fuel_tupe_list.IsVisible = true;
            lbl_fuel_tupe_list.Text = "Fuel type is";
            _fuel_tupe_list.TextColor = Color.Black;
        }

        private void _number_of_onwer_list_btn_Clicked(object sender, EventArgs e)
        {
            _number_of_onwer_list.Focus();
        }

        private void _number_of_onwer_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_number_of_onwer.IsVisible = true;
            lbl_number_of_onwer.Text = "You are ";
            _number_of_onwer_list.TextColor = Color.Black;
        }

        private void ad_title_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_ad_title.IsVisible = false;
            }
            else
            {
                lbl_ad_title.IsVisible = true;
            }
        }

        private void km_driven_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_km_driven.IsVisible = false;
            }
            else
            {
                lbl_km_driven.Text = "Total driven " + km_driven.Text;
                lbl_km_driven.IsVisible = true;
            }
        }

        private void first_block_next_btn_Clicked(object sender, EventArgs e)
        {
            first_block.IsVisible = false;
            second_block.IsVisible = true;

            if (ad_title.Text != null && description_editor.Text != null)
            {
                post_ad_stack.IsVisible = true;
            }

        }

        private void description_editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lblDescription_txt.IsVisible = false;
            }
            else
            {
                lblDescription_txt.Text = "Ad Description ";
                lblDescription_txt.IsVisible = true;
            }
            double _height = description_editor.Height;
            description_frame.HeightRequest = _height - 10.5;
        }

        private async void submit_ad_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DisplayAlert("Success","Your ad has been posted","Okay");
            }
            catch (Exception e1)
            {
            }
        }

        private void price_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_price.IsVisible = false;
            }
            else
            {
                lbl_price.Text = "Car price is ";
                lbl_price.IsVisible = true;
            }
        }
    }
}