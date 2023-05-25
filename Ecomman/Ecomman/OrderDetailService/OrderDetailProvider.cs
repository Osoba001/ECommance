
using Ecomman.Models;
using Newtonsoft.Json;

namespace Ecomman.OrderDetailService
{
    public class OrderDetailProvider : IOrderDetailProvider
    {
        private readonly HttpClient httpClient;

        public OrderDetailProvider(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<OrderDetail[]> Get()
        {
            var response = await httpClient.GetAsync("api/OrderDetail");
            var result = await response.Content.ReadFromJsonAsync<OrderDetail[]>()?? Array.Empty<OrderDetail>();
            return result;
        }
    }
}
