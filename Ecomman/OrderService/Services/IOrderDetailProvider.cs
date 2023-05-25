using Ecomman.Models;

namespace OrderService.Services
{
    public interface IOrderDetailProvider
    {
        OrderDetail[] Get();
    }
}
