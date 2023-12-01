using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroMVC5.Controllers
{
    [RoutePrefix("systems")]
    public class TestController : Controller
    {
        // GET: Test
        [Route]
        public ActionResult Index()
        {
            return View();
        }
        [Route("test")]
        public ActionResult IndexTeste()
        {
            return View("Index");
        }
    }
}