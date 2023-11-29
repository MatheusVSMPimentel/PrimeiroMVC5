using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroMVC5.Controllers
{
    public class ParametersController : Controller
    {
        // GET: Parameters
        public ActionResult Index(int teste)
        {
            return View();
        }
        public ActionResult IndexId(int id)
        {
            return View();
        }
        public ActionResult IndexId2(int id, int id2)
        {
            return View();
        } 
        [Route("{id1:int}/{id2:int}")]
        public ActionResult IndexId3(int id1, int id2)
        {
            return View();
        }
        [Route("{id1:int}/{texto:maxlength(50)}")]
        public ActionResult IndexId3(int id1, string texto)
        {
            return View();
        }
    }
}