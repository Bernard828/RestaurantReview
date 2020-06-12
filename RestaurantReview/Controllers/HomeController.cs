using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RestaurantReview.Models;
using RestaurantReview.Repositories;

namespace RestaurantReview.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            //Restaurant model = new Restaurant("Donato's", 99, "Pretty decent pizza");
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            var model = restaurantRepository.GetAll();
            return View(model);
        }
    }
}
