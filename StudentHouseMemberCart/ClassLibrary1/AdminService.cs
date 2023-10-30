using System;
using System.Collections.Generic;

namespace BussinenssObject
{
    public partial class AdminService
    {
        public int? AdminId { get; set; }
        public int? ServiceId { get; set; }
        public DateTime? LatestUpdate { get; set; }

        public virtual AdminT? Admin { get; set; }
        public virtual Service? Service { get; set; }
    }
}
