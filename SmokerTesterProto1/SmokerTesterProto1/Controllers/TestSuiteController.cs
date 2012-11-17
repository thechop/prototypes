using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmokerTesterProto1.Models;

namespace SmokerTesterProto1.Controllers
{
    public class TestSuiteController : Controller
    {

        //
        // GET: /TestSuite/

        public ActionResult Index()
        {
            return View();
        }
    }
}
