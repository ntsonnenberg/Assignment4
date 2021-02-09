using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //The Submission class contains a name (of the person submitting the restaurant), the restaurant name, the persons favorite dish at that restaurant, and the restaurant phone number
    public class Submission
    {
        public string Name { get; set; }
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}")]
        public string PhoneNumber { get; set; }
    }
}
