using DataAccessLayer;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfworks
{
    public interface IShopingUnitOfWork : IUnitOfWork
    {
        IProductRepository ProductRepositroy { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
    }
}
