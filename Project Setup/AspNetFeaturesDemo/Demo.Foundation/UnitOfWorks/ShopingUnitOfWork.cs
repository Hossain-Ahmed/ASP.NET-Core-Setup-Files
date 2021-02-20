using DataAccessLayer;
using Demo.Foundation.Repositories;
using Foundation.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfworks
{
    public class ShopingUnitOfWork : UnitOfWork, IShopingUnitOfWork
    {
        public IProductRepository ProductRepositroy { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
        public ShopingUnitOfWork(ShopingContext context, 
            IProductRepository productRepositroy,
            ICategoryRepository categoryRepository
            )
            : base(context)
        {
            ProductRepositroy = productRepositroy;
            CategoryRepository = categoryRepository;
        }
    }
}
