using System;
using System.Collections.Generic;

namespace BussinenssObject.Models
{
    public partial class AdminT
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? Status { get; set; }
    }
}
