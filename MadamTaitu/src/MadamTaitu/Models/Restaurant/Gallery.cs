﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Models.Restaurant
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Image { get; set; }

        public decimal Price { get; set; }
        
    }
}
