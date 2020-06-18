using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeSales.Models;

namespace HomeSales.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }

    }
}
