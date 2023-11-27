using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ContentResult OlaMundo()
        {
            return Content("Ola Mundo");
        }

        public FileContentResult ImagemJpg()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.jpg"));
            return File(foto, "image/jpg", "capa.jpg");
        }

        public HttpUnauthorizedResult LoginFailed()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("teste:'teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult Redirect()
        {
            return new RedirectResult("https://matheuspimentelcv.netlify.com");
        }

        public RedirectToRouteResult RedirectRoute()
        {
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            });
        }

        public RedirectToRouteResult RedirectRouteAction()
        {
            return RedirectToAction("Index","Test");
        }
    }
}