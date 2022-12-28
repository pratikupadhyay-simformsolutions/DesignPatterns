using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using Saga.Events;
using Saga.PaymentService.Service;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Saga.PaymentService.Consumer
{
    public class StocksReservedEventConsumer : IConsumeAsync<StocksReservedEvent>
    {
        private readonly IPaymentService _paymentService;
        private readonly IBus _bus;

        public StocksReservedEventConsumer(IPaymentService paymentService, IBus bus)
        {
            _paymentService = paymentService;
            _bus = bus;
        }

        public async Task ConsumeAsync(StocksReservedEvent message, CancellationToken cancellationToken = default)
        {
            var isPaymentCompleted =  _paymentService.MakePayment(message.OrderId, message.TotalAmount);

            if (isPaymentCompleted > 0)
            {
                await _bus.PubSub.PublishAsync(new PaymentCompletedEvent
                {
                    OrderId = message.OrderId
                });
            }
            else
            {
                //await _bus.PubSub.PublishAsync(new PaymentRejectedEvent
                //{
                //    OrderId = message.OrderId,
                //    Reason = isPaymentCompleted.Item2
                //});
            }
        }
    }
}
