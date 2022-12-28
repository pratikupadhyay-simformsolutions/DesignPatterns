using Saga.StockService.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Saga.StockService.Service
{
    public interface IStockService
    {
        public Task<bool> ReserveStocksAsync(string product, int orderId);

        public Task<IEnumerable<StockRecord>> GetAll();
    }
}
