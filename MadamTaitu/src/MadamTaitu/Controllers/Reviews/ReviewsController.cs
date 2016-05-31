using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MadamTaitu.Models;
using MadamTaitu.DAL;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MadamTaitu.Controllers.Reviews
{
    
    public class ReviewsController : Controller
    {
        private ApplicationDbContext _dbContext;

        public ReviewsController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet("api/reviews")]
        public JsonResult Get()
        {

            var reviews =  new List<Review> {
                new Review() { ReviewerName="Michael", ReviewText="Lovely atmospher, great food and service!", Rating=5}
                ,new Review() { ReviewerName="Solomon", ReviewText="Fantastic place....", Rating=5}
                ,new Review() { ReviewerName="Kifle", ReviewText="Delicious food!", Rating=5}
            };

            return Json(reviews);

        }

        public IActionResult Reviews()
        {   
            return View();
        }
    }
}
