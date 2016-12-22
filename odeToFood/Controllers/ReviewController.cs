using odeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odeToFood.Controllers
{
    public class ReviewController : Controller
    {
        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var review = from r in _reviews
                         orderby r.Rating descending
                         select r;

            return PartialView("_Review", review.First());
        }
        // GET: Review
        public ActionResult Index()
        {
            var model = 
                        from r in _reviews
                        orderby r.Country
                        select r;

            return View(model);
        }

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: Review/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.Id == id);

            if (TryUpdateModel(review))
            {
               return RedirectToAction("Index");
            }
            else
            {
                return View(review);
            }

        }

        // GET: Review/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Review/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<Review> _reviews = new List<Review>
        {
            new Review {Id=1, Name ="R1", City ="Atlanta", Country ="USA", Rating = 5 },
             new Review {Id=2, Name ="R2", City ="Miami", Country ="USA", Rating = 6 },
              new Review {Id=3, Name ="R3", City ="Austin", Country ="USA", Rating = 9 }

        };
    }
}
