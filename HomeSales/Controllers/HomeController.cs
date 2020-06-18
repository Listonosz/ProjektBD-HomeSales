using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeSales.Models;
using HomeSales.ViewModels;

namespace HomeSales.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOnSale = _productRepository.GetProductsOnSale
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
