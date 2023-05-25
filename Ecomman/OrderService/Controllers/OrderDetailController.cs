using Ecomman.Models;
using Microsoft.AspNetCore.Mvc;
using OrderService.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailProvider orderDetailProvider;

        public OrderDetailController(IOrderDetailProvider orderDetailProvider)
        {
            this.orderDetailProvider = orderDetailProvider;
        }
        // GET: api/<OrderDetailController>
        [HttpGet]
        public IEnumerable<OrderDetail> Get()
        {
            return orderDetailProvider.Get();
        }
    }
}
