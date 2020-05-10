using OnlineStore.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Api.Search.Interfaces
{
    public interface ICustomerService
    {
        Task<(bool IsSuccess, dynamic Customers, string ErrorMessage)> GetCustomersAsync(int id);
    }
}
