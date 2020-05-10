using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Api.Products.Db
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
