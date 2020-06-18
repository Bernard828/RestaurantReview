using RestaurantReview.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Models
{
    public class Restaurant
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public string Details { get; set; }
        public string LinkImage { get; set; }
        public string LinkUrl { get; set; }
        public string LinkDescription { get; set; }

        

        public virtual ICollection<Review>Reviews { get;set; }



        public Restaurant(string name, int id, string details, string linkImage, string linkUrl, string linkDescription)
        {
            this.Name = name;
            this.Id = id;
            this.Details = details;
            this.LinkImage = linkImage;
            this.LinkUrl = linkUrl;
            this.LinkDescription = linkDescription;
        }

        public Restaurant()
        {
        }
    }
    
}
