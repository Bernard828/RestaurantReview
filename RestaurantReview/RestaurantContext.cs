using Microsoft.EntityFrameworkCore;
using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        // public object Review { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Restaurants;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant()
                {
                    Name = "Donato's",
                    Id = 1,
                    Details = "Great pizza place",
                    LinkImage = "./images/Donatos-Pizza-restaurant-1200x900.jpg",
                    LinkUrl = "https://www.donatos.com",
                    LinkDescription = "Donatos Image"

                    //restaurants.Add(new Models.Restaurant("Donato's", 1,"Great pizza place", "./images/Donatos-Pizza-restaurant-1200x900.jpg", "https://www.donatos.com", "Donatos Image"));
                    //restaurants.Add(new Models.Restaurant("Agave", 2, "Like chipotle but 10x better", "./images/agave.jpg", "https://www.facebook.com/agaveburritobar/", "Agave Image"));
                    //restaurants.Add(new Models.Restaurant("Pier W", 3, "Great seafood", "./images/pierW.jpg", "http://pierw.com/", "Pier W Image"));
                },

                new Restaurant()
                {
                    Name = "Agave",
                    Id = 2,
                    Details = "Like chipotle but 10x better",
                    LinkImage = "./images/agave.jpg",
                    LinkUrl = "https://www.facebook.com/agaveburritobar/",
                    LinkDescription = "Agave Image"

                },

                 new Restaurant()
                 {
                     Name = "Pier W",
                     Id = 3,
                     Details = "Really great seafood",
                     LinkImage = "./images/pierW.jpg",
                     LinkUrl = "http://pierw.com/",
                     LinkDescription = "Pier W Image",
                 });

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    RestaurantId = 1,
                    Creator = "Bernard",
                    Comment = " Pepporoni Pizza is awesome",
                    ReviewDate = DateTime.Now
                },
                 new Review()
                 {
                     Id = 2,
                     RestaurantId = 1,
                     Creator = "Brenda",
                     Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                     ReviewDate = DateTime.Now
                 },
                new Review()
                {
                    Id = 3,
                    RestaurantId = 1,
                    Creator = "Corey",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 4,
                    RestaurantId = 2,
                    Creator = "Laurie",
                    Comment = " Their burritos were great!",
                    ReviewDate = DateTime.Now
                },

                new Review()
                {
                    Id = 5,
                    RestaurantId = 2,
                    Creator = "Jay",
                    Comment = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 6,
                    RestaurantId = 2,
                    Creator = "Josh",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 7,
                    RestaurantId = 3,
                    Creator = "Corey",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 8,
                    RestaurantId = 3,
                    Creator = "John",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 9,
                    RestaurantId = 3,
                    Creator = "Dakota",
                    Comment = "The seafood here is pretty ok for Lake Erie",
                    ReviewDate = DateTime.Now,
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
