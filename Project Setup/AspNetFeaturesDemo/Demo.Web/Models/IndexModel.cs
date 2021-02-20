using Foundation.Contexts;
using Foundation.Entities;
using Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class IndexModel
    {
        public string Name { get; set; }

        private readonly IPurchaseService _purchaseService;

        public IndexModel(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        public void Add()
        {
            _purchaseService.AddProduct(new Product
            {
                Name = Name,
                Price = 203
            });
        }
    }
}
