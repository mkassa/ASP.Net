using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MadamTaitu.Models.Restaurant;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MadamTaitu.ViewModels.Restaurant
{
    public class MenuModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public MenuCategories MenuCategory { get; set; }

        public virtual ICollection<MenuAttributes> MenuAttributes { get; set; }

        public string Image { get; set; }
    }
}
