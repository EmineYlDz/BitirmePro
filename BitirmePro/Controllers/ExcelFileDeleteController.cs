using BitirmePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmePro.Controllers
{
    public class ExcelFileDeleteController : Controller
    {
        private ExcelImportDBEntities2 db = new ExcelImportDBEntities2();
        // GET: ExcelFileDelete
        
        public ActionResult ExcelFileDelete()
        {
            var ogrenci = db.Ogrenci1.ToList();

            if (db.Ogrenci1.Count() == 0)
            {
                ViewBag.mas1 = "Kayıtlı Veriler Silindi!";
            }
            else
            {
                ViewBag.mas = "Kayıtlar Silinmedi!";
            }
            return View();
           
        }
        [HttpPost]
        public ActionResult Delete()
        {
            var ogrenci = db.Ogrenci1.ToList();
            foreach (var d in ogrenci)
            {
                db.Ogrenci1.Remove(d);
            }
            db.SaveChanges();
            if (db.Ogrenci1.Count() == 0)
            {
                ViewBag.mas1 = "Kayıtlı Veriler Silindi!";
            }

            return View("ExcelFileDelete");
        }
    }
}