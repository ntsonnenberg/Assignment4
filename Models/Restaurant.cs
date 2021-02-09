using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //This Restaurant class contains a rank (out of best restaurants in Provo) a name, a favorite dish, an address, a phone number, and a link to the restaurants website
    //the GetRestaurants method creates 5 restaurant objects, stores them in an array, and then returns the array
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }

        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        public string? FavDish { get; set; }
        [Required]
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Link { get; set; } = "Coming soon.";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Don Juoquins",
                FavDish = "Tacos",
                Address = "150 W 1230 N St, Provo, UT 84604",
                PhoneNumber = "(801) 400-2894",
                Link = "https://stdonjoaquin.com/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Bombay House",
                FavDish = "Chicken Tiki Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                PhoneNumber = "(801) 373-6677",
                Link = "http://www.bombayhouse.com/"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Se Llama Peru",
                FavDish = "Aji de Gallina",
                Address = "368 W Center St, Provo, UT 84601",
                PhoneNumber = "(801) 375-0275",
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "J Dawgs",
                FavDish = "Hot Dogs",
                Address = "858 700 E, Provo, UT 84606",
                PhoneNumber = "(801) 373-3294",
                Link = "http://www.jdawgs.com/"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Chick-fil-A",
                FavDish = null,
                Address = "484 Bulldog Ln, Provo, UT 84604",
                PhoneNumber = "(801) 374-2697",
                Link = "https://www.chick-fil-a.com/cougarandstate"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
