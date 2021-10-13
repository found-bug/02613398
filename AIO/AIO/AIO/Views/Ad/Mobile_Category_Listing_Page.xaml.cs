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
    public partial class Mobile_Category_Listing_Page : ContentPage
    {

        mobile_brands _mobile_Brands = null;
        string _selected_category = string.Empty;
        string accessories_sale = string.Empty;
        List<string> _string_array = new List<string>();


        public Mobile_Category_Listing_Page()
        {
            InitializeComponent();

            _mobile_Brands = new mobile_brands();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();


            FlyoutItem flyoutItem = new FlyoutItem();

            Shell.SetNavBarIsVisible(flyoutItem, false);
            Shell.SetNavBarIsVisible(this, false);
            // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

            description_frame.HeightRequest = 34;

            Ad_Category_picker.ItemsSource = _mobile_Brands.Ad_Category_Type_List.OrderBy(x => x.phone_brand_name).Select(x => x.phone_brand_name).ToList();
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
                    if (_selected_category == "Mobile Phones")
                    {
                        mobile_brand_picker_frame.IsVisible = true;
                    }
                    else if (_selected_category == "Accessories")
                    {
                        accessories_sale_stacklayout.IsVisible = true;
                    }
                    else if (_selected_category == "Tablets")
                    {
                        tablet_type_picker_frame.IsVisible = true;
                    }


                    common_stack.IsVisible = true;
                    upload_img_stack.IsVisible = false;
                    first_block_next_btn.IsVisible = true;
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


        private void Ad_Category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ad_Category_picker.SelectedItem != null)
            {
                _selected_category = Ad_Category_picker.SelectedItem.ToString();
                lbl_Ad_Category_picker.IsVisible = true;
                lbl_Ad_Category_picker.Text = "Selling " + _selected_category;
                Ad_Category_picker.TextColor = Color.Black;

                if (_selected_category == "Mobile Phones")
                {
                    mobile_brand_picker_frame.IsVisible = true;
                    accessories_sale_stacklayout.IsVisible = false;
                    tablet_type_picker_frame.IsVisible = false;


                    //Binding up picker of mobile brands list
                    mobile_brand_picker.ItemsSource = _mobile_Brands.mobile_Models_List.OrderBy(x => x.phone_brand_name).Select(x => x.phone_brand_name).ToList();
                }
                else if (_selected_category == "Accessories")
                {
                    mobile_brand_picker_frame.IsVisible = false;
                    accessories_sale_stacklayout.IsVisible = true;
                    tablet_type_picker_frame.IsVisible = false;
                }
                else if (_selected_category == "Tablets")
                {
                    mobile_brand_picker_frame.IsVisible = false;
                    accessories_sale_stacklayout.IsVisible = false;
                    tablet_type_picker_frame.IsVisible = true;

                    //Binding up picker of mobile brands list
                    tablet_type_picker.ItemsSource = _mobile_Brands.Tab_Type_List.OrderBy(x => x.phone_brand_name).Select(x => x.phone_brand_name).ToList();
                }
            }
        }

        private void Ad_Category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            Ad_Category_picker.Focus();
        }

        private void mobile_brand_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mobile_brand_picker.SelectedItem != null)
            {
                lbl_mobile_brand_picker.IsVisible = true;
                lbl_mobile_brand_picker.Text = "Selected brand is";
                mobile_brand_picker.TextColor = Color.Black;
            }
        }

        private void mobile_brand_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            mobile_brand_picker.Focus();
        }

        private void accessories_sale_phone_btn_Clicked(object sender, EventArgs e)
        {
            accessories_sale = "Phone";
            accessories_sale_phone_btn.TextColor = Color.FromHex("#fff");
            accessories_sale_phone_frame.BackgroundColor = Color.FromHex("#d8203a");
            accessories_sale_phone_frame.Opacity = .5;
            accessories_sale_tablet_frame.BackgroundColor = Color.Transparent;
            accessories_sale_tablet_btn.TextColor = Color.FromHex("#000");
            lbl_accessories_sale.Text = accessories_sale;
        }

        private void accessories_sale_tablet_btn_Clicked(object sender, EventArgs e)
        {
            accessories_sale = "Tablet";
            accessories_sale_tablet_btn.TextColor = Color.FromHex("#fff");
            accessories_sale_tablet_frame.BackgroundColor = Color.FromHex("#d8203a");
            accessories_sale_tablet_frame.Opacity = .5;
            accessories_sale_phone_frame.BackgroundColor = Color.Transparent;
            accessories_sale_phone_btn.TextColor = Color.FromHex("#000");
            lbl_accessories_sale.Text = accessories_sale;
        }

        private void tablet_type_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablet_type_picker.SelectedItem != null)
            {
                lbl_tablet_type_picker.IsVisible = true;
                lbl_tablet_type_picker.Text = "Tablet is from";
                tablet_type_picker.TextColor = Color.Black;
            }
        }

        private void tablet_type_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            tablet_type_picker.Focus();
        }

        private void first_block_next_btn_Clicked(object sender, EventArgs e)
        {
            if (_selected_category != string.Empty)
            {
                common_stack.IsVisible = false;

                upload_img_stack.IsVisible = true;
                first_block_next_btn.IsVisible = false;
            }
        }

        private void building_floor_ad_title_TextChanged(object sender, TextChangedEventArgs e)
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

        private void building_floor_Description_editor_TextChanged(object sender, TextChangedEventArgs e)
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
            double _height = building_floor_Description_editor.Height;
            description_frame.HeightRequest = _height - 6;
        }

        private void price_property_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_price_property.IsVisible = false;
            }
            else
            {
                lbl_price_property.Text = "Car price is ";
                lbl_price_property.IsVisible = true;
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


        private async void submit_ad_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success","Ad has been posted","Okay");
        }
    }
}