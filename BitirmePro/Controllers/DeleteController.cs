using BitirmePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmePro.Controllers
{
    public class DeleteController : Controller
    {
        private ExcelImportDBEntities2 db = new ExcelImportDBEntities2();
        // GET: Delete
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int KisiSayi)
        {
            for (int a = 0; a < KisiSayi; a++)
            {
                var ogrenci = db.Ogrenci1.Find(a);
                if (ogrenci != null)
                {
                    db.Ogrenci1.Remove(ogrenci);
                }
                db.SaveChanges();
            }

            return View();
        }
    }
}