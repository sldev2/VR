using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class ClaimData
    {
        public int ClaimId { get; set; }
        public System.Guid UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public virtual User User { get; set; }
    }
}
