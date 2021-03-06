﻿using odeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odeToFood.Controllers
{
    public class ReviewController : Controller
    {
        private OdetoFoodDb db = new OdetoFoodDb();

        //[ChildActionOnly]
        //public ActionResult BestReview()
        //{
        //    var review = from r in _reviews
        //                 orderby r.Rating descending
        //                 select r;

        //    return PartialView("_Review", review.First());
        //}
        // GET: Review
        public ActionResult Index(int  restaurantid)
        // public ActionResult Index([Bind(Prefix="id")]int  restaurantid)
        {
            //    var restaurant = db.Restarants.First(r => r.Id == restaurantid);
            // var model = restaurant.Reviews.ToList();

            // var restaurant = db.Restarants.Include("Reviews").Single(r => r.Id == restaurantid);

            var restaurant = db.Restarants.Find(restaurantid);

            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();

           
        }

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Review/Create
        public ActionResult Create(int restaurantid)
        {
            
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Review review)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Reviews.Add(review);
                    db.SaveChanges();
                    return RedirectToAction("Index", new { restaurantid = review.RestaurantId });
                }
         
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
              
            }
            return View(review);

        }

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {
            //
            //var review = _reviews.Single(r => r.Id == id);
            var review = db.Reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: Review/Edit/5
        [HttpPost]
    //    public ActionResult Edit(int id, FormCollection collection)
    public ActionResult Edit (Review review)
        {
            // var review = _reviews.Single(r => r.Id == id);

            // var review = db.Reviews.Single(r => r.Id == id);
          
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                 db.SaveChanges();
               
                return RedirectToAction("Index", new { restaurantid = review.RestaurantId });
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

        //static List<Review> _reviews = new List<Review>
        //{
        //    new Review {Id=1, Name ="R1", City ="Atlanta", Country ="USA", Rating = 5 },
        //     new Review {Id=2, Name ="R2", City ="Miami", Country ="USA", Rating = 6 },
        //      new Review {Id=3, Name ="R3", City ="Austin", Country ="USA", Rating = 9 }

        //};
    }
}
