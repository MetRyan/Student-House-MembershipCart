using System;
using System.Collections.Generic;

namespace BussinenssObject
{
    public partial class staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? Status { get; set; }
        public int? ServiceId { get; set; }
        public string Password { get; set; } = null!;
        public string? Address { get; set; }

        public virtual Service? Service { get; set; }
    }
}
