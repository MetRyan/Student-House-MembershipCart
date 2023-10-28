using System;
using System.Collections.Generic;

namespace BussinenssObject.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? OrderId { get; set; }
        public string? PaymentType { get; set; }
        public double? Price { get; set; }

        public virtual Order? Order { get; set; }
    }
}
