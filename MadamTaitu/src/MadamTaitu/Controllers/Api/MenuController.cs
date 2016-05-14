using MadamTaitu.Models;
using MadamTaitu.Models.Restaurant;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Controllers.Api
{
    public class MenuController : Controller
    {
        private ApplicationDbContext _dbContext;

        public MenuController(ApplicationDbContext applicationDbContext)
        {
            this._dbContext = applicationDbContext;
        }


        [HttpGet("api/Menu")]
        public JsonResult Get()
        {
             var menus = new List<Menu> {
                new Menu() { Name="Tibs", Description="Lean meat roasted with chillies and green paper", Image="/images/menus/tibs.jpg", Price=60}
                ,new Menu() { Name="Dero", Description="beef roasted with chillie papers andlots onions", Image="/images/menus/dero.jpg", Price=70}
                ,new Menu() { Name="Beyeayinetu", Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
            };

            return Json(menus);

        }

        public IActionResult Menu()
        {
               
            return View();
        } 
    }
}
