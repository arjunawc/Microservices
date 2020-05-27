using Microsoft.Extensions.Logging;
using System.Linq;

namespace OnlineStore.Api.Customers.Db
{
    public class CustomerDbContextSeed
    {
        public static void SeedData(CustomerDbContext context, ILoggerFactory loggerFactory)
        {
            if (!context.Customers.Any())
            {
                context.Customers.Add(new Customer() { Id = 1, Name = "Arjuna", Address = "Glenfield" });
                context.Customers.Add(new Customer() { Id = 2, Name = "Dilani", Address = "Newmarket" });
                context.Customers.Add(new Customer() { Id = 3, Name = "Jason", Address = "Glen Eden" });
                context.Customers.Add(new Customer() { Id = 4, Name = "Brandon", Address = "Mount Wellington" });

                context.SaveChanges();
            }
        }
    }
}
