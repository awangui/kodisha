using kodisha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace kodisha.Controllers
{
    public class ListingsController : Controller
    {
        // GET: Listings
        public ActionResult AddListings()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddListings(listing property)
        {
            kodIiDBEntities db = new kodIiDBEntities();
            if (ModelState.IsValid)
            {
                property.listing_ID = db.listings.Any() ? db.listings.Max(l => l.listing_ID) + 1 : 1;
                db.listings.Add(property);

                try
                {
                    db.SaveChanges();
                    // Code to save data to the database goes here
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    // Handle the validation error here
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.WriteLine("Property: {0} Error: {1}",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                        }
                    }
                }
            }

            // Return the property object to the view
            return View(property);
        }

        public ActionResult DisplayListings(int id)
        {
            if (id == null)
            {
                throw new Exception("ID parameter is null");
            }

            kodIiDBEntities db = new kodIiDBEntities();
            var property = db.listings.Find(id);
            return View(property);
        }



    }
}
