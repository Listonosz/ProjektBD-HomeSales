using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeSales.Models;
using HomeSales.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeSales.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int ProductId)
        {
            var selectedProduct = _productRepository.GetAllProducts.FirstOrDefault(c => c.ProductId == ProductId);

            if(selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int ProductId)
        {
            var selectedProduct = _productRepository.GetAllProducts.FirstOrDefault(c => c.ProductId == ProductId);

            if (selectedProduct != null)
            {
               _shoppingCart.RemoveFromCart(selectedProduct);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}