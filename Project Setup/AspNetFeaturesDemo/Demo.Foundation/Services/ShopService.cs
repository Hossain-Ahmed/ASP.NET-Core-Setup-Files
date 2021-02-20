using Demo.Foundation.BusinessObjects;
using Foundation.Entities;
using Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopingUnitOfWork _shopingUnitOfWork;
        public ShopService(IShopingUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }

        public void CreateCategory(string name)
        {
            CreateCategory(new CategoryInfo
            {
                Name = name
            });
        }

        public void CreateCategory(CategoryInfo category)
        {
            if (category == null)
                throw new InvalidOperationException("Category information is missing");
            if (!category.IsValid())
                throw new InvalidOperationException("Name must be provided to create category");

            _shopingUnitOfWork.CategoryRepository.Add(new Category
            {
                Name = category.Name
            });
            _shopingUnitOfWork.Save();
        }
    }
}
