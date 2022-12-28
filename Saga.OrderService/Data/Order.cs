using System;
using System.ComponentModel.DataAnnotations;

namespace Saga.OrderService.Data
{
    public enum OrderStatus
    {
        Pending,
        Completed,
        Rejected
    }
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public OrderStatus Status { get; set; }

        public string Product { get; set; }
    }
}
