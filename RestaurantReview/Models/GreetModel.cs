using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Models
{
    public class GreetModel
    {//Course model = new Course("Intro to MVC", 42, "All you need to know about MVC");
        public GreetModel(string name, int id, string details)
        {
            this.Name = name;
            this.Id = id;
            this.Details = details;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Details { get; set; }

    }
    
}
