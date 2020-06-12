using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Models;

namespace RestaurantReview.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            Restaurant model = new Restaurant("Donato's", 99, "Pretty decent pizza");
            return View(model);
        }
    }
}
