using System;
using System.ComponentModel.DataAnnotations;

namespace Saga.PaymentService.Data
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
