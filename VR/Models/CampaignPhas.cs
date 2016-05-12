using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class CampaignPhas
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Redline { get; set; }
        public Nullable<int> Campaign_Id { get; set; }
        public Nullable<System.DateTime> VoteslingerPrimaryDeadline { get; set; }
        public Nullable<System.DateTime> VoteslingerGeneralDeadline { get; set; }
        public System.DateTime PledgeDeadline { get; set; }
        public System.DateTime PledgeFulfillmentDeadline { get; set; }
        public System.DateTime EndDate { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}
