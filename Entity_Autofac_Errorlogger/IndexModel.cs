using Foundation.Entities;
using Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFile.Models
{
    public class IndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        private readonly IPurchaseService _purchaseService;


        public IndexModel(IPurchaseService purchaseService)
        {
            
            _purchaseService = purchaseService;
        }
        public void Add()
        {
            _purchaseService.Purchase(new Product
            {
                Name = "Soap",
                Price = 99
            },
            new Customer
            {
                Name ="Rashed Bean Nayem",
                Email = "abc@gmail.com",
                IsActive = true,
                Username = "rashedNayem",
                Password = "itsOk",
                PasswordSalt = "123456789",
                RegisterDate = DateTime.Now
            });
        }
    }
}
