using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VR.Models;

namespace VR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Targets()
        {

            RootViewModel rootViewModel = new RootViewModel();

            // =================================================================================================
            // Targets  (and Posses)
            // =================================================================================================
            List<Target_TemplateInfo> targets = new List<Target_TemplateInfo>();
            using(var context = new VRElectionDataContext())
            {
                targets = context.Target_TemplateInfo.ToList();

            }
            rootViewModel.Target_TemplateInfos = targets;


            // =================================================================================================
            // Prez Campaigns and CampaignPhases
            // =================================================================================================
            List<PrezCampaignViewModel> prezCampaignViewModels = new List<PrezCampaignViewModel>();

            // get the particulars wrt each of the states, for the remaining Prez primaries
            List<PrezCampaignStateParticulars> prezCampaignStateParticulars = new List<PrezCampaignStateParticulars>();

#region prezCampaignStateParticulars

            //================================  Dems            
            
            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "Kentucky",
                StateAbbreviation = "KY",
                PrimaryDate = new DateTime(2016, 5, 17),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)

            });
            
            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "Oregon",
                StateAbbreviation = "OR",
                PrimaryDate = new DateTime(2016, 5, 17),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });


            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "South Dakota",
                StateAbbreviation = "SD",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "California",
                StateAbbreviation = "CA",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "Montana",
                StateAbbreviation = "MT",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "New Jersey",
                StateAbbreviation = "NJ",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "New Mexico",
                StateAbbreviation = "NM",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Democratic",
                StateName = "North Dakota",
                StateAbbreviation = "ND",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 25)
            });


            //================================  Repubs

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "Oregon",
                StateAbbreviation = "OR",
                PrimaryDate = new DateTime(2016, 5, 17),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "Washington",
                StateAbbreviation = "WA",
                PrimaryDate = new DateTime(2016, 5, 24),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "South Dakota",
                StateAbbreviation = "SD",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "California",
                StateAbbreviation = "CA",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "Montana",
                StateAbbreviation = "MT",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "New Jersey",
                StateAbbreviation = "NJ",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                Party = "Republican",
                StateName = "New Mexico",
                StateAbbreviation = "NM",
                PrimaryDate = new DateTime(2016, 6, 7),
                GeneralDate = new DateTime(2016, 11, 8),
                ConventionDate = new DateTime(2016, 7, 18)
            });
#endregion



            // for each Presidential target
            foreach(var target in targets.Where(x => x.HouseId == 1))
            {
            
                PrezCampaignViewModel prezCampaignViewModel = null;
                foreach(var state in prezCampaignStateParticulars)
                {

                    if(target.Party == state.Party)
                    {
	                    prezCampaignViewModel = new PrezCampaignViewModel()
	                        {
	                            targetHandle = "target" + target.Name.Replace(" ", "_").Replace(".", ""),
	                            targetName = target.Name,
	                            IsMultiphasic = true,
	                            Name = "Wake up the public on TPP, " + target.Name + "!",
	                            Issue = "The Trans-Pacific Partnership, TPP",
	                            Info = @"Possibly the worst piece of legislation in US history, TPP promises to subvert Constitutional order in favor of multinational corporations. These corporations will be able to sue for ""anticipated loss of profits"", and disputes will be adjudicated by a tribunal of corporate appointed lawyers.",
	                            IsPresidential = true,
	                            ElectionYear = 2016,
	                            PrimaryDate = state.PrimaryDate,
	                            ConventionDate = state.ConventionDate,
	                            GeneralDate = new DateTime(2016, 11, 8),
	                            TargetMacroRegion = "US",
	                            TargetElectoralRegionName = state.StateName,
	                            TargetElectoralRegionAbbreviation = state.StateAbbreviation,
	                            PrezCampaignPhaseViewModels = new List<PrezCampaignPhaseViewModel>()
	                            {
	                                // for pres campaign, inject primaryDate, xxxconventionDate, generalDate, 
	
	                                new PrezCampaignPhaseViewModel(target.Party, state.PrimaryDate)
	                                {
                                        // =========================
                                        // Pre Primary
                                        // =========================
	                                    Number = 1,
	                                    EndDate = state.PrimaryDate,    // primary date
	                                    VoteslingerPrimaryDeadline  =  state.PrimaryDate.AddDays(-14),   // primary date minus 2 weeks
	                                    VoteslingerGeneralDeadline  = state.GeneralDate.AddDays(-28),    // general date minus 4 weeks
	                                    PledgeDeadline = state.PrimaryDate.AddDays(-14),    // primary date minus 2 weeks
	                                    PledgeFulfillmentDeadline = state.PrimaryDate.AddDays(-3),   // primary date minus 3 days
	                                    Redline = target.Name + " must declare unequivocal opposition to same on his/her primary website, and do a whip count of firm opposition to TPP by members of Congress",
	                                
	                                
	                                    //RegionName = state.StateName,
	                                    //RegionAbbreviation = state.StateAbbreviation,
	                                    //PrimaryDate = state.PrimaryDate,
	                                    //GeneralDate = state.GeneralDate,
	
	
	                                },
	

	                                new PrezCampaignPhaseViewModel(target.Party, state.PrimaryDate)
	                                {
                                        // =========================
                                        // Pre Convention
                                        // =========================
	                                    Number = 2,
	                                    EndDate = state.ConventionDate,   // convention date
	                                    VoteslingerPrimaryDeadline  = state.PrimaryDate.AddDays(-14),    // primary date minus 2 weeks
	                                    VoteslingerGeneralDeadline  = state.GeneralDate.AddDays(-28),    // general date minus 4 weeks
	                                    PledgeDeadline = state.ConventionDate.AddDays(-28),   // convention date minus 4 weeks
	                                    PledgeFulfillmentDeadline = state.ConventionDate.AddDays(-5),   // Convention date minus 5 days
	                                    Redline = target.Name + " must declare unequivocal opposition to same on his/her primary website, and do a whip count of firm opposition to TPP by members of Congress",
	                                
	                                },
	
	

	                                new PrezCampaignPhaseViewModel(target.Party, state.PrimaryDate)
	                                {
	

                                        // =========================
                                        // Pre General Election
                                        // =========================
	                                    Number = 3,
	                                    EndDate = state.GeneralDate,   // general date
	                                    VoteslingerPrimaryDeadline  = state.PrimaryDate.AddDays(-14),    // primary date minus 2 weeks
	                                    VoteslingerGeneralDeadline  = state.GeneralDate.AddDays(-28),    // general date minus 4 weeks
	                                    PledgeDeadline = state.GeneralDate.AddDays(-28),   // general date minus 4 weeks
	                                    PledgeFulfillmentDeadline = state.GeneralDate.AddDays(-5),   // general date minus 5 days
	                                    Redline = target.Name + " must declare unequivocal opposition to same on his/her primary website, and do a whip count of firm opposition to TPP by members of Congress",
	                                
	                                }
	
	
	
	                                //new PrezCampaignPhaseViewModel()
	                                //{
	                                //    Number = 2,
	                                //    Redline = target.Name + " must declare unequivocal opposition to same on his/her primary website, and do a whip count of firm opposition to TPP by members of Congress",
	                                //    RegionName = state.StateName,
	                                //    RegionAbbreviation = state.StateAbbreviation,
	                                //    //PrimaryDate = null,
	                                //    GeneralDate = new DateTime(2016, 11, 8),
	                                //    PledgeDeadline = new DateTime(2016, 5, 10 ),
	                                //    PledgeFulfillmentDeadline = new DateTime(2016, 5, 16),
	                                //    EndDate = new DateTime(2016, 5, 17)
	                                //}
	                            }
	                        };
                        prezCampaignViewModels.Add(prezCampaignViewModel);
                    }
                



                }


            }
            rootViewModel.PrezCampaignViewModels = prezCampaignViewModels;




            // =================================================================================================
            // Congress Campaigns and CampaignPhases
            // =================================================================================================
            List<PrezCampaignViewModel> CongressCampaignViewModels = new List<PrezCampaignViewModel>();

            // for each HR or Senate target
            foreach (var target in targets.Where(x => x.HouseId == 2 || x.HouseId == 3))
            {

                PrezCampaignViewModel prezCampaignViewModel = null;

                prezCampaignViewModel = new PrezCampaignViewModel()
                {
                    targetHandle = "target" + target.Name.Replace(" ", "_").Replace(".", ""),
                    targetName = target.Name,
                    IsMultiphasic = true,
                    Name = "Wake up the public on TPP, " + target.Name + "!",
                    Issue = "The Trans-Pacific Partnership, TPP",
                    Info = @"Possibly the worst piece of legislation in US history, TPP promises to subvert Constitutional order in favor of multinational corporations. These corporations will be able to sue for ""anticipated loss of profits"", and disputes will be adjudicated by a tribunal of corporate appointed lawyers.",
                    IsPresidential = false,
                    ElectionYear = 2016,
                    PrimaryDate = target.PrimaryDate,
                    ConventionDate = null,
                    GeneralDate = new DateTime(2016, 11, 8),
                    TargetMacroRegion = "US",
                    TargetElectoralRegionName = target.StateName,
                    TargetElectoralRegionAbbreviation = target.StateAbbreviation,
                    PrezCampaignPhaseViewModels = new List<PrezCampaignPhaseViewModel>()
	                    {
	                        // for pres campaign, inject primaryDate, xxxconventionDate, generalDate, 
	
	                        new PrezCampaignPhaseViewModel(target.Party, target.PrimaryDate)
	                        {
	                            Number = 1,
	                            EndDate = target.PrimaryDate,    // primary date
	                            VoteslingerPrimaryDeadline  =  target.PrimaryDate.AddDays(-14),   // primary date minus 2 weeks
	                            VoteslingerGeneralDeadline  = target.GeneralElectionDate.AddDays(-28),    // general date minus 4 weeks
	                            PledgeDeadline = target.PrimaryDate.AddDays(-14),    // primary date minus 2 weeks
	                            PledgeFulfillmentDeadline = target.PrimaryDate.AddDays(-3),   // primary date minus 3 days
	                            Redline = target.Name + " must declare unequivocal opposition to same on his/her primary website, and do a whip count of firm opposition to TPP by members of Congress",
	                                
	                                
	                            //RegionName = state.StateName,
	                            //RegionAbbreviation = state.StateAbbreviation,
	                            //PrimaryDate = state.PrimaryDate,
	                            //GeneralDate = state.GeneralDate,
	
	
	                        },
	
	
	                        new PrezCampaignPhaseViewModel(target.Party, target.PrimaryDate)
	                        {
	                            Number = 2,
	                            EndDate = target.GeneralElectionDate,   // general date
	                            VoteslingerPrimaryDeadline  = target.PrimaryDate.AddDays(-14),    // primary date minus 2 weeks
	                            VoteslingerGeneralDeadline  = target.GeneralElectionDate.AddDays(-28),    // general date minus 4 weeks
	                            PledgeDeadline = target.GeneralElectionDate.AddDays(-28),   // general date minus 4 weeks
	                            PledgeFulfillmentDeadline = target.GeneralElectionDate.AddDays(-5),   // general date minus 5 days
	                            Redline = target.Name + " must declare unequivocal opposition to same on his/her primary website, and do a whip count of firm opposition to TPP by members of Congress",
	                        }
	                    }
                };
                CongressCampaignViewModels.Add(prezCampaignViewModel);



            }
            rootViewModel.CongressCampaignViewModels = CongressCampaignViewModels;







            return View(rootViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}