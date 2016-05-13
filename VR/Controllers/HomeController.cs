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
            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "Oregon",
                StateAbbreviation = "OR",
                PrimaryDate = new DateTime(2016, 5, 17)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "Washington",
                StateAbbreviation = "WA",
                PrimaryDate = new DateTime(2016, 5, 24)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "South Dakota",
                StateAbbreviation = "SD",
                PrimaryDate = new DateTime(2016, 6, 7)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "California",
                StateAbbreviation = "CA",
                PrimaryDate = new DateTime(2016, 6, 7)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "Montana",
                StateAbbreviation = "MT",
                PrimaryDate = new DateTime(2016, 6, 7)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "New Jersey",
                StateAbbreviation = "NJ",
                PrimaryDate = new DateTime(2016, 6, 7)
            });

            prezCampaignStateParticulars.Add(new PrezCampaignStateParticulars()
            {
                StateName = "New Mexico",
                StateAbbreviation = "NM",
                PrimaryDate = new DateTime(2016, 6, 7)
            });


            // for each Presidential target
            foreach(var target in targets.Where(x => x.HouseId == 1))
            {
            
                PrezCampaignViewModel prezCampaignViewModel = null;
                foreach(var state in prezCampaignStateParticulars)
                {

               

                   
                    prezCampaignViewModel = new PrezCampaignViewModel()
                    {
                        IsMultiphasic = true,
                        Name = "Wake up the public on TPP, " + target.Name + "!",
                        Issue = "The Trans-Pacific Partnership, TPP",
                        Info = @"Possibly the worst piece of legislation in US history, TPP promises to subvert Constitutional order in favor of multinational corporations. These corporations will be able to sue for ""anticipated loss of profits"", and disputes will be adjudicated by a tribunal of corporate appointed lawyers.",
                        IsPresidential = true,
                        ElectionYear = 2016,
                        PrimaryDate = null,
                        ConventionDate = (target.Party == "Democratic") ? state.DemConventionDate : state.RepubConventionDate,
                        GeneralDate = new DateTime(2016, 11, 8),
                        TargetMacroRegion = "US",
                        TargetElectoralRegionName = state.StateName,
                        TargetElectoralRegionAbbreviation = state.StateAbbreviation,
                        PrezCampaignPhaseViewModels = new List<PrezCampaignPhaseViewModel>()
                        {
                            new PrezCampaignPhaseViewModel()
                            {
                                Number = 1,
                                Redline = target.Name + " must declare TPP to be evil, and declare unequivocal opposition to same on his/her primary website",
                                RegionName = state.StateName,
                                RegionAbbreviation = state.StateAbbreviation,
                                //PrimaryDate = null,
                                GeneralDate = new DateTime(2016, 11, 8),
                                PledgeDeadline = new DateTime(2016, 5, 10 ),
                                PledgeFulfillmentDeadline = new DateTime(2016, 5, 16),
                                EndDate = new DateTime(2016, 5, 17)
                            }
                        }
                    };
                

                    prezCampaignViewModels.Add(prezCampaignViewModel);

                }


            }
            rootViewModel.PrezCampaignViewModels = prezCampaignViewModels;




            // =================================================================================================
            // Congress Campaigns and CampaignPhases
            // =================================================================================================




            //using(var context = new VRElectionDataContext())
            //{
            //    PrezCampaignViewModels = context.
            //}






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