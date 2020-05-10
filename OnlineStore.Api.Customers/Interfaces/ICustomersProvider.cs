using OnlineStore.Api.Customers.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Api.Customers.Interfaces
{
    public interface ICustomersProvider
    {
        Task<(bool IsSuccess, Customer Customer, string ErrorMessage)> GetCustomerAsync(int id);
        Task<(bool IsSuccess, IEnumerable<Customer> Customers, string ErrorMessage)> GetCustomersAsync();        
    }
}
