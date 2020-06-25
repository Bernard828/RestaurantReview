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

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {

            review.ReviewDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                reviewRepo.Create(review);
                return RedirectToAction("Details", "Restaurant", new { id = review.RestaurantId});
            }
           
            return View(review);
        }

        [HttpGet]
        public ViewResult CreateByRestaurantId(int id)
        {
            ViewBag.RestaurantId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Update(Review review)
        {

            review.ReviewDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                reviewRepo.Update(review);
                return RedirectToAction("Index");
            }

            return View(review);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Review review = reviewRepo.GetById(id);
            review.ReviewDate = DateTime.Now;
            return View(review);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {


            if (ModelState.IsValid)
            {
                reviewRepo.Delete(review);
                return RedirectToAction("Details", "Restaurant", new { id = review.RestaurantId });
            }

            return View(review);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Review review = reviewRepo.GetById(id);
            return View(review);
        }
    }
}
