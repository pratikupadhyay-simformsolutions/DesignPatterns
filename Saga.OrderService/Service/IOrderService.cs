using Saga.OrderService.Data;
using System.Threading.Tasks;

namespace Saga.OrderService.Service
{
    public interface IOrderService
    {
        public Task<int> CreateOrderAsync(Order order);
        public Task CompleteOrderAsync(int orderId);
        public Task RejectOrderAsync(int orderId, string reason);
    }
}
