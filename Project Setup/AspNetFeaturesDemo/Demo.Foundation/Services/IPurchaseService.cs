using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public interface IPurchaseService
    {
        IList<Product> GetProducts();
        void AddProduct(Product product);
    }
}
