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
        public List<RestaurantReview.Models.Restaurant> restaurants;

        public RestaurantRepository()
        {
            restaurants = new List<Restaurant>();
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.FirstOrDefault(x => x.Id == id);
        }
    }
}
