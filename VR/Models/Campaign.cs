using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Campaign
    {
        public Campaign()
        {
            this.CampaignPhases = new List<CampaignPhase>();
        }

        public int Id { get; set; }
        public bool IsMultiphasic { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public int PosseId { get; set; }
        public string UltimateRedline { get; set; }
        public string Info { get; set; }
        public bool IsPresidential { get; set; }
        public Nullable<int> ElectionYear { get; set; }
        public System.DateTime PrimaryDate { get; set; }
        public System.DateTime GeneralDate { get; set; }
        public string TargetMacroRegion { get; set; }
        public string TargetElectoralRegionName { get; set; }
        public string TargetElectoralRegionAbbreviation { get; set; }
        public virtual ICollection<CampaignPhase> CampaignPhases { get; set; }
        public virtual Poss Poss { get; set; }
    }
}
