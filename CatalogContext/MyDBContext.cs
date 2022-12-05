using CatalogLastApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalogApp.CatalogContext
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
      

    }
}
