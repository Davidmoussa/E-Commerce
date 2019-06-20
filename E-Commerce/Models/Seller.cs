using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Seller :ApplicationUser
    {
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Discount> discounts { get; set; }

    }
}