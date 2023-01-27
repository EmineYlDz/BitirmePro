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
        private ExcelImportDBEntities4 db = new ExcelImportDBEntities4();
        // GET: ExcelFileDelete
        
        public ActionResult ExcelFileDelete()
        {
            var ogrenci = db.Ogrenci3.ToList();

            if (db.Ogrenci3.Count() == 0)
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
            var ogrenci = db.Ogrenci3.ToList();
            foreach (var d in ogrenci)
            {
                db.Ogrenci3.Remove(d);
            }
            db.SaveChanges();
            if (db.Ogrenci3.Count() == 0)
            {
                ViewBag.mas1 = "Kayıtlı Veriler Silindi!";
            }

            return View("ExcelFileDelete");
        }
    }
}