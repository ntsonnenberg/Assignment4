using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Displays index page along with the top 5 restaurants in Provo
        public IActionResult Index()
        {
            List<string> Restaurants = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? fav_dish = r.FavDish ?? "It's all tasty!";

                Restaurants.Add($"{r.Rank}: {r.Name} | Favorite Dish- {fav_dish} | Address- {r.Address} | Phone Number- {r.PhoneNumber} | Link- {r.Link}");
            }

            return View(Restaurants);
        }

        //displays the submission form web page
        [HttpGet]
        public IActionResult SubmissionForm()
        {
            return View();
        }

        //displays the submission form web page after submitting the form
        [HttpPost]
        public IActionResult SubmissionForm(Submission rSubmit)
        {
            SubmissionList.addSubmission(rSubmit);
            return View();
        }

        //dispalys all the user submissions web page and passes in the SubmissionList Model
        public IActionResult RestaurantSubmissions()
        {
            return View(SubmissionList.Restaurants);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
