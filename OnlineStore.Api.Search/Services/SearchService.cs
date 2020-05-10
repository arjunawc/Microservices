using OnlineStore.Api.Search.Interfaces;
using OnlineStore.Api.Search.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Api.Search.Services
{
    public class SearchService : ISearchService
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public SearchService(IOrderService orderService, IProductService productService, ICustomerService customerService)
        {
            _orderService = orderService;
            _productService = productService;
            _customerService = customerService;
        }
        public async Task<(bool IsSuccess, dynamic SearchResults)> SearchAsync(int customerId)
        {
            var ordersResult = await _orderService.GetOrdersAsync(customerId);
            var productResult = await _productService.GetProductsAsync();
            var customerResult = await _customerService.GetCustomersAsync(customerId);

            if(ordersResult.IsSuccess)
            {
                foreach(var order in ordersResult.Orders)
                {
                    foreach(var item in order.Items)
                    {
                        item.ProductName = productResult.IsSuccess ?
                            productResult.Products.FirstOrDefault(p => p.Id == item.ProductId)?.Name :
                            "Product information is not available";
                    }                    
                }

                var result = new
                {
                    Customer = customerResult.IsSuccess ?
                                    customerResult.Customers :
                                    new { Name = "Customer information is not available" },
                    Orders = ordersResult.Orders
                };

                return (true, result);
            }

            return (false, null);
        }
    }
}
