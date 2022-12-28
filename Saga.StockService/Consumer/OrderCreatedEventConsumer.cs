using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using Saga.Events;
using Saga.StockService.Service;
using System.Threading;
using System.Threading.Tasks;

namespace Saga.StockService.Consumer
{
    public class OrderCreatedEventConsumer : IConsumeAsync<OrderCreatedEvent>
    {
        private readonly IStockService _stockService;
        private readonly IBus _bus;

        public OrderCreatedEventConsumer(IStockService stockService, IBus bus)
        {
            _stockService = stockService;
            _bus = bus;
        }

        public async Task ConsumeAsync(OrderCreatedEvent message, CancellationToken cancellationToken = default)
        {
            var reserved = await _stockService.ReserveStocksAsync(message.Product, message.OrderId);
            if (reserved)
            {
                await _bus.PubSub.PublishAsync(new StocksReservedEvent
                {
                    OrderId = message.OrderId,
                    TotalAmount = message.TotalAmount
                });
            }
        }
    }
}
