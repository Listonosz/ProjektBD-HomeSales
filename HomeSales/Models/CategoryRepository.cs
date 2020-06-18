using HomeSales.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HomeSalesDbContext _appDbContext;

        public CategoryRepository(HomeSalesDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories; //return all categories
    }
}
