﻿using System;
using System.Collections.Generic;

namespace BussinenssObject
{
    public partial class Service
    {
        public Service()
        {
            staff = new HashSet<staff>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public int? AmountOfTime { get; set; }
        public double? Price { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
