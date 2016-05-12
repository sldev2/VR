using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class PledgeCommitment
    {
        public int Id { get; set; }
        public int CampaignPhaseId { get; set; }
        public System.DateTime Deadline { get; set; }
        public string PersonalPledge { get; set; }
        public int DefaultPledgeId { get; set; }
        public float SelfVerificationScore { get; set; }
        public Nullable<System.Guid> PosseMembershipDetail_IdentityUserId { get; set; }
        public Nullable<int> PosseMembershipDetail_PosseId { get; set; }
        public int PledgeType { get; set; }
        public System.DateTime FulfillmentDeadline { get; set; }
        public virtual PosseMembershipDetail PosseMembershipDetail { get; set; }
        public virtual Verification Verification { get; set; }
    }
}
