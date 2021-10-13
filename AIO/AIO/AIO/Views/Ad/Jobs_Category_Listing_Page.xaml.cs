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
	public partial class Jobs_Category_Listing_Page : ContentPage
	{

        List<string> _string_array = new List<string>();
        string job_category_val = string.Empty;
        JobCategoryListViewModel _jobCategoryListViewModel = null;

        public Jobs_Category_Listing_Page()
        {
            InitializeComponent();
            _jobCategoryListViewModel = new JobCategoryListViewModel();
        }

        protected override void OnAppearing()
        {
            try
            {
                FlyoutItem flyoutItem = new FlyoutItem();

                Shell.SetNavBarIsVisible(flyoutItem, false);
                Shell.SetNavBarIsVisible(this, false);
                // Shell.SetFlyoutItemIsVisible(FlyoutHeader., false);

                job_category_picker.ItemsSource = _jobCategoryListViewModel._job_category_List.OrderBy(x => x.Job_Category).Select(x => x.Job_Category).ToList();
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
                if (job_category_val == "" && upload_img_stack.IsVisible == false)
                {
                    // It's okay, we can leave in first attempt because user didn't select any value.
                    blnShouldStay = false;
                    base.OnBackButtonPressed();
                    return false;
                }
                else if (job_category_val != string.Empty && upload_img_stack.IsVisible == false)
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
                    Second_stacklayout.IsVisible = true;
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


        private void job_category_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            job_category_picker.Focus();
        }

        private void job_category_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (job_category_picker.SelectedItem != null)
                {
                    lbl_job_category_picker.IsVisible = true;
                    lbl_job_category_picker.Text = "Job category is";
                    job_category_val = job_category_picker.SelectedItem.ToString();
                    job_category_picker.TextColor = Color.Black;

                    //Setting up next picker item source
                    salary_period_picker.ItemsSource = _jobCategoryListViewModel.salary_period_List.OrderBy(x => x._salary_period_type).Select(x => x._salary_period_type).ToList();

                    Second_stacklayout.IsVisible = true;
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void salary_period_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (salary_period_picker.SelectedItem != null)
                {
                    lbl_salary_period_picker.IsVisible = true;
                    lbl_salary_period_picker.Text = "Salary period would be";
                    salary_period_picker.TextColor = Color.Black;

                    //Setting up next picker item source
                    position_type_picker.ItemsSource = _jobCategoryListViewModel.job_position_type_List.OrderBy(x => x._position_type_type).Select(x => x._position_type_type).ToList();
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void salary_period_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            salary_period_picker.Focus();
        }

        private void position_type_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (salary_period_picker.SelectedItem != null)
                {
                    lbl_position_type_picker.IsVisible = true;
                    lbl_position_type_picker.Text = "Job type would be";
                    position_type_picker.TextColor = Color.Black;
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void position_type_picker_img_btn_Clicked(object sender, EventArgs e)
        {
            position_type_picker.Focus();

        }

        private void salary_starting_from_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_salary_starting_from.IsVisible = false;
            }
            else
            {
                lbl_salary_starting_from.Text = "Salary starting from " + salary_starting_from.Text;
                lbl_salary_starting_from.IsVisible = true;
            }
        }

        private void salary_starting_to_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == "")
            {
                lbl_salary_starting_to.IsVisible = false;
            }
            else
            {
                lbl_salary_starting_to.Text = "Salary Till " + salary_starting_to.Text;
                lbl_salary_starting_to.IsVisible = true;
            }
        }

        private void first_block_next_btn_Clicked(object sender, EventArgs e)
        {
            upload_img_stack.IsVisible = true;
            common_stack.IsVisible = false;
            first_block_next_btn.IsVisible = false;
            Second_stacklayout.IsVisible = false;
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