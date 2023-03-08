using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult ContentResult()
        {
            return Content("Hello World!");
        }

        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.jpg"));
            return File(foto, "image/jpg", "capa.jpg");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("teste:'Teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://desenvolvedor.io"); 
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            /*return RedirectToRoute(new
            {
                controller = "Teste",
                action = "IndexTeste"
            });*/

            return RedirectToAction("IndexTeste", "Teste");
        }
    }
}