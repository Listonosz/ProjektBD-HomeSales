﻿using HomeSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOnSale { get; set; }
    }
}
