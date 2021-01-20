using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMSWebTest.Controllers
{
    public class CustomersAndVendorsBaseController : Controller
    {
     
        public TMSWebTest.Models.Entities db = new TMSWebTest.Models.Entities();



        [HttpPost, ValidateInput(false)]
        public virtual ActionResult GridViewPartialAddNew(TMSWebTest.Models.CustomerAndVendor item)
        {
            var model = db.CustomersAndVendors;
            if (ModelState.IsValid)
            {
                try
                {
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
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.Where(x => x.IsCustomer == item.IsCustomer).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public virtual ActionResult GridViewPartialUpdate(TMSWebTest.Models.CustomerAndVendor item)
        {
            var model = db.CustomersAndVendors;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.Id == item.Id);
                    if (modelItem != null)
                    {
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
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.Where(x => x.IsCustomer == item.IsCustomer).ToList());
        }
        [HttpPost, ValidateInput(false)]
        public virtual ActionResult GridViewPartialDelete(System.Int32 Id)
        {

            bool iscustomer = true;
            var model = db.CustomersAndVendors;
            if (Id >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.Id == Id);
                    if (item != null)
                    {
                        iscustomer = item.IsCustomer;
                        model.Remove(item);
                    }
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.Where(x => x.IsCustomer == iscustomer).ToList());
        }
    }
}
