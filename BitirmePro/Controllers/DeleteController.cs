using BitirmePro.Models;
using System.Linq;
using System.Web.Mvc;

namespace BitirmePro.Controllers
{
    public class DeleteController : Controller
    {
        private ExcelImportDBEntities4 db = new ExcelImportDBEntities4();
        // GET: Delete
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int KisiSayi)
        {
            var ogrenci = db.Ogrenci3.Take(KisiSayi - 1).ToList();
            if (ogrenci != null)
            {
                db.Ogrenci3.RemoveRange(ogrenci);
            }
            db.SaveChanges();

            return RedirectToAction("Index","Home");

        }

    }

    
}