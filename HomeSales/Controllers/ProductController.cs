using HomeSales.Models;
using HomeSales.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Product> Products;
            string currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                Products = _productRepository.GetAllProducts.OrderBy(c => c.ProductId);
                currentCategory = "All Product";
            }
            else
            {
                Products = _productRepository.GetAllProducts.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c =>
                c.CategoryName == category)?.CategoryName;
            }
            return View(new ProductListViewModel
                {
                Products = Products,
                CurrentCategory = currentCategory
                });
   
        }

        public IActionResult Details(int id)
        {
            var Product = _productRepository.GetProductById(id);
            if (Product == null)
                return NotFound();
            return View(Product);
        }
    }
}
