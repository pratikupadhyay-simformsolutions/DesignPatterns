using System;
using System.ComponentModel.DataAnnotations;

namespace Saga.StockService.Data
{
    public class StockRecord
    {
        [Key]
        public int Id { get; set; }

        public int Stock { get; set; }

        public string ProductName { get; set; }
    }
}
