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
    public partial class Commercial_Vehicles_Category_Listing_Page : ContentPage
    {

        List<string> _string_array = new List<string>();
        string _selected_category = string.Empty;
        Commerical_Vehicle_and_spare_Parts_CategoryListViewModel _commerical_Vehicle_And_Spare_ = null;

        public Commercial_Vehicles_Category_Listing_Page()
        {
            InitializeComponent();
            _commerical_Vehicle_And_Spare_ = new Commerical_Vehicle_and_spare_Parts_CategoryListViewModel();
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();


            FlyoutItem flyoutItem = new FlyoutItem();

            Shell.SetNavBarIsVisible(flyoutItem, false);
            Shell.SetNavBarIsVisible(this, false);
            // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

            description_frame.HeightRequest = 34;

            Ad_Type_picker.ItemsSource = _commerical_Vehicle_And_Spare_._Ad_Types.OrderBy(x => x.Category_Name).Select(x => x.Category_Name).ToList();
        }

        //User click on hard back button from phone
        Boolean blnShouldStay = true;
        protected override bool OnBackButtonPressed()
        {
            if (blnShouldStay)
            {
                if (_selected_category == "" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave in first attempt because user didn't select any value.
                    blnShouldStay = false;
                    base.OnBackButtonPressed();
                    //return false;
                }
                else if (_selected_category != string.Empty && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave but in second attemt. Click twice on back button.

                    blnShouldStay = false;
                    base.OnBackButtonPressed();
                }
                else if (upload_img_stack.IsVisible == true)
                {
                    //In this condition program is checking what was users last filling stacklayout                  
                    common_stack.IsVisible = true;
                    upload_img_stack.IsVisible = false;
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

        private void Ad_Type_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            Ad_Type_picker.Focus();
        }

        private void Ad_Type_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Ad_Type_picker.SelectedItem != null)
                {
                    _selected_category = Ad_Type_picker.SelectedItem.ToString();
                    lbl_Ad_Type_picker.IsVisible = true;
                    Ad_Type_picker.TextColor = Color.Black;

                    Ad_Category_picker_frame.IsVisible = true;
                    if (_selected_category == "Commercial & Other Vehicles")
                    {
                        Ad_Category_picker.ItemsSource = _commerical_Vehicle_And_Spare_._commercial_Vehicles_Categories.OrderBy(x => x.CategoryName).Select(x => x.CategoryName).ToList();
                    }
                    else if (_selected_category == "Spare Parts")
                    {
                        Ad_Category_picker.ItemsSource = _commerical_Vehicle_And_Spare_._spare_Parts_Types.OrderBy(x => x.Spare_Parts_Type_).Select(x => x.Spare_Parts_Type_).ToList();

                        Ad_Commercial_Model_picker_frame.IsVisible = false;
                    }

                    upload_img_stack.IsVisible = false;
                }
            }
            catch (Exception e1)
            {
            }
        }

        private void Ad_Category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Ad_Category_picker.SelectedItem != null)
                {
                    lbl_Ad_Category_picker.IsVisible = true;
                    Ad_Category_picker.TextColor = Color.Black;

                    if (_selected_category == "Commercial & Other Vehicles")
                    {
                        Ad_Commercial_Model_picker_frame.IsVisible = true;

                        //finding id of selected value
                        var _val = Ad_Category_picker.SelectedItem.ToString();
                        int _id = _commerical_Vehicle_And_Spare_._commercial_Vehicles_Categories.Where(x => x.CategoryName == _val).Select(x => x.ID).FirstOrDefault();

                        //getting values of relevant id
                        Ad_Commercial_Model_picker.ItemsSource = _commerical_Vehicle_And_Spare_._commercial_Vehicles_Model_Types.OrderBy(x => x.ModelName).
                            Where(x => x.ID_Commercial_Vehicles_Category == _id).Select(x => x.ModelName).ToList();
                    }
                    else
                    {
                        upload_img_stack.IsVisible = true;
                    }
                }
            }
            catch (Exception e1)
            {
            }
        }

        private void Ad_Category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            Ad_Category_picker.Focus();
        }

        private void Ad_Commercial_Model_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Ad_Commercial_Model_picker.SelectedItem != null)
                {
                    lbl_Ad_Commercial_Model_picker.IsVisible = true;
                    Ad_Commercial_Model_picker.TextColor = Color.Black;

                    upload_img_stack.IsVisible = true;
                }
            }
            catch (Exception e1)
            {
            }
        }

        private void Ad_Commercial_Model_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            Ad_Commercial_Model_picker.Focus();
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
                lbl_Description_txt.IsVisible = false;
            }
            else
            {
                lbl_Description_txt.Text = "Ad Description ";
                lbl_Description_txt.IsVisible = true;
            }
            double _height = Description_editor.Height;
            description_frame.HeightRequest = _height - 6;
        }

        private void selling_price_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_selling_price.IsVisible = false;
            }
            else
            {
                lbl_selling_price.Text = "Selling price is ";
                lbl_selling_price.IsVisible = true;
            }
        }


        private async void OnPickImagesClick(object sender, EventArgs args)
        {
            try
            {
                List<_show_image> _img_list_ = new List<_show_image>();
                var results = await MediaGallery.PickAsync(15, MediaFileType.Image, MediaFileType.Video);

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

                            ImageSource retSource = null;
                            retSource = ImageSource.FromStream(() => new MemoryStream(byte1));

                            _img_name.ImageUrl = retSource;
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