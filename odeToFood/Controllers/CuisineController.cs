using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odeToFood.Controllers
{
   // [Authorize]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        // [HttpPost]
        // [Authorize(Roles="Admin")]
      
        public ActionResult Search(String name="Swedish")
        {
            throw new Exception("error");
            var message = Server.HtmlEncode(name);
            return Content(message);

            //  return RedirectToAction("index", "Home", new { name = name });

            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/hw3_key_f16.pdf"), "application/pdf");
            // return Json(new { Messae = message, By = "Li" }, JsonRequestBehavior.AllowGet);


        }
      //  [HttpGet]
        //public ActionResult Search()
        //{

        //    return Content("Hapy");


        //}
    }
}