using HomeSales.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Models
{
    public class ShoppingCart
    {
        private readonly HomeSalesDbContext _HomeSalesDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(HomeSalesDbContext shopContext)
        {
            _HomeSalesDbContext = shopContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<HomeSalesDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product Product, int amount)
        {
            var shoppingCartItem = _HomeSalesDbContext.ShoppingCartItems.SingleOrDefault(
                 s => s.Product.ProductId == Product.ProductId && s.ShoppingCartId == ShoppingCartId);
            amount = 1;
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = Product,
                    Amount = amount
                };
                _HomeSalesDbContext.ShoppingCartItems.Add(shoppingCartItem);
                }
            else
            {
                shoppingCartItem.Amount++;
            }
            _HomeSalesDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product Product)
        {
            var shoppingCartItem = _HomeSalesDbContext.ShoppingCartItems.SingleOrDefault(
                 s => s.Product.ProductId == Product.ProductId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _HomeSalesDbContext.Remove(shoppingCartItem);
                }
            }
            _HomeSalesDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
            {
                return ShoppingCartItems ?? (ShoppingCartItems = _HomeSalesDbContext.ShoppingCartItems.Where
                    (c => c.ShoppingCartId == ShoppingCartId)
                    .Include(s => s.Product)
                    .ToList());
        }

        public void  ClearCart()
        {
            var cartItems = _HomeSalesDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            _HomeSalesDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _HomeSalesDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _HomeSalesDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.Amount).Sum();
            return total;
        }
    }
}
