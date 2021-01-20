using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMSWebTest.Models;

namespace TMSWebTest.Controllers
{
    public class CustomersController : CustomersAndVendorsBaseController
    {
        // GET: Customers
        public ActionResult Index()
        {
         
            return View("~/Views/CustomerAndVendor/Index.cshtml");
        }
        public  ActionResult GridViewPartial()
        {
            var model = db.CustomersAndVendors.Where(x => x.IsCustomer == true);
                return PartialView("~/Views/CustomerAndVendor/_GridViewPartial.cshtml", model.ToList());
        }
        public override ActionResult GridViewPartialAddNew(CustomerAndVendor item)
        {
            item.IsCustomer = true;
            return base.GridViewPartialAddNew(item);
        }
        public override ActionResult GridViewPartialDelete(int Id)
        {
            return base.GridViewPartialDelete(Id);
        }
        public override ActionResult GridViewPartialUpdate(CustomerAndVendor item)
        {
            return base.GridViewPartialUpdate(item);
        }
    }
}