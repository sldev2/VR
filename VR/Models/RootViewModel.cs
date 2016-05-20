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
        public string targetHandle { get; set; }
        public string targetName { get; set; }

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

        public string TargetRegion { get; set; }
        public string TargetStateName { get; set; }
        public string TargetStateAbbreviation { get; set; }
        public virtual ICollection<PrezCampaignPhaseViewModel> PrezCampaignPhaseViewModels { get; set; }
        public virtual Poss Poss { get; set; }
    }

    /// <summary>
    /// generic phases of a US politicians' electoral lifecycle
    /// </summary>
    public enum enumPrezGenericPhase
    {
        none,
        prePrimary,    // (s)election by primary, caucus, or convention
        // FORLATER uncomment, and code for:
        // prePrezConvention,  // only defined for US President; state level convention selection is considered .prePrimary
        preGeneral,
        preInauguration
    }

    public enum enumCongressGenericPhase
    {
        none,
        prePrimary,    // (s)election by primary, caucus, or convention
        preGeneral,
        preInauguration
    }




    //Congressional "inauguration" day is Jan 3, 2017
    public class PrezCampaignPhaseViewModel
    {
        private string uSParty;
        private DateTime primaryDate;
        public PrezCampaignPhaseViewModel(string USParty, DateTime PrimaryDate)
        {
            uSParty = USParty;
            primaryDate = PrimaryDate;
        }
        public PrezCampaignPhaseViewModel(DateTime primaryDate, DateTime generalDate, DateTime inaugurationDate, enumPrezGenericPhase genPhase, string USParty)
        {

        }

        public int Number { get; set; }
        public string Redline { get; set; }
        public string RegionName {get; set;}
        public string RegionAbbreviation {get; set;}
        public DateTime PrimaryDate
        {
            get;
            set;
            //get
            //{
            //    switch (uSParty)
            //    {
            //        case "Democratic":
            //            break;
            //        case "Republican":
            //            break;
            //        case "Green":
            //            throw new Exception("need Green party Primary Date")
            //            break;
            //    }
            //}


        }
        public DateTime GeneralDate { get { return new DateTime(2016, 11, 8); } }
        public DateTime PledgeDeadline {get; set;}
        public DateTime PledgeFulfillmentDeadline { get; set; }
        /// <summary>
        /// Date that the campaign phase ends; pledge fulfillment dates can occur after this date
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Trigger Deadline Date for Voteslinger Primary Pledges
        /// </summary>
        public DateTime VoteslingerPrimaryDeadline { get; set; }
        /// <summary>
        /// Trigger Deadline Date for Voteslinger General Election Pledges
        /// </summary>
        public DateTime VoteslingerGeneralDeadline { get; set; }
    }



    public class PrezCampaignStateParticulars
    {

        private string _party;


        public string Party 
        { 
            get; 
            set; 
        }
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }
        public DateTime ConventionDate { get; set; }
        //public DateTime RepubConventionDate 
        //{ 
        //    get
        //    {
        //        return new DateTime(2016, 7, 18);
        //    }
            
        //}
        //public DateTime DemConventionDate
        //{
        //    get
        //    {
        //        return new DateTime(2016, 7, 25);
        //    }

        //}
        //public DateTime GreenConventionDate
        //{
        //    get
        //    {
        //        return new DateTime(2016, 8, 6);
        //    }

        //}
        public DateTime PrimaryDate { get; set; }
        public DateTime GeneralDate { get; set; }
        //public DateTime PhasePledgeDeadline { get; set; }
        //public DateTime PhasePledgeFulfillmentDeadline { get; set; }
        //public DateTime PhaseEndDate { get; set; }


    }




}