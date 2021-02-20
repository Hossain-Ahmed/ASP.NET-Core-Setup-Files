using Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Foundation.Contexts
{
    public interface IShopingContext
    {
        DbSet<Category> Category { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<ProductCategory> ProductCategory { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<Product> Products { get; set; }
    }
}