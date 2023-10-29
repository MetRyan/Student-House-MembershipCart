using System;
using System.Collections.Generic;

namespace BussinenssObject.Models
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

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
