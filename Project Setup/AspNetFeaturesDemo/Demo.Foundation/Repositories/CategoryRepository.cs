using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class CategoryRepository : Repository<Category, int, ShopingContext>, ICategoryRepository
    {
        public CategoryRepository(ShopingContext dbContext)
            : base(dbContext)
        {

        }
    }
}
