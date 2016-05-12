using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Opponent
    {
        public Opponent()
        {
            this.Targets = new List<Target>();
        }

        public int Id { get; set; }
        public string CampaignUrl { get; set; }
        public int CountryId { get; set; }
        public int GovernmentLevelId { get; set; }
        public int HouseId { get; set; }
        public string Name { get; set; }
        public System.DateTime GeneralElectionDate { get; set; }
        public string Region { get; set; }
        public bool IsActive { get; set; }
        public string Party { get; set; }
        public Nullable<System.DateTime> WithdrawalDate { get; set; }
        public virtual Country Country { get; set; }
        public virtual GovernmentLevel GovernmentLevel { get; set; }
        public virtual House House { get; set; }
        public virtual ICollection<Target> Targets { get; set; }
    }
}
