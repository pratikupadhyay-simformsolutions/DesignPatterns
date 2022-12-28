
namespace Saga.PaymentService.Service
{
    public interface IPaymentService
    {
        public int MakePayment(int orderId, decimal totalAmount);
    }
}
