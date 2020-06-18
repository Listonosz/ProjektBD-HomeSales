using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductsOnSale { get; }
        Product GetProductById(int _productId);

    }
}
