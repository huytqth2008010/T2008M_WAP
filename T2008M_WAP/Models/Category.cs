﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2008M_WAP.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
        
}