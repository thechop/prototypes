using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmokerTesterProto1.Models;

namespace SmokerTesterProto1.Controllers
{
    public class HomeController : Controller
    {
        private TestSuite[] _testSuites = new TestSuite[]
            {
                new TestSuite
                {
                    Id = 1,
                    Name = "Deal capture tests",
                    Tests = new Test[]
                    {
                        new Test() { Uri = @"api\test\1", Description = "Test 1" },
                        new Test() { Uri = @"api\test\2", Description = "Test 2" },
                        new Test() { Uri = @"api\test\3", Description = "Test 3" },
                    }
                },
                new TestSuite
                {
                    Id = 2,
                    Name = "Retail Billing tests",
                    Tests = new Test[]
                    {
                        new Test() { Uri = @"api\test\4", Description = "Test 4" },
                        new Test() { Uri = @"api\test\5", Description = "Test 5" },
                        new Test() { Uri = @"api\test\6", Description = "Test 6" },
                    }
                },
                new TestSuite
                {
                    Id = 3,
                    Name = "Settlement tests",
                    Tests = new Test[]
                    {
                        new Test() { Uri = @"api\test\7", Description = "Test 7" },
                        new Test() { Uri = @"api\test\8", Description = "Test 8" },
                    }
                },
            };

        public ActionResult Index()
        {
            return View(_testSuites);
        }
    }
}
