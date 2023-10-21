using System;
using System.Collections.Generic;

namespace BussinenssObject.Models
{
    public partial class StaffOrderManagement
    {
        public int OrderId { get; set; }
        public int StaffId { get; set; }
        public DateTime? DateShipping { get; set; }
    }
}
