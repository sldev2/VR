using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VR.Models
{
    public class RootViewModel
    {
        public List<Target_TemplateInfo> Target_TemplateInfos {get; set;}
        public List<PrezCampaignViewModel> PrezCampaignViewModels { get; set; }
        public List<PrezCampaignViewModel> CongressCampaignViewModels { get; set; } 

        public RootViewModel()
	    {
            Target_TemplateInfos = new List<Target_TemplateInfo>();
            PrezCampaignViewModels = new List<PrezCampaignViewModel>();
            CongressCampaignViewModels = new List<PrezCampaignViewModel>();
	    }
    }




    public class PrezCampaignViewModel
    {
        public PrezCampaignViewModel()
        {
            this.PrezCampaignPhaseViewModels = new List<PrezCampaignPhaseViewModel>();
            this.PrimaryDate = null;  // use Convention Date for Prez campaigns
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
        public Nullable<System.DateTime> PrimaryDate { get; set; }
        public Nullable<System.DateTime> ConventionDate { get; set; }
        public System.DateTime GeneralDate { get; set; }

        public string TargetMacroRegion { get; set; }
        public string TargetElectoralRegionName { get; set; }
        public string TargetElectoralRegionAbbreviation { get; set; }
        public virtual ICollection<PrezCampaignPhaseViewModel> PrezCampaignPhaseViewModels { get; set; }
        public virtual Poss Poss { get; set; }
    }




    public class PrezCampaignPhaseViewModel
    {
        public int Number { get; set; }
        public string Redline { get; set; }
        public string RegionName {get; set;}
        public string RegionAbbreviation {get; set;}
        public DateTime PrimaryDate { get; set; }
        public DateTime GeneralDate { get; set; }
        public DateTime PledgeDeadline {get; set;}
        public DateTime PledgeFulfillmentDeadline { get; set; }
        public DateTime EndDate { get; set; }
    }



    public class PrezCampaignStateParticulars
    {
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }
        public DateTime RepubConventionDate 
        { 
            get
            {
                return new DateTime(2016, 7, 18);
            }
            
        }
        public DateTime DemConventionDate
        {
            get
            {
                return new DateTime(2016, 7, 25);
            }

        }
        public DateTime GreenConventionDate
        {
            get
            {
                return new DateTime(2016, 8, 6);
            }

        }
        public DateTime PrimaryDate { get; set; }
        //public DateTime PhasePledgeDeadline { get; set; }
        //public DateTime PhasePledgeFulfillmentDeadline { get; set; }
        //public DateTime PhaseEndDate { get; set; }


    }




}