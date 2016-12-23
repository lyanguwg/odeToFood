﻿using odeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdetoFoodDb _db = new OdetoFoodDb();

        public ActionResult Index()
        {


            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["Action"];
            //var id = RouteData.Values["id"];

            //String value = String.Format("{0}::{1} {2}", controller, action, id);

            //ViewBag.Message = value;

            var model = _db.Restarants.ToList<Restaurant>();
            return View(model);
        }

        public ActionResult About()
        {
            //   ViewBag.Message = "Your application description page.";
            // ViewBag.Location = "Atlanta, USA";



            var model = new AboutModel();
            model.Message = "test";
            model.Location = "USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}