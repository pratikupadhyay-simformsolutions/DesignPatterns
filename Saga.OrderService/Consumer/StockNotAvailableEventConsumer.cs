using EasyNetQ.AutoSubscribe;
using Saga.Events;
using Saga.OrderService.Service;
using System.Threading;
using System.Threading.Tasks;

namespace Saga.OrderService.Consumer
{
    public class StockNotAvailableEventConsumer : IConsumeAsync<StockNotAvailableEvent>
    {
        private readonly IOrderService _orderService;
        public StockNotAvailableEventConsumer(IOrderService orderService)
        {
            _orderService = orderService;   
        }
        public async Task ConsumeAsync(StockNotAvailableEvent message, CancellationToken cancellationToken = default)
        {
            await _orderService.RejectOrderAsync(message.OrderId, "Product is not in stock");
        }
    }
}
