using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Threading.Tasks;

namespace RestaurantReview.Repositories
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        //public List<RestaurantReview.Models.Restaurant> restaurants;

        private RestaurantContext db;

        public RestaurantRepository(RestaurantContext otherDb)
        {
            this.db = otherDb;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants.ToList();
        }

        public Restaurant GetById(int id)
        {
            return db.Restaurants.FirstOrDefault(x => x.Id == id);
        }


        public void Create(Restaurant obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant obj)
        {
            throw new NotImplementedException();
        }
        public void Delete(Restaurant obj)
        {
            throw new NotImplementedException();
        }

    }
}
