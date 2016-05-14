using MadamTaitu.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Models.Restaurant 
{
    public  class Menu 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        
        public MenuCategories MenuCategory { get; set; }

        public virtual ICollection<MenuAttributes> MenuAttributes { get; set; }
        
        public string Image { get; set; }

        public decimal Price { get; set; }
    }
}
