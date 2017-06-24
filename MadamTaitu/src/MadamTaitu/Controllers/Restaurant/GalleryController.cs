using MadamTaitu.DAL;
using MadamTaitu.Models.Restaurant;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Controllers.Restaurant
{
    public class GalleryController: MadamTaituController
    {
        public GalleryController(ApplicationDbContext applicationDbContext): base(applicationDbContext)
        {
        }

        public IActionResult Gallery()
        {

            return View();
        }

        [HttpGet("api/gallery")]
        public JsonResult Get()
        {
            List<Gallery> galleries = new List<Gallery>();
            for (int i = 0; i < 24; i++)
            {
                galleries.Add(new Gallery() {Id= i, Image= @"/images/menus/tibs.jpg" });
            }

            return Json(galleries);

        }
    }
}
