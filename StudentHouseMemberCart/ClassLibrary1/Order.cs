using System;
using System.Collections.Generic;

namespace BussinenssObject
{
    public partial class Order
    {
        public Order()
        {
            Payments = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int TotalServices { get; set; }
        public double? Total { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        public virtual CustomerT Customer { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
