using HomeSales.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly HomeSalesDbContext _homeSalesDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(HomeSalesDbContext homeSalesDbContext, ShoppingCart shoppingCart)
        {
            _homeSalesDbContext = homeSalesDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _homeSalesDbContext.Add(order);
            _homeSalesDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Product.Price,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = order.OrderId
                };

                _homeSalesDbContext.OrderDetails.Add(orderDetail);

            }

            _homeSalesDbContext.SaveChanges();
        }
    }
}
