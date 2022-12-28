using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saga.Events
{
    public class StocksReservedEvent
    {
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
