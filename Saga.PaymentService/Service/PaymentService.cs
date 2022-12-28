using EasyNetQ;
using Saga.PaymentService.Data;
using System.Threading.Tasks;

namespace Saga.PaymentService.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IBus _bus;
        private readonly AppDbContext _context;

        public PaymentService(IBus bus, AppDbContext context)
        {
            _bus = bus;
            _context = context;
        }
        public int MakePayment(int orderId, decimal totalAmount)
        {
            var payment = new Payment()
            {
                OrderId = orderId,
                TotalAmount = totalAmount
            };
            _context.Payments.Add(payment);
            return _context.SaveChanges();
        }
    }
}
