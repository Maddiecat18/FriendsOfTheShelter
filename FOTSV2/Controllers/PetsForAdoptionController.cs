using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FOTSV2.Controllers
{
    public class PetsForAdoptionController : Controller
    {
        // GET: PetsForAdoption
        public ActionResult Index()
        {
            return View();
        }
    }
}