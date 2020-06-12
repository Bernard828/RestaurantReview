using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RestaurantReview.Repositories
{
    public class RestaurantRepository
    {
        public List<RestaurantReview.Models.Restaurant> restaurants;

        public RestaurantRepository()
        {
            restaurants = new List<Models.Restaurant>();
            restaurants.Add(new Models.Restaurant("Donato's", 1, "Great pizza place"));
            restaurants.Add(new Models.Restaurant("Agave", 1, "Like chipotle but 10x better"));
            restaurants.Add(new Models.Restaurant("Pier W", 1, "Great seafood"));
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}
