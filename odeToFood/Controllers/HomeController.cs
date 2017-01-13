using odeToFood.Models;
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

        public ActionResult Index(string searchTerm = null)
        {


            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["Action"];
            //var id = RouteData.Values["id"];

            //String value = String.Format("{0}::{1} {2}", controller, action, id);

            //ViewBag.Message = value;

            // var model = _db.Restarants.ToList<Restaurant>();

            //linq comprehensive syntax
            //var model = from r in _db.Restarants
            //            orderby r.Reviews.Average(review => review.Rating) descending
            //            select new RestaurantListViewModel
            //            {
            //                Id = r.id,
            //                Name = r.Name,
            //                City = r.City,
            //                Country = r.Country,
            //                CountOfReviews = r.Reviews.Count()
            //            };

            var model = _db.Restarants.OrderByDescending(r =>r.Reviews.Average(review => review.Rating))
                            .Where( r => searchTerm == null || r.Name.StartsWith(searchTerm))
                            .Select(r => new RestaurantListViewModel
                            {
                                Id = r.Id,
                                Name = r.Name,
                                City = r.City,
                                Country = r.Country,
                                CountOfReviews = r.Reviews.Count()
                            });

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