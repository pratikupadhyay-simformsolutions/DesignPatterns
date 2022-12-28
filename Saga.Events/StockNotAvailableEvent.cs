using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saga.Events
{
    public class StockNotAvailableEvent
    {
        public string Product { get; set; }
        public int OrderId { get; set; }
    }
}
