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
                    Details = "Donatos is a family-owned pizza company famous for Edge to Edge® toppings on a crispy golden thin crust. Founded in Columbus, Ohio in 1963, we take pride in giving back in every community we serve.",
                    LinkImage = "./images/Donatos-Pizza-restaurant-1200x900.jpg",
                    LinkUrl = "https://www.donatos.com",
                    LinkDescription = "Donatos Image"

                },

                new Restaurant()
                {
                    Name = "Agave",
                    Id = 2,
                    Details = "An Oberlin staple since 2003, Agave is the spot for fresh Mexi-Cali quick-serve cuisine, exceptional margaritas and draft beer!",
                    LinkImage = "./images/agave.jpg",
                    LinkUrl = "https://www.facebook.com/agaveburritobar/",
                    LinkDescription = "Agave Image"

                },

                 new Restaurant()
                 {
                     Name = "Pier W",
                     Id = 3,
                     Details = "Pier W is a landmark restaurant that has been Cleveland's premier destination for five-star dining, fresh seafood and fine wines since 1965.",
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
                    Comment = "Pepporoni Pizza is awesome. The lady at the counter was great! She tossed in some extra breadsticks because they were honoring the community that day! Thanks again Donato's i'll be back!!!",
                    ReviewDate = DateTime.Now
                },
                 new Review()
                 {
                     Id = 2,
                     RestaurantId = 1,
                     Creator = "Brenda",
                     Comment = "Whether you are traveling thru Ohio, or you live here, you have to try Donatos Pizza!Last year, I gave up on pizza, as I found all the chains to be measly with their veggies, heavy on the salt, and not so fresh. But now that I've eaten Donatos, I've changed my mind completely. Tho I order my pizza as 'takeout', the store had a nice eating area with booths. It was very clean and tidy, and it offers salads and sides. Wholesome atmosphere."
                 },
                new Review()
                {
                    Id = 3,
                    RestaurantId = 1,
                    Creator = "Corey",
                    Comment = "Hopefully the previous comments got this place in 5 star shape because I just ordered for the first time and it is delicious! I ordered a large create your own with well done instructions and it came early and perfectly done. Glad I gave them a chance. The delivery gal was super friendly too!",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 4,
                    RestaurantId = 2,
                    Creator = "Laurie",
                    Comment = "We were in town from out of state and decided to stop in for dinner. Fun atmosphere, amazing food and drinks ( loved the Pink Dragon!) I would definitely come back if I’m ever in the area. The 2 people working there were very friendly and did their job well and with smiles on their faces adding to the great atmosphere!",
                    ReviewDate = DateTime.Now
                },

                new Review()
                {
                    Id = 5,
                    RestaurantId = 2,
                    Creator = "Jay",
                    Comment = "This place might have ruined Chipotle for me. The food here is so amazing I don’t want any Mexican anywhere else again!",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 6,
                    RestaurantId = 2,
                    Creator = "Josh",
                    Comment = "We love Agave! Very family friendly, great prices, great food and nice staff! Highly recommend their queso and chips! This is a fast casual type of restaurant.",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 7,
                    RestaurantId = 3,
                    Creator = "Corey",
                    Comment = "Surprisingly, there are not many Cleveland restaurants with a good lake view, but Pier W has the best. Plus, the selections of meals for lunch are outstanding. The service was excellent and meals reasonable and filling. We enjoyed perch, salmon, scallops, The lobster bisque and manilla clam chowder were equally tasty. Our guests left satisfied and impressed with their visit to Lakewood and Pier W.",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 8,
                    RestaurantId = 3,
                    Creator = "John",
                    Comment = "Ventured to Pier W for dinner on our 22nd wedding anniversary. We were seated quickly with a waterview despite our running late. Our server was polite, knowledgeable & helpful. Our ceviche appetizer was just so-so, but the lobster bisque was delicious. Our dinners consisted of lobster pappardelle & bouillabaisse. The lobster pappardelle was done in a cream sauce that was well- balanced. The bouillabaisse was outstanding; loaded with scallops, muscles, shrimp, scallops & fish. The accompanying broth was fantastic & didn't overpower the seafood. We received a complimentary cheesecake for our anniversary that was very good & the wife took a serving of Buttercake home for good measure... and the next morning's snack.",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 9,
                    RestaurantId = 3,
                    Creator = "Dakota",
                    Comment = "I am one who doesn't complain, but when I went to Pier W I witnessed an injustice that ruined my whole experience there. I witnessed the general manager. Scream at and berate a poor teenage busser for not moving a chair down to a table fast enough for his liking. Then the man noticed us watching him. He approached our table right by the stars. My girlfriend and I felt awkward after seeing this man throw a tempertantrum, come up to us calmly and ask us how our dinner is going. After a awkward conversation that lasted way to long with him, he walked away. 20 mins after he was screaming at someone in his headset. Nice restaurant, bad manager!!!",
                    ReviewDate = DateTime.Now,
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
