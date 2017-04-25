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


        public ActionResult ContenderManagementController()
        {
            return View();
        }

        public ActionResult TeamRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContenderEdit(int id)
        {
            return View();
        }
    }
}

