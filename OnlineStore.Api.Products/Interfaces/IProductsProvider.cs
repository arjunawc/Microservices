using OnlineStore.Api.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Api.Products.Interfaces
{
    public interface IProductsProvider
    {
        Task<(bool IsSuccess, Product Product, string ErrorMessage)> GetProductAsync(int id);
        Task<(bool IsSuccess, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();        
    }
}
