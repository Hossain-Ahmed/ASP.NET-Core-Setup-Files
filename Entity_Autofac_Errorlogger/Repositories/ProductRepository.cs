using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Foundation.Contexts;
using DataAccessLayer;
using Foundation.Entities;

namespace Foundation.Repositories
{
    public class ProductRepository : Repository<Product, int, ShopingContext>, IProductRepository
    {
        public ProductRepository(ShopingContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Product> GetLatestProducts()
        {
            throw new NotImplementedException();
        }
    }
}
