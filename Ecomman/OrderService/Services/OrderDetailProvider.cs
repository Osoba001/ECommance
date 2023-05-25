using Dapper;
using Ecomman.Models;
using Microsoft.Data.SqlClient;

namespace OrderService.Services
{
    public class OrderDetailProvider : IOrderDetailProvider
    {
        private readonly string connStrng;

        public OrderDetailProvider(string connStrng)
        {
            this.connStrng = connStrng;
        }
        public OrderDetail[] Get()
        {
            using var connection = new SqlConnection(connStrng);
            connection.Open();
            return connection.Query<OrderDetail>(@"Select u.[Name] as [User], p.[Name] as [Name], od.Quantity as [Quantity] from [Order] as o
        Join [OrderDetail] od on o.Id=od.OrderId
		Join [Product] p on od.ProductId=p.Id
		Join [User] u on o.UserId=u.Id").ToArray();
        }
    }
}
