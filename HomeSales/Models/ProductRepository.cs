using HomeSales.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly HomeSalesDbContext _appDbContext;
         
        public ProductRepository(HomeSalesDbContext appdbContext)
        {
            _appDbContext = appdbContext;
        }

        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return _appDbContext.Products.Include(cat => cat.Category);
            }
        }

        public IEnumerable<Product> GetProductsOnSale
        {
            get
            {
                return _appDbContext.Products.Include(cat => cat.Category).Where(state => state.IsOnSale);
            }
        }

        public Product GetProductById(int _productId)
        {
            return _appDbContext.Products.FirstOrDefault(product => product.ProductId == _productId);
        }

}
}
