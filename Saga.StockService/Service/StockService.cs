using EasyNetQ;
using Microsoft.EntityFrameworkCore;
using Saga.Events;
using Saga.StockService.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saga.StockService.Service
{
    public class StockService : IStockService
    {
        private readonly IBus _bus;
        private readonly AppDbContext _context;

        public StockService(IBus bus, AppDbContext context)
        {
            _bus = bus;
            _context = context;
        }

        public async Task<IEnumerable<StockRecord>> GetAll()
        {
            return await _context.StockRecords.ToListAsync();
        }

        public async Task<bool> ReserveStocksAsync(string product, int orderId)
        {
            var stockRecord = _context.StockRecords.FirstOrDefault(x => x.ProductName == product);
            if (stockRecord == null || stockRecord.Stock == 0)
            {
                await _bus.PubSub.PublishAsync(new StockNotAvailableEvent
                {
                    Product = product,
                    OrderId = orderId
                });
                return false;
            }
            else
            {
                stockRecord.Stock -= 1;
                _context.StockRecords.Update(stockRecord);
                await _context.SaveChangesAsync();
                return true;
            }
        }
    }
}
