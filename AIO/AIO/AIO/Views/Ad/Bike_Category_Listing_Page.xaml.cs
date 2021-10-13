using AIO.Models.Ad_Post;
using AIO.ViewModels.ads;
using NativeMedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AIO.Views.Ad
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bike_Category_Listing_Page : ContentPage
	{
        BikeCategoryListViewModel _bikeCategoryListViewModel = null;

        List<string> _string_array = new List<string>();
        string ad_type_val = string.Empty;
        string bike_category_val = string.Empty;

        public Bike_Category_Listing_Page ()
		{
			InitializeComponent ();

            _bikeCategoryListViewModel = new BikeCategoryListViewModel();

        }



        protected override void OnAppearing()
        {
            try
            {
                FlyoutItem flyoutItem = new FlyoutItem();

                Shell.SetNavBarIsVisible(flyoutItem, false);
                Shell.SetNavBarIsVisible(this, false);
                // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

                ad_post_category_picker.ItemsSource = _bikeCategoryListViewModel._ad_post_type.OrderBy(x => x.CategoryName).Select(x => x.CategoryName).ToList();
            }
            catch (Exception e1)
            {

            }
        }


        //User click on hard back button from phone
        Boolean blnShouldStay = true;
        protected override bool OnBackButtonPressed()
        {
            if (blnShouldStay)
            {
                if (ad_type_val == "" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave in first attempt because user didn't select any value.
                    blnShouldStay = false;
                    base.OnBackButtonPressed();
                    //return false;
                }
                else if (ad_type_val != string.Empty && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave but in second attemt. Click twice on back button.

                    blnShouldStay = false;
                    base.OnBackButtonPressed();
                    OnBackButtonPressed();
                }

                else if (upload_img_stack.IsVisible == true)
                {
                    upload_img_stack.IsVisible = false;
                    post_ad_stack.IsVisible = false;

                    common_stack.IsVisible = true;
                    first_block_next_btn.IsVisible = true;

                    //Second_stacklayout_bike_category.IsVisible = true;
                    //Third_stacklayout.IsVisible = true;

                    if (ad_type_val == "Motorcycle")
                    {
                        Second_stacklayout_bike_category.IsVisible = true;
                    }
                    else if (ad_type_val == "Scooter & Scooty")
                    {
                        Second_stacklayout_scooter_scooty.IsVisible = true;
                    }
                    else if (ad_type_val == "Spare Parts")
                    {
                        upload_img_stack.IsVisible = true;
                    }
                    else if (ad_type_val == "Bicycles")
                    {
                        Second_stacklayout_bicycle_category.IsVisible = true;
                    }
                    next_btn_stacklayout.IsVisible = true;
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



        private void ad_post_category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            ad_post_category_picker.Focus();
        }

        private void ad_post_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ad_post_category_picker.SelectedItem != null)
                {
                    lbl_ad_post_category_picker.IsVisible = true;
                    lbl_ad_post_category_picker.Text = "Ad post is for";
                    ad_type_val = ad_post_category_picker.SelectedItem.ToString();
                    ad_post_category_picker.TextColor = Color.Black;


                    if (ad_type_val == "Motorcycle")
                    {
                        //Setting up next picker item source
                        bike_category_picker.ItemsSource = _bikeCategoryListViewModel._bike_caategory.OrderBy(x => x.CategoryName).Select(x => x.CategoryName).ToList();

                        Second_stacklayout_bike_category.IsVisible = true;
                        Second_stacklayout_scooter_scooty.IsVisible = false;
                        upload_img_stack.IsVisible = false;
                        Second_stacklayout_bicycle_category.IsVisible = false;
                    }
                    else if (ad_type_val == "Scooter & Scooty")
                    {
                        //Setting up next picker item source
                        scooter_and_scooty_category_picker.ItemsSource = _bikeCategoryListViewModel._scooter_scooty_category.OrderBy(x => x.CategoryName).Select(x => x.CategoryName).ToList();


                        Second_stacklayout_bike_category.IsVisible = false;
                        Second_stacklayout_scooter_scooty.IsVisible = true;
                        upload_img_stack.IsVisible = false;
                        Second_stacklayout_bicycle_category.IsVisible = false;
                    }
                    else if (ad_type_val == "Spare Parts")
                    {
                        Second_stacklayout_bike_category.IsVisible = false;
                        Second_stacklayout_scooter_scooty.IsVisible = false;
                        upload_img_stack.IsVisible = true;
                        Second_stacklayout_bicycle_category.IsVisible = false;
                    }
                    else if (ad_type_val == "Bicycles")
                    {
                        //Setting up next picker item source
                        bicycle_category_picker.ItemsSource = _bikeCategoryListViewModel.bicycle_category.OrderBy(x => x.CategoryName).Select(x => x.CategoryName).ToList();

                        Second_stacklayout_bike_category.IsVisible = false;
                        Second_stacklayout_scooter_scooty.IsVisible = false;
                        upload_img_stack.IsVisible = false;
                        Second_stacklayout_bicycle_category.IsVisible = true;
                    }
                    next_btn_stacklayout.IsVisible = true;
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void bike_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bike_category_picker.SelectedItem != null)
                {
                    lbl_bike_category_picker.IsVisible = true;
                    lbl_bike_category_picker.Text = "Ad post is for";
                    bike_category_val = bike_category_picker.SelectedItem.ToString();
                    bike_category_picker.TextColor = Color.Black;

                    //Setting up next picker item source
                    var _id = _bikeCategoryListViewModel._bike_caategory.Where(x => x.CategoryName == bike_category_val).Select(x => x.id).FirstOrDefault();
                    bike_model_picker.ItemsSource = _bikeCategoryListViewModel._bike_model.OrderBy(x => x.modelName).Where(x => x.Bike_Category_id == _id).Select(x => x.modelName).ToList();
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void bike_category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            bike_category_picker.Focus();
        }

        private void bike_model_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            bike_model_picker.Focus();
        }

        private void bike_model_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bike_model_picker.SelectedItem != null)
                {
                    lbl_bike_model_picker.IsVisible = true; 
                    bike_model_picker.TextColor = Color.Black;

                    Third_stacklayout.IsVisible = true;
                }
            }
            catch (Exception e1)
            {

            }
        }


        private void scooter_and_scooty_category_picker_img_btn_Clicked(EventArgs e)
        {
            scooter_and_scooty_category_picker.Focus();
        }

        private void scooter_and_scooty_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (scooter_and_scooty_category_picker.SelectedItem != null)
                {
                    lbl_scooter_and_scooty_category_picker.IsVisible = true;
                    lbl_scooter_and_scooty_category_picker.Text = "Ad post is for";
                    bike_category_val = scooter_and_scooty_category_picker.SelectedItem.ToString();
                    scooter_and_scooty_category_picker.TextColor = Color.Black;

                    //Setting up next picker item source
                    var _id = _bikeCategoryListViewModel._scooter_scooty_category.Where(x => x.CategoryName == bike_category_val).Select(x => x.id).FirstOrDefault();
                    scooter_and_scooty_model_picker.ItemsSource = _bikeCategoryListViewModel._bike_model.OrderBy(x => x.modelName).Where(x => x.Bike_Category_id == _id).Select(x => x.modelName).ToList();
                }
            }
            catch (Exception e1)
            {

            }
        }


        private void scooter_and_scooty_model_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bike_model_picker.SelectedItem != null)
                {
                    lbl_scooter_and_scooty__model_picker.IsVisible = true;
                    scooter_and_scooty_model_picker.TextColor = Color.Black;

                    Third_stacklayout.IsVisible = true;
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void scooter_and_scooty_model_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            scooter_and_scooty_model_picker.Focus();
        }

        private void km_driven_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_km_driven.IsVisible = false;
            }
            else
            { 
                lbl_km_driven.IsVisible = true;
            }
        }

        private void Manufacturer_year_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_year.IsVisible = false;
            }
            else
            {
                lbl_year.IsVisible = true;
            }
        }


        private void bicycle_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bicycle_category_picker.SelectedItem != null)
                {
                    lbl_bicycle_category_picker.IsVisible = true;
                    bicycle_category_picker.TextColor = Color.Black;
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void bicycle_category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            bicycle_category_picker.Focus();
        }



        private void first_block_next_btn_Clicked(object sender, EventArgs e)
        {
            upload_img_stack.IsVisible = true;
            common_stack.IsVisible = false;
            first_block_next_btn.IsVisible = false;
            Second_stacklayout_bike_category.IsVisible = false;
            Third_stacklayout.IsVisible = false;
            Second_stacklayout_scooter_scooty.IsVisible = false;
            Second_stacklayout_bicycle_category.IsVisible = false;
            next_btn_stacklayout.IsVisible = false;
        }

        private void ad_title_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_title.IsVisible = false;
            }
            else
            {
                lbl_title.Text = "Ad Title*";
                lbl_title.IsVisible = true;
            }
        }

        private void Description_editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_building_floor_Description_txt.IsVisible = false;
            }
            else
            {
                lbl_building_floor_Description_txt.Text = "Ad Description ";
                lbl_building_floor_Description_txt.IsVisible = true;
            }
            double _height = Description_editor.Height;
            description_frame.HeightRequest = _height - 6;
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

                    ////Storing string 64 converted bytes into model
                    //_model.img_string64_path.Clear();
                    //_model.img_string64_path = _string_array.ToList();
                }
            }
            catch (Exception e1)
            {

            }
        }


        private void submit_ad_Clicked(object sender, EventArgs e)
        {

        }

    }
}