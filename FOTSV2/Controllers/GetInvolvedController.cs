using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FOTSV2.Controllers
{
    public class GetInvolvedController : Controller
    {
        // GET: GetInvolved
        public ActionResult Membership()
        {
            return View();
        }

        public ActionResult Meetings()
        {
            return View();
        }

        public ActionResult Volunteer()
        {
            return View();
        }
    }
}