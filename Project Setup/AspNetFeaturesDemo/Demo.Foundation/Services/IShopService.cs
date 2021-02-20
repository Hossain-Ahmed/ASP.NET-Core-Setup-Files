using Demo.Foundation.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IShopService
    {
        void CreateCategory(string name);
        void CreateCategory(CategoryInfo category);
    }
}
