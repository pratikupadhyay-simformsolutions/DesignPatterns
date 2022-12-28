using EasyNetQ.AutoSubscribe;
using Saga.Events;
using Saga.OrderService.Service;
using System.Threading;
using System.Threading.Tasks;

namespace Saga.OrderService.Consumer
{
    public class StocksReleasedEventConsumer : IConsumeAsync<StocksReleasedEvent>
    {
        private readonly IOrderService _orderService;

        public StocksReleasedEventConsumer(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task ConsumeAsync(StocksReleasedEvent message, CancellationToken cancellationToken = default)
        {
            await _orderService.RejectOrderAsync(message.OrderId, message.Reason);
        }
    }
}
