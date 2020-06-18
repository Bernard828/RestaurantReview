using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  RestaurantReview.Models;
using RestaurantReview.Repositories;

 
namespace RestaurantReview.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public ViewResult Index()
        {

            var model = reviewRepo.GetAll();

            return View(model);

        }
        public ViewResult Details(int id)
        {

            var model = reviewRepo.GetById(id);

            return View(model);
        }
    }
}
