using RestaurantReview.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantReview.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var underTest = new RestaurantController();
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
    public void Index_Passes_Restaurant_Model_Is_View()
        {
            var underTest = new RestaurantController();

            var result = underTest.Index();

            Assert.IsType <RestaurantReview.Models.Restaurant>(result.Model);
        }
    } 
}
