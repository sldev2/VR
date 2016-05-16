using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Target_TemplateInfo
    {
        public string Name { get; set; }
        public string Party { get; set; }
        // TODO ADD
        public string StateName { get; set; }        
        // TODO ADD
        public string StateAbbreviation { get; set; }
        public string Region { get; set; }
        public bool IsIncumbent { get; set; }
        public bool IsActive { get; set; }
        public int GovernmentLevelId { get; set; }
        public int HouseId { get; set; }
        public System.DateTime GeneralElectionDate { get; set; }
        public System.DateTime PrimaryDate { get; set; }
        public Nullable<System.DateTime> ConventionDate { get; set; }
        public bool IsBadOnTPP { get; set; }
        public bool IsGoodOnTPP { get; set; }
        public string TPPGoodBadReason { get; set; }
    }
}
