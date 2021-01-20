using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMSWebTest.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("~/Views/CustomerAndVendor/Index.cshtml");
        }



        TMSWebTest.Models.Entities db = new TMSWebTest.Models.Entities();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.CustomersAndVendors.Where(x=>x.IsCustomer==true);
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(TMSWebTest.Models.CustomerAndVendor item)
        {
            var model = db.CustomersAndVendors;
            if (ModelState.IsValid)
            {
                try
                {
                    item.IsCustomer = true;
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(TMSWebTest.Models.CustomerAndVendor item)
        {
            var model = db.CustomersAndVendors;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.Id == item.Id);
                    if (modelItem != null)
                    {
                        //item.IsCustomer = true;

                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(System.Int32 Id)
        {
            var model = db.CustomersAndVendors;
            if (Id >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.Id == Id);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.ToList());
        }
    }
}