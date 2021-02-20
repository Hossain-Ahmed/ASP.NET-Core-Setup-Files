using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfWorks
{
    public class ShopingUnitOfWork : UnitOfWork, IShopingUnitOfWork
    {
        public IProductRepository ProductRepositroy { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }

        public ShopingUnitOfWork(ShopingContext context, 
            IProductRepository productRepositroy,
            ICustomerRepository customerRepository)
            : base(context)
        {
            ProductRepositroy = productRepositroy;
            CustomerRepository = customerRepository;
        }
    }
}
