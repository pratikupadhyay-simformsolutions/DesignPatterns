using System;

namespace Saga.Events
{
    public class StocksReleasedEvent
    {
        public int OrderId { get; set; }

        public string Reason { get; set; }
    }
}
