using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Threading.Tasks;

namespace RestaurantReview.Repositories
{
    public class RestaurantRepository
    {
        public List<RestaurantReview.Models.Restaurant> restaurants;

        public RestaurantRepository()
        {
            restaurants = new List<Models.Restaurant>();
            restaurants.Add(new Models.Restaurant("Donato's", 1,"Great pizza place", "images/Donatos-Pizza-restaurant-1200x900.jpg", "https://www.donatos.com", "Donatos Image"));
            restaurants.Add(new Models.Restaurant("Agave", 2, "Like chipotle but 10x better"), image, https://www.facebook.com/agaveburritobar/ , "Agave Image);
            restaurants.Add(new Models.Restaurant("Pier W", 3, "Great seafood", image, http://pierw.com/, "Pier W Image");
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}
