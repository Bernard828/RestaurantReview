using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReview.Models
{
    public class Review
    {
        [Required]
        public int Id { get; set; }

        public int RestaurantId { get; set; }

        [Required]
        public string Creator { get; set; }

        [Required]
        public string Comment { get; set; }


        public DateTime ReviewDate { get; set; }


        public virtual Restaurant Restaurant { get; set; }

        public Review()
        {

        }

        public Review(int reviewID, int RestId, string UserName, string CommentDetail, DateTime EntryDate)
        {
            this.RestaurantId = RestId;
            this.Creator = UserName;
            this.Comment = CommentDetail;
            this.ReviewDate = EntryDate;
            this.Id = reviewID;
        }
    }
}
