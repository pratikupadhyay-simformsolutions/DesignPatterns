using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Saga.OrderService.Data;
using Saga.OrderService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saga.OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            await _orderService.CreateOrderAsync(order);

            return Accepted();
        }
    }
}
