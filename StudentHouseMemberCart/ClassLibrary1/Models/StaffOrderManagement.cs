using System;
using System.Collections.Generic;

namespace BussinenssObject.Models
{
    public partial class StaffOrderManagement
    {
        public int OrderId { get; set; }
        public int StaffId { get; set; }
        public DateTime? Status { get; set; }

        public virtual OrderManagement Order { get; set; } = null!;
        public virtual StaffManagement Staff { get; set; } = null!;
    }
}
