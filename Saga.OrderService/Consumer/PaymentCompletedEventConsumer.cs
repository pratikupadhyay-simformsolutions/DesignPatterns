using EasyNetQ.AutoSubscribe;
using Saga.Events;
using Saga.OrderService.Service;
using System.Threading;
using System.Threading.Tasks;

namespace Saga.OrderService.Consumer
{
    public class PaymentCompletedEventConsumer : IConsumeAsync<PaymentCompletedEvent>
    {
        private readonly IOrderService _orderService;

        public PaymentCompletedEventConsumer(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task ConsumeAsync(PaymentCompletedEvent message, CancellationToken cancellationToken = default)
        {
            await _orderService.CompleteOrderAsync(message.OrderId);
        }
    }
}
