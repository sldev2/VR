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

            List<Target_TemplateInfo> targets = new List<Target_TemplateInfo>();

            using(var context = new VRElectionDataContext())
            {
                targets = context.Target_TemplateInfo.ToList();

            }


            return View(targets);
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