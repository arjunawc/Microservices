using Microsoft.Extensions.Logging;
using System.Linq;

namespace OnlineStore.Api.Products.Db
{
    public class ProductsDbContextSeed
    {

        public static void SeedData(ProductsDbContext context, ILoggerFactory loggerFactory)
        {
            if (!context.Products.Any())
            {
                context.Products.Add(new Db.Product() { Id = 1, Name = "Keyboard", Price = 20, Inventory = 1000 });
                context.Products.Add(new Db.Product() { Id = 2, Name = "Mouse", Price = 5, Inventory = 2000 });
                context.Products.Add(new Db.Product() { Id = 3, Name = "Monitor", Price = 150, Inventory = 1500 });
                context.Products.Add(new Db.Product() { Id = 4, Name = "CPU", Price = 200, Inventory = 500 });

                context.SaveChanges();
            }
        }
    }
}
