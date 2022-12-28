using EasyNetQ;
using Saga.Events;
using Saga.OrderService.Data;
using System.Threading.Tasks;

namespace Saga.OrderService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IBus _bus;
        private readonly AppDbContext _context;

        public OrderService(IBus bus, AppDbContext context)
        {
            _bus = bus;
            _context = context; 
        }

        public async Task<int> CreateOrderAsync(Order order)
        {
            order.Status = OrderStatus.Pending;
            _context.Orders.Add(order);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                var message = new OrderCreatedEvent
                {
                    OrderId = order.Id,
                    TotalAmount = order.Amount,
                    Status = order.Status.ToString(),
                    Product = order.Product
                };
                await _bus.PubSub.PublishAsync(message);
            }
            return result;
        }

        public Task CompleteOrderAsync(int orderId)
        {
            var order =  _context.Orders.Find(orderId);
            order.Status = OrderStatus.Completed;
            _context.Orders.Update(order);
             _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task RejectOrderAsync(int orderId, string reason)
        {
            var order =  _context.Orders.Find(orderId);
            order.Status = OrderStatus.Rejected;
            _context.Orders.Update(order);
             _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
