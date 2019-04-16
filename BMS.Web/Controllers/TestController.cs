using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMS.ApplicationServices.Repository.Abstractions;

namespace BMS.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestAppService _testAppService;
        // GET: Test
        public TestController(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }
        public ActionResult Index()
        {
            var tests = _testAppService.GetAllTestEitherFailedOrPass(1);

            return View(tests);
        }
    }
}