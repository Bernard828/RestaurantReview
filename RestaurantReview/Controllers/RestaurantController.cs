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
    public class RestaurantController : Controller
    {

      private readonly RestaurantRepository restaurantRepository = new RestaurantRepository();


        public ViewResult Index()
        {
            
            var model = restaurantRepository.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {

            var model = restaurantRepository.GetById(id);
            return View(model);


        }

    }
}
