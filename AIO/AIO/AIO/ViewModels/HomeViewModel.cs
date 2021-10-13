using AIO.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AIO.ViewModels
{
    public class HomeViewModel
    {

        public HomeViewModel()
        {
            Home_Page_First_Image_section = new ObservableCollection<HomeCard>
            {
                new HomeCard
                {
                    Title = "Couple Hotels",
                    command_parameter = "Couple Hotels",
                    ImageUrl = "https://oio.rr-technologies.in/Content/_icons/menu_couple_hotels.png"
                },
                new HomeCard
                {
                    Title = "Airport Cabs",
                    command_parameter = "Airport Cabs",
                    ImageUrl = "https://oio.rr-technologies.in/Content/_icons/menu_airport_cab_new.png"
                },
                new HomeCard
                {
                   Title = "Bus Services",
                    command_parameter = "Bus Services",
                    ImageUrl = "https://oio.rr-technologies.in/Content/_icons/menu_bus.png"
                },
                new HomeCard
                {
                   Title = "Self Drive",
                    command_parameter = "Self Drive",
                    ImageUrl = "https://oio.rr-technologies.in/Content/_icons/menu_self_drive_new.png"
                }
            };


            FirstCards = new ObservableCollection<HomeCard>
            {
                new HomeCard
                {
                    Title = "Movie Get Rs. 555 OFF Per Pax > on Domestic Flight",
                    category = "Flight",
                    location = "Vadodara",
                    PhoneNumber = "1234567890",
                    Details = "Copy & Book: GOAXIS",
                    offer_url = "https://google.com",
                    ImageUrl = "whatsapp.jpeg"
                },
                new HomeCard
                {
                    Title = "Upto Rs. 5000 on Flight Bookings",
                    category = "Hotel",
                    location = "Chandigarh",
                    PhoneNumber = "1234567890",
                    Details = "Copy & Book: GOBOB",
                    offer_url = "https://gmail.com",
                    ImageUrl = "https://www.tampabay.com/resizer//RlpqE-X7u9B1IjmG1Jj35vIS9XU=/1140x641/smart/cloudfront-us-east-1.images.arcpublishing.com/tbt/SDD6DB56NRHCNCPCA6KSQY3TDQ.jpg"
                },
                new HomeCard
                {
                    Title = "Playing Near You",
                    category = "Train",
                    location = "Jammu and Kashmir",
                    PhoneNumber = "1234567890",
                    Details = "Copy & Book: Summersale",
                    offer_url = "https://facebook.com",
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/crazy-fast-food-15-1455274802.jpg?resize=768:*"
                }
            };


            SecondCards = new List<Second_HomeCard>
            {
                new Second_HomeCard
                {
                    Title = "Autos (Cars)",
                    cmd_parameter = "cars",
                    ImageUrl = "_car.png"
                },
                new Second_HomeCard
                {
                    Title = "Properties",
                    cmd_parameter = "properties",
                    ImageUrl = "_property.png"
                },
                new Second_HomeCard
                {
                    Title = "Mobiles",
                    cmd_parameter = "mobile",
                    ImageUrl = "_mobile.png"
                },
                new Second_HomeCard
                {
                    Title = "Jobs",
                    cmd_parameter = "jobs",
                    ImageUrl = "_jobs.png"
                },
                new Second_HomeCard
                {
                    Title = "Autos (Bikes)",
                    cmd_parameter = "bikes",
                    ImageUrl = "_bikes.png"
                },
                new Second_HomeCard
                {
                    Title = "Electronics & Appliances",
                    cmd_parameter = "Electronics & Appliances",
                    ImageUrl = "electronics.png"
                },
                new Second_HomeCard
                {
                    Title = "Commercial & Vechicles & Spare Parts",
                    cmd_parameter = "commercial vechicles",
                    ImageUrl = "_commerical_vechicles.png"
                },
                new Second_HomeCard
                {
                    Title = "Furniture",
                    cmd_parameter = "furniture",
                    ImageUrl = "_furniture.png"
                },
                new Second_HomeCard
                {
                    Title = "Fashion",
                    cmd_parameter = "fashion",
                    ImageUrl = "_fashion.png"
                },
                new Second_HomeCard
                {
                    Title = "Books, Sports & Hobbies",
                    cmd_parameter = "books and sports",
                    ImageUrl = "_books_sports.png"
                },
                new Second_HomeCard
                {
                    Title = "Pets",
                    cmd_parameter = "pets",
                    ImageUrl = "_pets.png"
                },
                new Second_HomeCard
                {
                    Title = "Services",
                    cmd_parameter = "services",
                    ImageUrl = "_services.png"
                }
            };



            MoreCategoryPage = new List<Second_HomeCard>
            {
                new Second_HomeCard
                {
                    Title = "Couple Hotels",
                    cmd_parameter = "Couple Hotels",
                    ImageUrl = "menu_couple_hotels.png"
                },
                new Second_HomeCard
                {
                    Title = "Airport Cabs",
                    cmd_parameter = "Airport Cabs",
                    ImageUrl = "menu_airport_cab_new.png"
                },
                new Second_HomeCard
                {
                    Title = "Bus Services",
                    cmd_parameter = "Bus Services",
                    ImageUrl = "menu_bus.png"
                },
                new Second_HomeCard
                {
                    Title = "Self Drive",
                    cmd_parameter = "Self Drive",
                    ImageUrl = "menu_self_drive_new.png"
                }
            };


        }

        public ObservableCollection<HomeCard> Home_Page_First_Image_section { get; }
        public ObservableCollection<HomeCard> FirstCards { get; }
        public List<Second_HomeCard> SecondCards { get; set; } = new List<Second_HomeCard>();
        public List<Second_HomeCard> MoreCategoryPage { get; set; } = new List<Second_HomeCard>();

    }
}
