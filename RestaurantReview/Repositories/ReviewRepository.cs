using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private RestaurantContext db;
        public ReviewRepository(RestaurantContext db)
        {
            this.db = db;
        }

        
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }
        public Review GetById(int id)
        {
            return db.Reviews.Single(c => c.Id == id); 
        }


        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void Update(Review review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }

        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }
    }
}
