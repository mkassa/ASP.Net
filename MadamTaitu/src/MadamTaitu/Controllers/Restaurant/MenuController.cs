using MadamTaitu.DAL;
using MadamTaitu.Models;
using MadamTaitu.Models.Restaurant;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Controllers.Restaurant
{   
    public class MenuController : MadamTaituController
    {

        public MenuController(ApplicationDbContext applicationDbContext): base(applicationDbContext)
        {
        }


        [HttpGet("api/Menu")]
        public JsonResult Get()
        {
             var menus = new List<Menu> { 
                 new Menu() { Name="Key wot", OrderId=1,  MenuCategory= MenuCategories.MeatDishes, Description="Key Wat is an Ethiopian beef stew/curry, it has a powerful flavor and goes best with the traditional injera Special Ingredients: Ethiopian Clarified Butte and Caramelize onions with Berbere Sauce slow cooked", Image=" /images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Alcha wot",OrderId=2,  MenuCategory= MenuCategories.MeatDishes, Description="Alicha Sega Wot (Mild Beef Stew) is a traditional Ethiopian for a classic stew of beef, onions and oil in a mildly-spiced base.", Image="/images/menus/tibs.jpg", Price=60}
                ,new Menu() { Name="Tibs", OrderId=3, MenuCategory= MenuCategories.MeatDishes,Description="Chopped lean beef topped with ethiopian berbere, grilled with onion, green pepper,rosemary and fresh tomato.", Image="/images/menus/tibs.jpg", Price=60}
                ,new Menu() { Name="Gored gored", OrderId=4, MenuCategory= MenuCategories.MeatDishes, Description="Fresh tender lean beef cubes sautéed in Awaze s (paste of special blend of Ethiopian spices made with berbere)mitmita.Cooked rare, med, served with ethiopian Injera and salad.", Image="/images/menus/dero.jpg", Price=70}
                ,new Menu() { Name="Kitfo", OrderId=5, MenuCategory= MenuCategories.MeatDishes, Description="Very lean beef, chopped then warmed Ethiopian spiced butter, rare or meduim cooked,served with cottage cheese and selata on EthiopianInjera", Image="/images/menus/tibs.jpg", Price=60}
                ,new Menu() { Name="Dero", OrderId=6, MenuCategory= MenuCategories.MeatDishes, Description="Exquisitely flavoured and spiced chicken slowly simmered in Berbere sauce and authentic Ethiopian spices, served with hard boiled egg", Image="/images/menus/dero.jpg", Price=70}

                ,new Menu() { Name="Misto", OrderId=7, MenuCategory=MenuCategories.MeatDishes, Description="Portions of key wot and Alcha wot served together", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Sergenya", OrderId=8, MenuCategory=MenuCategories.MeatDishes, Description="A typical Ethiopian festive platter consisting portions of all our dishes", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Misto", OrderId=9, MenuCategory=MenuCategories.MeatDishes, Description="( Portions of key wot and Alcha wot served together)", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Meat platter", OrderId=10, MenuCategory=MenuCategories.MeatDishes, Description="( Portions of key wot and Alcha wot served together)", Image="/images/menus/beyeayinety.jpg", Price=80}

                ,new Menu() { Name="Tibs with veggies", OrderId=11,  MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Lamb Tibs", OrderId=12, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Lamb Tibs with veggies", OrderId=13, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Tibs with spinach and couscous", OrderId=14, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Lamb Tibs with Spinach and Couscus", OrderId=15, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Alcha with couscous", OrderId=16, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Alcha with veggie", OrderId=17, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Doro with couscous", OrderId=18, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Key wot with veggies and couscous", OrderId=19, MenuCategory=MenuCategories.MeatDishes, Image="/images/menus/beyeayinety.jpg", Price=80}

                ,new Menu() { Name="Atkilt", OrderId=1, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Gomen", OrderId=2, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Kik Alcha wot", OrderId=3,MenuCategory=MenuCategories.Vegiterian,  Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Misir Key wot", OrderId=4, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Shiro wot", OrderId=5, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Veggie sampler", OrderId=6, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Atkilt with Misir", OrderId=7, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Kik Alcha with Misir", OrderId=8, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Gomen with Atkilt", OrderId=9, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Atkilt with couscous", OrderId=10, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Gomen with couscous", OrderId=11, MenuCategory=MenuCategories.Vegiterian, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="plain Injera available on order", OrderId=12, MenuCategory=MenuCategories.Vegiterian, Description="Please place your order a day in advance", Image="/images/menus/beyeayinety.jpg", Price=80}


                ,new Menu() { Name="Chocolate mousse", OrderId=1, MenuCategory=MenuCategories.Desert, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Fruit salad", OrderId=2, MenuCategory=MenuCategories.Desert, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Fruit salad with yoghurt", OrderId=3, MenuCategory=MenuCategories.Desert, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}
                ,new Menu() { Name="Ice cream", OrderId=4, MenuCategory=MenuCategories.Desert, Description="A mix of all sorts of vegetables", Image="/images/menus/beyeayinety.jpg", Price=80}


            };

            return Json(menus.OrderBy(m=>(int)m.MenuCategory).ThenBy(m=>m.OrderId));

        }


        public IActionResult Menu()
        {
               
            return View();
        } 
    }
}
