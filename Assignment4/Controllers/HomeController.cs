using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Top[] topRests = Top.GetTops();

            //rubric says to handle the dish null in the controller
            foreach (var restaurant in topRests)
            {
                if (restaurant.dish is null)
                {
                    restaurant.dish = "It's all tasty!";
                }
            }

            return View(topRests);
        }




        //add page, get and post methods
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //the post needs the form object from the html page
        [HttpPost]
        public IActionResult Add(Submission submission)
        {
            //rubric says to handle the dish null in the controller
            if (submission.dish is null)
            {
                submission.dish = "It's all tasty!";
            }
            if (ModelState.IsValid)
            {
                TempStorage.AddSubmission(submission);
            }

            return View();
        }



        //view of all submitted restaurants
        public IActionResult Submissions()
        {
            return View(TempStorage.AllSubmissions);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
