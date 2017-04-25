using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiboChallenge.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ContenderManagement()
        {
            return View();
        }

        public ActionResult TeamManagement()
        {
            return View();
        }

        public ActionResult ContenderEdit(Guid id)
        {
            return View();
        }
        public ActionResult TournamentManagement()
        {
            return View();
        }

    }
}

