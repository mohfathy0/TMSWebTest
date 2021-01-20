using DevExpress.Web;
using DevExpress.Web.Mvc;
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
    public class CompanyInfoController : Controller
    {
        private Entities db = new Entities();

        //// GET: CompanyInfoes
        //public ActionResult Index()
        //{
        //    return View(db.CompanyInfoes.ToList());
        //}

        public ActionResult Index(int? id = 1)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyInfo companyInfo = db.CompanyInfos.Find(id);
            if (companyInfo == null)
            {
                return HttpNotFound();
            }
            return View(companyInfo);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Name,VAT_ID_NIP,Phone,Mobile,Address,Website,Email,Branch,City,Country,AccountId,Notes")] CompanyInfo companyInfo,
            [ModelBinder(typeof(DevExpressEditorsBinder))] IEnumerable<UploadedFile> uploadControl)
        {
            bool imageflag = false;
            var img = uploadControl;
            byte[] b = uploadControl.FirstOrDefault().FileBytes;
            if (b.Length > 0)
            {
                imageflag = true;
                companyInfo.Logo = b;
            }

            if (ModelState.IsValid)
            {
                db.Entry(companyInfo).State = EntityState.Modified;
                db.Entry(companyInfo).Property(x => x.Logo).IsModified = false;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companyInfo);
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
