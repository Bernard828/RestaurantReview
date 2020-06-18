using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Models
{
    public class Review
    {
        public int RestaurantId { get; set; }
        public string Creator { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public Review()
        {

        }

        public Review(int RestId, string UserName, string CommentDetail, DateTime EntryDate)
        {
            this.RestaurantId = RestId;
            this.Creator = UserName;
            this.Comment = CommentDetail;
            this.ReviewDate = EntryDate;
        }
    }
}
