﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Admin :ApplicationUser
    {
        public virtual ICollection<Product> Products { get; set; }

    }
}