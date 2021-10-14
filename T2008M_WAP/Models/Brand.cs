using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2008M_WAP.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}