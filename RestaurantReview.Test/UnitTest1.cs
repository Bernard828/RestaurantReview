using RestaurantReview.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantReview.Test
{
    public class RestaurantReviewTest
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var underTest = new HomeController();
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
