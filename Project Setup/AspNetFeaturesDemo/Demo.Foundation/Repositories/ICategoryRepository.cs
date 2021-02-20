using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public interface ICategoryRepository : IRepository<Category, int, ShopingContext>
    {
    }
}
