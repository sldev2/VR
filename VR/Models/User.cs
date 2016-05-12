using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class User
    {
        public User()
        {
            this.ClaimDatas = new List<ClaimData>();
            this.ExternalLogins = new List<ExternalLogin>();
            this.PosseMembershipDetails = new List<PosseMembershipDetail>();
            this.Roles = new List<Role>();
        }

        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public bool DontAskZipCode { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string PublicEmail { get; set; }
        public string ST { get; set; }
        public virtual ICollection<ClaimData> ClaimDatas { get; set; }
        public virtual ICollection<ExternalLogin> ExternalLogins { get; set; }
        public virtual ICollection<PosseMembershipDetail> PosseMembershipDetails { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
