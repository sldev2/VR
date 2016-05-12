using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Target
    {
        public Target()
        {
            this.Posses = new List<Poss>();
            this.Opponents = new List<Opponent>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public int GovernmentLevelId { get; set; }
        public int HouseId { get; set; }
        public string Name { get; set; }
        public System.DateTime GeneralElectionDate { get; set; }
        public System.DateTime PrimaryDate { get; set; }
        public string Region { get; set; }
        public string Party { get; set; }
        public bool IsIncumbent { get; set; }
        public bool IsActive { get; set; }
        public virtual Country Country { get; set; }
        public virtual GovernmentLevel GovernmentLevel { get; set; }
        public virtual House House { get; set; }
        public virtual ICollection<Poss> Posses { get; set; }
        public virtual ICollection<Opponent> Opponents { get; set; }
    }
}
