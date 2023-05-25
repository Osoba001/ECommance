
using Ecomman.Models;
using Microsoft.Data.SqlClient;

namespace Ecomman.OrderDetailService
{
    public interface IOrderDetailProvider
    {
        Task<OrderDetail[]> Get();
    }
}
