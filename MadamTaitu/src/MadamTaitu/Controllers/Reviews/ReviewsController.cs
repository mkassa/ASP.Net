using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MadamTaitu.Models;
using MadamTaitu.DAL;
using Newtonsoft.Json;

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

            //var reviews = new List<Review> {
            //    new Review() { Name="Michael", Comment="Lovely atmospher, great food and service!", Rating=5, AddedDate=new DateTime(2016, 06, 03)}
            //    ,new Review() { Name="Solomon", Comment="Fantastic place....", Rating=3, AddedDate=new DateTime(2015, 06, 01)}
            //    ,new Review() { Name="Kifle", Comment="Delicious food!", Rating=4, AddedDate=new DateTime(2016, 06, 01)}
            //};

            var reviews = _dbContext.Reviews.OrderBy(foo => foo.AddedDate).ToList();

            return Json(reviews);

        }

        [HttpPost("api/reviews/add")]
        public JsonResult AddReview([FromBody]dynamic review)
        {
            var newReview = JsonConvert.DeserializeObject<Review>(review.ToString());

            newReview.AddedDate = DateTime.Now;
            //_dbContext.Reviews.Add(newReview);
            //_dbContext.SaveChanges();

            return Json(newReview);
        }

        public IActionResult Reviews()
        {   
            return View();
        }
    }
}
