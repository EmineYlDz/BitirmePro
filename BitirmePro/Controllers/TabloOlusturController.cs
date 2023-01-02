using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmePro.Controllers
{
    public class TabloOlusturController : Controller
    {
        // GET: TabloOlustur
        public ActionResult TabloOlustur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniTablo(int Sutun,int Satir,int Kisi)
        {
            ViewBag.su = Sutun;
            return View();
        }

    }
}