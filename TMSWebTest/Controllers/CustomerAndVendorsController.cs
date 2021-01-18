using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMSWebTest.Models;

namespace TMSWebTest.Controllers
{
    public class CustomerAndVendorsController : Controller
    {
        private MiltonDBEntities db = new MiltonDBEntities();

        // GET: CustomerAndVendors
        public ActionResult Index()
        {
            return View(db.CustomerAndVendors.ToList());
        }

        // GET: CustomerAndVendors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerAndVendor customerAndVendor = db.CustomerAndVendors.Find(id);
            if (customerAndVendor == null)
            {
                return HttpNotFound();
            }
            return View(customerAndVendor);
        }

        // GET: CustomerAndVendors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerAndVendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AccountId,IsCustomer,Name,VAT_NIP,Phone,Mobile,Country,Branch,Address,Website,Email,MaxCredit,Notes")] CustomerAndVendor customerAndVendor)
        {
            if (ModelState.IsValid)
            {
                db.CustomerAndVendors.Add(customerAndVendor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerAndVendor);
        }

        // GET: CustomerAndVendors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerAndVendor customerAndVendor = db.CustomerAndVendors.Find(id);
            if (customerAndVendor == null)
            {
                return HttpNotFound();
            }
            return View(customerAndVendor);
        }

        // POST: CustomerAndVendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AccountId,IsCustomer,Name,VAT_NIP,Phone,Mobile,Country,Branch,Address,Website,Email,MaxCredit,Notes")] CustomerAndVendor customerAndVendor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerAndVendor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerAndVendor);
        }

        // GET: CustomerAndVendors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerAndVendor customerAndVendor = db.CustomerAndVendors.Find(id);
            if (customerAndVendor == null)
            {
                return HttpNotFound();
            }
            return View(customerAndVendor);
        }

        // POST: CustomerAndVendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerAndVendor customerAndVendor = db.CustomerAndVendors.Find(id);
            db.CustomerAndVendors.Remove(customerAndVendor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
