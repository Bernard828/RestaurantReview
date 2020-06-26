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


        IRepository<Restaurant> restRepo;

        public RestaurantController(IRepository<Restaurant> restRepo)
        {
            this.restRepo = restRepo;
        }

        public ViewResult Index()
        {
           //Use our repo that is on line 17
            var model = restRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            //Use our repo that is on line 17
            var model = this.restRepo.GetById(id);
            return View(model);


        }

    }
}
