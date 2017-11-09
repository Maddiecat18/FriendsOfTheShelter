using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FOTSV2.Controllers
{
    public class EventsController : Controller
    {
        // GET: Event
        public ActionResult UpcomingEvents()
        {
            return View();
        }

        public ActionResult PetFest()
        {
            return View();
        }
    }


}