using OnlineStore.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Api.Search.Interfaces
{
    public interface IProductService
    {
        Task<(bool IsSuccess, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();
    }
}
