using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class PosseMembershipDetail
    {
        public PosseMembershipDetail()
        {
            this.PledgeCommitments = new List<PledgeCommitment>();
        }

        public System.Guid IdentityUserId { get; set; }
        public int PosseId { get; set; }
        public System.DateTime DateJoined { get; set; }
        public int Id { get; set; }
        public bool IsDeputy { get; set; }
        public bool IsJoiner { get; set; }
        public bool IsSheriff { get; set; }
        public bool IsSocial { get; set; }
        public int MemberType { get; set; }
        public string ReasonJoined { get; set; }
        public virtual ICollection<PledgeCommitment> PledgeCommitments { get; set; }
        public virtual Poss Poss { get; set; }
        public virtual User User { get; set; }
    }
}
