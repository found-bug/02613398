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
    public partial class Property_Category_Listing_Page : ContentPage
    {
        string _property_is_on_val = string.Empty;
        List<string> _string_array = new List<string>();
        string property_category_val = string.Empty;
        string _meals_included = string.Empty;

        Proeprty_Model_For_DB _model = null;

        PropertyCategoryListViewModel propertyCategoryListViewModel = null;
        public Property_Category_Listing_Page()
        {
            InitializeComponent();
            propertyCategoryListViewModel = new PropertyCategoryListViewModel();
            _model = new Proeprty_Model_For_DB();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

              
            FlyoutItem flyoutItem = new FlyoutItem();

            Shell.SetNavBarIsVisible(flyoutItem, false);
            Shell.SetNavBarIsVisible(this, false);
            // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

            description_frame.HeightRequest = 34;

            property_category_picker.ItemsSource = propertyCategoryListViewModel.onwership_list.OrderBy(x => x.Property_Category).Select(x => x.Property_Category).ToList();

        }

        //User click on hard back button from phone
        Boolean blnShouldStay = true;
        protected override bool OnBackButtonPressed()
        {
            if (blnShouldStay)
            {
                if (property_category_val == "" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave.
                    base.OnBackButtonPressed();
                    return false;
                }
                else if (property_category_val == "House & Appartment" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave.
                    base.OnBackButtonPressed();
                    return false;
                }
                else if (property_category_val == "Lands & Plots" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave.
                    base.OnBackButtonPressed();
                    return false;
                }
                else if (property_category_val == "Shops & Offices" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave.
                    base.OnBackButtonPressed();
                    return false;
                }
                else if (property_category_val == "Guesthouse & PG" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave.
                    base.OnBackButtonPressed();
                    return false;
                }
                else if(upload_img_stack.IsVisible == true)
                {
                    //In this condition program is checking what was users last filling stacklayout
                    if (property_category_val == "House & Appartment")
                    {
                        House_and_Appartment_stacklayout.IsVisible = true;
                    }
                    else if (property_category_val == "Lands & Plots")
                    {
                        Lands_and_Plots_stacklayout.IsVisible = true;
                    }
                    else if (property_category_val == "Shops & Offices")
                    {
                        Shops_and_Offices_stacklayout.IsVisible = true;
                    }
                    else if (property_category_val == "Guesthouse & PG")
                    {
                        Guesthouse_and_PG_stacklayout.IsVisible = true;
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


        private void property_rent_btn_Clicked(object sender, EventArgs e)
        {
            _property_is_on_val = "Rent";
            property_rent_btn.TextColor = Color.FromHex("#fff");
            rent_btn_stacklayout.BackgroundColor = Color.FromHex("#d8203a");
            rent_btn_stacklayout.Opacity = .5;
            sale_btn_stacklayout.BackgroundColor = Color.Transparent;
            property_sale_btn.TextColor = Color.FromHex("#000");
            lbl_property_is_on.Text = _property_is_on_val;
            _model.Property_is_for_sale_or_on_rent = _property_is_on_val;
        }

        private void property_sale_btn_Clicked(object sender, EventArgs e)
        {
            _property_is_on_val = "Sale";
            property_sale_btn.TextColor = Color.FromHex("#fff");
            sale_btn_stacklayout.BackgroundColor = Color.FromHex("#d8203a");
            sale_btn_stacklayout.Opacity = .5;
            rent_btn_stacklayout.BackgroundColor = Color.Transparent;
            property_rent_btn.TextColor = Color.FromHex("#000");
            lbl_property_is_on.Text = _property_is_on_val;
            _model.Property_is_for_sale_or_on_rent = _property_is_on_val;
        }

        private void property_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_category_picker.SelectedItem != null)
            {
                lbl_property_category_picker.IsVisible = true;
                property_category_val = property_category_picker.SelectedItem.ToString();
                lbl_property_category_picker.Text = "You've a " + property_category_val;
                property_category_picker.TextColor = Color.Black;

                //setting up value in model
                _model.Property_Category = property_category_val;


                if (property_category_val == "House & Appartment")
                {
                    btn_stacklayout_sale_rent.IsVisible = true;
                    House_and_Appartment_stacklayout.IsVisible = true;
                    Lands_and_Plots_stacklayout.IsVisible = false;
                    Shops_and_Offices_stacklayout.IsVisible = false;
                    Guesthouse_and_PG_stacklayout.IsVisible = false;

                    //Setting up 2nd picker data binding
                    property_type_picker.ItemsSource = propertyCategoryListViewModel.property_type_list.OrderBy(x => x.Property_Type).Select(x => x.Property_Type).ToList();
                }
                else if (property_category_val == "Lands & Plots")
                {
                    btn_stacklayout_sale_rent.IsVisible = false;
                    House_and_Appartment_stacklayout.IsVisible = false;
                    Lands_and_Plots_stacklayout.IsVisible = true;
                    Shops_and_Offices_stacklayout.IsVisible = false;
                    Guesthouse_and_PG_stacklayout.IsVisible = false;
                }
                else if (property_category_val == "Shops & Offices")
                {
                    btn_stacklayout_sale_rent.IsVisible = true;
                    House_and_Appartment_stacklayout.IsVisible = false;
                    Lands_and_Plots_stacklayout.IsVisible = false;
                    Shops_and_Offices_stacklayout.IsVisible = true;
                    Guesthouse_and_PG_stacklayout.IsVisible = false;
                }
                else if (property_category_val == "Guesthouse & PG")
                {
                    btn_stacklayout_sale_rent.IsVisible = false;
                    House_and_Appartment_stacklayout.IsVisible = false;
                    Lands_and_Plots_stacklayout.IsVisible = false;
                    Shops_and_Offices_stacklayout.IsVisible = false;
                    Guesthouse_and_PG_stacklayout.IsVisible = true;

                    ////Setting up picker data binding
                    pg_Building_Sub_Type_picker.ItemsSource = propertyCategoryListViewModel.pg_and_guest_house_sub_type_list.OrderBy(x => x.bedroom_count).Select(x => x.bedroom_count).ToList();


                    ////Setting up picker data binding
                    pg_car_parking_picker.ItemsSource = propertyCategoryListViewModel.car_parking_list.OrderBy(x => x.bedroom_count).Select(x => x.bedroom_count).ToList();
                }


                ////Setting up picker data binding
                property_listed_by_picker.ItemsSource = propertyCategoryListViewModel.listed_by_list.OrderBy(x => x.construction_type).Select(x => x.construction_type).ToList();
                frame_property_listed_by_picker.IsVisible = true;

                ////Setting up picker data binding
                property_direction_picker.ItemsSource = propertyCategoryListViewModel.facing_list.OrderBy(x => x.bedroom_count).Select(x => x.bedroom_count).ToList();
                frame_property_direction_picker.IsVisible = true;
            }
        }

        private void property_category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_category_picker.Focus();
        }
      

        private void property_type_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_type_picker.Focus();
        }

        private void property_type_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_type_picker.SelectedItem != null)
            {
                lbl_property_type_picker.IsVisible = true;
                lbl_property_type_picker.Text = "Your " + property_type_picker.SelectedItem.ToString() + " is on " + _property_is_on_val;
                property_type_picker.TextColor = Color.Black;

                //setting up value in model
                _model.Property_Category = property_type_picker.SelectedItem.ToString();


                //Setting up 3rd picker data binding
                property_bedroom_picker.ItemsSource = propertyCategoryListViewModel.bedroom_list.OrderBy(x => x.bedroom_count).Select(x => x.bedroom_count).ToList();
            }
        }

        private void property_bedroom_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_bedroom_picker.SelectedItem != null)
            {
                lbl_property_bedroom_picker.IsVisible = true;
                string _bedroom_count = property_bedroom_picker.SelectedItem.ToString();

                //setting up value in model
                _model.Bedroom_count = Convert.ToInt32(_bedroom_count);

                //if bedroom is 1 so total bedroom will be the statement
                if (_bedroom_count == "1")
                {
                    lbl_property_bedroom_picker.Text = "Total " + property_bedroom_picker.SelectedItem.ToString() + " bedroom at your " + property_type_picker.SelectedItem.ToString();
                }
                //if bedroom is more than 1 so total bedrooms will be the statement
                else if (_bedroom_count != "1")
                {
                    lbl_property_bedroom_picker.Text = "Total " + property_bedroom_picker.SelectedItem.ToString() + " bedrooms at your " + property_type_picker.SelectedItem.ToString();
                }

                property_bedroom_picker.TextColor = Color.Black;

                ////Setting up 5th picker data binding
                property_bathroom_picker.ItemsSource = propertyCategoryListViewModel.bedroom_list.OrderBy(x => x.bedroom_count).Select(x => x.bedroom_count).ToList();

            }
        }

        private void property_bedroom_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_bedroom_picker.Focus();
        }

        private void property_bathroom_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_bathroom_picker.SelectedItem != null)
            {
                lbl_property_bathroom_picker.IsVisible = true;
                string bathroom_count = property_bathroom_picker.SelectedItem.ToString();

                //setting up value in model
                _model.bathroom_count = Convert.ToInt32(bathroom_count);

                //if bedroom is 1 so total bedroom will be the statement
                if (bathroom_count == "1")
                {
                    lbl_property_bathroom_picker.Text = "Total " + property_bathroom_picker.SelectedItem.ToString() + " bathroom at your " + property_type_picker.SelectedItem.ToString();
                }
                //if bedroom is more than 1 so total bedrooms will be the statement
                else if (bathroom_count != "1")
                {
                    lbl_property_bathroom_picker.Text = "Total " + property_bathroom_picker.SelectedItem.ToString() + " bathrooms at your " + property_type_picker.SelectedItem.ToString();
                }

                property_bathroom_picker.TextColor = Color.Black;

                ////Setting up 5th picker data binding
                property_Furnished_picker.ItemsSource = propertyCategoryListViewModel.furnishing_list.OrderBy(x => x.furnishing_type).Select(x => x.furnishing_type).ToList();

            }
        }

        private void property_bathroom_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_bathroom_picker.Focus();
        }

        private void property_Furnished_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_Furnished_picker.Focus();
        }

        private void property_Furnished_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_Furnished_picker.SelectedItem != null)
            {
                lbl_property_Furnished_picker.IsVisible = true;

                lbl_property_Furnished_picker.Text = "You've " + property_Furnished_picker.SelectedItem.ToString() + " property";

                property_Furnished_picker.TextColor = Color.Black;

                //setting up value in model
                _model.Furnished_or_not = property_Furnished_picker.SelectedItem.ToString();

                ////Setting up 5th picker data binding
                property_construction_picker.ItemsSource = propertyCategoryListViewModel.construction_status_list.OrderBy(x => x.construction_type).Select(x => x.construction_type).ToList();

            }
        }

        private void property_construction_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_construction_picker.Focus();
        }

        private void property_construction_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_construction_picker.SelectedItem != null)
            {
                lbl_property_construction_picker.IsVisible = true;

                lbl_property_construction_picker.Text = "Your " + property_type_picker.SelectedItem.ToString() + " is " + property_construction_picker.SelectedItem.ToString();

                property_construction_picker.TextColor = Color.Black;

                //setting up value in model
                _model.how_old_property_construction = property_construction_picker.SelectedItem.ToString();
            }
            
        }

        private void property_listed_by_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_listed_by_picker.Focus();
        }

        private void property_listed_by_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_listed_by_picker.SelectedItem != null)
            {
                lbl_property_listed_by_picker.IsVisible = true;

                lbl_property_listed_by_picker.Text = "You're a " + property_listed_by_picker.SelectedItem.ToString();

                property_listed_by_picker.TextColor = Color.Black;

                //setting up value in model
                _model.property_listed_by = property_listed_by_picker.SelectedItem.ToString();

                ////Setting up 5th picker data binding
                car_parking_picker.ItemsSource = propertyCategoryListViewModel.car_parking_list.OrderBy(x => x.bedroom_count).Select(x => x.bedroom_count).ToList();
            }
        }

        private void buildup_area_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_buildup_area.IsVisible = false;
            }
            else
            {
                lbl_buildup_area.Text = "Total builtup is " + buildup_area.Text;
                lbl_buildup_area.IsVisible = true;
            }

            //setting up value in model
            int buildup_area_ = Convert.ToInt32(buildup_area.Text);
            _model.house_Builtup_Area = buildup_area_;
        }

        private void carpet_area_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_carpet_area.IsVisible = false;
            }
            else
            {
                lbl_carpet_area.Text = "Total carpet is " + carpet_area.Text;
                lbl_carpet_area.IsVisible = true;
            }
            //setting up value in model
            int carpet_area_ = Convert.ToInt32(carpet_area.Text);
            _model.house_Carpet_Area = carpet_area_;
        }

        private void Maintenance_Cost_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Maintenance_cost.IsVisible = false;
            }
            else
            {
                lbl_Maintenance_cost.Text = "Total maintenance cost is " + Maintenance_Cost.Text;
                lbl_Maintenance_cost.IsVisible = true;
            }

            //setting up value in model
            double Maintenance_Cost_ = Convert.ToDouble(Maintenance_Cost.Text);
            _model.Maintenance_Cost = Maintenance_Cost_;
        }

        private void total_floors_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_total_floors.IsVisible = false;
            }
            else
            {
                lbl_total_floors.Text = "Total floors are is " + total_floors.Text;
                lbl_total_floors.IsVisible = true;
            }

            //setting up value in model
            int total_floors_ = Convert.ToInt32(total_floors.Text);
            _model.Maintenance_Cost = total_floors_;
        }

        private void car_parking_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            car_parking_picker.Focus();
        }

        private void car_parking_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (car_parking_picker.SelectedItem != null)
            {
                lbl_car_parking_picker.IsVisible = true;

                lbl_car_parking_picker.Text = "You've " + car_parking_picker.SelectedItem.ToString() + " car parking";

                lbl_car_parking_picker.TextColor = Color.Black;

                //setting up value in model
                int _car_parking_count = Convert.ToInt32(car_parking_picker.SelectedItem.ToString());
                _model.number_of_Car_Parking = _car_parking_count;
            }
        }

        private void property_direction_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            property_direction_picker.Focus();
        }

        private void property_direction_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (property_direction_picker.SelectedItem != null)
            {
                lbl_property_direction_picker.IsVisible = true;
                lbl_property_direction_picker.Text = "Your property direction is " + property_direction_picker.SelectedItem.ToString();
                property_direction_picker.TextColor = Color.Black;

                //setting up value in model
                _model.Property_Site_Facing = property_direction_picker.SelectedItem.ToString();
            }
        }

        private void first_block_next_btn_Clicked(object sender, EventArgs e)
        {
            if (property_category_val != string.Empty)
            {
                if (property_category_val == "House & Appartment")
                {
                    House_and_Appartment_stacklayout.IsVisible = false;
                    common_stack.IsVisible = false;
                }
                else if (property_category_val == "Lands & Plots")
                {
                    Lands_and_Plots_stacklayout.IsVisible = false;
                    common_stack.IsVisible = false;
                }
                else if (property_category_val == "Shops & Offices")
                {
                    Shops_and_Offices_stacklayout.IsVisible = false;
                    common_stack.IsVisible = false;
                }
                else if (property_category_val == "Guesthouse & PG")
                {
                    Guesthouse_and_PG_stacklayout.IsVisible = false;
                    common_stack.IsVisible = false;
                }
                upload_img_stack.IsVisible = true;
                first_block_next_btn.IsVisible = false;
            }
        }

        private void project_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_project_name.IsVisible = false;
            }
            else
            {
                lbl_project_name.Text = "Project name is " + project_name.Text;
                lbl_project_name.IsVisible = true;
            }

            //setting up value in model
            _model.Project_Name = project_name.Text;
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
            //setting up value in model
            int building_floor_ad_title_ = Convert.ToInt32(building_floor_ad_title.Text);
            _model.house_Total_Floors = building_floor_ad_title_;
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

            //setting up value in model
            _model.Description = building_floor_Description_editor.Text;
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

            //setting up value in model
            double _price = Convert.ToDouble(price_property.Text);
            _model.Price = _price;
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

                    //Storing string 64 converted bytes into model
                    _model.img_string64_path.Clear();
                    _model.img_string64_path = _string_array.ToList();
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void plot_area_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_plot_area.IsVisible = false;
            }
            else
            {
                lbl_plot_area.Text = "Total plot area is " + plot_area.Text;
                lbl_plot_area.IsVisible = true;
            }

            //setting up value in model
            int _plot_area_ = Convert.ToInt32(plot_area.Text);
            _model.MPlot_Area = _plot_area_;

        }

        private void plot_length_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Length.IsVisible = false;
            }
            else
            {
                lbl_Length.IsVisible = true;
            }

            //setting up value in model
            int plot_length_ = Convert.ToInt32(plot_length.Text);
            _model.plot_Length = plot_length_;
        }

        private void plot_breadth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Breadth.IsVisible = false;
            }
            else
            {
                lbl_Breadth.IsVisible = true;
            }

            //setting up value in model
            int plot_breadth_ = Convert.ToInt32(plot_breadth.Text);
            _model.plot_Breadth = plot_breadth_;
        }

        private void plot_project_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_plot_project_name.IsVisible = false;
            }
            else
            {
                lbl_plot_project_name.IsVisible = true;
            }
            //setting up value in model
            _model.Project_Name = plot_project_name.Text;
        }

        private void Shop_area_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Shop_area.IsVisible = false;
            }
            else
            {
                lbl_Shop_area.IsVisible = true;
            }
            //setting up value in model
            int Shop_area_ = Convert.ToInt32(Shop_area.Text);
            _model.Shop_Area = Shop_area_;
        }

        private void Shop_length_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Shop_Length.IsVisible = false;
            }
            else
            {
                lbl_Shop_Length.IsVisible = true;
            }
            //setting up value in model
            int Shop_length_ = Convert.ToInt32(Shop_length.Text);
            _model.Shop_Length = Shop_length_;
        }

        private void Shop_breadth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Shop_Breadth.IsVisible = false;
            }
            else
            {
                lbl_Shop_Breadth.IsVisible = true;
            }
            //setting up value in model
            int Shop_breadth_ = Convert.ToInt32(Shop_breadth.Text);
            _model.Shop_Length = Shop_breadth_;
        }

        private void Shop_project_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_Shop_project_name.IsVisible = false;
            }
            else
            {
                lbl_Shop_project_name.IsVisible = true;
            }
            //setting up value in model
            _model.Project_Name = Shop_project_name.Text;
        }

        private void pg_Building_Sub_Type_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pg_Building_Sub_Type_picker.SelectedItem != null)
            {
                lbl_Building_Sub_Type_picker.IsVisible = true;
                lbl_Building_Sub_Type_picker.Text = "Your property sub type is " + pg_Building_Sub_Type_picker.SelectedItem.ToString();
                pg_Building_Sub_Type_picker.TextColor = Color.Black;

                //setting up value in model
                _model.Building_Sub_Type = pg_Building_Sub_Type_picker.SelectedItem.ToString();
            }
        }

        private void pg_Building_Sub_Type_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            pg_Building_Sub_Type_picker.Focus();
        }

        private void pg_car_parking_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pg_car_parking_picker.SelectedItem != null)
            {
                lbl_pg_car_parking_picker.IsVisible = true;
                lbl_pg_car_parking_picker.Text = "Car parking is " + pg_car_parking_picker.SelectedItem.ToString();
                pg_car_parking_picker.TextColor = Color.Black;

                //setting up value in model
                int _car_parking_count = Convert.ToInt32(pg_car_parking_picker.SelectedItem.ToString());
                _model.number_of_Car_Parking = _car_parking_count;
            }
        }

        private void pg_car_parking_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            pg_car_parking_picker.Focus();
        }

        private void yes_meals_included_btn_Clicked(object sender, EventArgs e)
        {
            _meals_included = "Yes";
            yes_meals_included_btn.TextColor = Color.FromHex("#fff");
            yes_btn_meals_included_stacklayout.BackgroundColor = Color.FromHex("#d8203a");
            yes_btn_meals_included_stacklayout.Opacity = .5;
            no_btn_meals_included_stacklayout.BackgroundColor = Color.Transparent;
            no_meals_included_btn.TextColor = Color.FromHex("#000");
            lbl_meals_included.Text = _property_is_on_val;
        }

        private void no_meals_included_btn_Clicked(object sender, EventArgs e)
        {
            _meals_included = "No";
            no_meals_included_btn.TextColor = Color.FromHex("#fff");
            no_btn_meals_included_stacklayout.BackgroundColor = Color.FromHex("#d8203a");
            no_btn_meals_included_stacklayout.Opacity = .5;
            yes_btn_meals_included_stacklayout.BackgroundColor = Color.Transparent;
            yes_meals_included_btn.TextColor = Color.FromHex("#000");
            lbl_meals_included.Text = _meals_included;
        }

        private void submit_ad_Clicked(object sender, EventArgs e)
        {

        }
    }
}