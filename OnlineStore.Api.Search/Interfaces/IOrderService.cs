using OnlineStore.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Api.Search.Interfaces
{
    public interface IOrderService
    {
        Task<(bool IsSuccess, IEnumerable<Order> Orders, string ErrorMessage)> GetOrdersAsync(int cutomerId);
    }
}
