using BitirmePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmePro.Controllers
{
    public class TablolarController : Controller
    {
        // GET: Tablolar
        public ActionResult Tablolar()
        {
            return View();
        }
        public ActionResult KisiSinif1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sinif1(int Sutun1,int Sutun2,int Sutun3)
        {
            ViewBag.su1 = Sutun1;
            ViewBag.su2 = Sutun2;
            ViewBag.su3 = Sutun3;
            List<Ogrenci> ogr = new List<Ogrenci>()
            {
                new Ogrenci() { Id = 180101029,AdSoyad="Emine Yıldız"},
                new Ogrenci() { Id = 180101019, AdSoyad = "demir" },
                new Ogrenci() { Id = 180101049, AdSoyad = "ali" },
                new Ogrenci() { Id = 180101059,AdSoyad="mehmet"},
                new Ogrenci() { Id = 180101069, AdSoyad = "ayse" },
                new Ogrenci() { Id = 180101079, AdSoyad = "sdferrgee" },
                new Ogrenci() { Id = 180101089, AdSoyad = "fatma" },
                new Ogrenci() { Id = 180101099,AdSoyad="ahmet"},
                new Ogrenci() { Id = 180101020, AdSoyad = "betul" },
                new Ogrenci() { Id = 180101021, AdSoyad = "ezgi" },
                new Ogrenci() { Id = 180101029,AdSoyad="Emine Yıldız"},
                new Ogrenci() { Id = 180101019, AdSoyad = "demir" },
                new Ogrenci() { Id = 180101049, AdSoyad = "ali" },
                new Ogrenci() { Id = 180101059,AdSoyad="mehmet"},
                new Ogrenci() { Id = 180101069, AdSoyad = "ayse" },
                new Ogrenci() { Id = 180101079, AdSoyad = "sdferrgee" },
                new Ogrenci() { Id = 180101069, AdSoyad = "ayse" },
                new Ogrenci() { Id = 180101079, AdSoyad = "sdferrgee" },
                new Ogrenci() { Id = 180101089, AdSoyad = "fatma" },
                new Ogrenci() { Id = 180101099,AdSoyad="ahmet"},
                new Ogrenci() { Id = 180101020, AdSoyad = "betul" },
                new Ogrenci() { Id = 180101021, AdSoyad = "ezgi" },
                new Ogrenci() { Id = 180101089, AdSoyad = "fatma" },
                new Ogrenci() { Id = 180101099,AdSoyad="ahmet"},
                new Ogrenci() { Id = 180101020, AdSoyad = "betul" },
                new Ogrenci() { Id = 180101021, AdSoyad = "ezgi" },
                new Ogrenci() { Id = 180101029,AdSoyad="Emine Yıldız"},
                new Ogrenci() { Id = 180101019, AdSoyad = "demir" },
                new Ogrenci() { Id = 180101049, AdSoyad = "ali" },
                new Ogrenci() { Id = 180101059,AdSoyad="mehmet"}
            };
            return View(ogr);
        }

        //M-205
        public ActionResult KisiSinif2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sinif2(int Sutun2,int Sutun3)
        {
            ViewBag.su2 = Sutun2;
            ViewBag.su3 = Sutun3;

            List<Ogrenci> ogr = new List<Ogrenci>()
            {
                new Ogrenci() { Id = 180101029,AdSoyad="1"},
                new Ogrenci() { Id = 180101019, AdSoyad = "2" },
                new Ogrenci() { Id = 180101049, AdSoyad = "3" },
                new Ogrenci() { Id = 180101059,AdSoyad="4"},
                new Ogrenci() { Id = 180101069, AdSoyad = "5" },
                new Ogrenci() { Id = 180101079, AdSoyad = "6" },
                new Ogrenci() { Id = 180101089, AdSoyad = "7" },
                new Ogrenci() { Id = 180101099,AdSoyad="8"},
                new Ogrenci() { Id = 180101020, AdSoyad = "9" },
                new Ogrenci() { Id = 180101021, AdSoyad = "10" },
                new Ogrenci() { Id = 180101029,AdSoyad="11"},
                new Ogrenci() { Id = 180101019, AdSoyad = "12" },
                new Ogrenci() { Id = 180101049, AdSoyad = "13" },
                new Ogrenci() { Id = 180101059,AdSoyad="14"},
                new Ogrenci() { Id = 180101069, AdSoyad = "15" },
                new Ogrenci() { Id = 180101079, AdSoyad = "16" },
                new Ogrenci() { Id = 180101069, AdSoyad = "17" },
                new Ogrenci() { Id = 180101079, AdSoyad = "18" },
                new Ogrenci() { Id = 180101089, AdSoyad = "19" },
                new Ogrenci() { Id = 180101099, AdSoyad="20"},
                new Ogrenci() { Id = 180101020, AdSoyad = "21" },
                new Ogrenci() { Id = 180101021, AdSoyad = "22" },
                new Ogrenci() { Id = 180101089, AdSoyad = "23" },
                new Ogrenci() { Id = 180101099,AdSoyad="24"},
                new Ogrenci() { Id = 180101020, AdSoyad = "25" },
                new Ogrenci() { Id = 180101021, AdSoyad = "26" },
                new Ogrenci() { Id = 180101029,AdSoyad=" 27"},
                new Ogrenci() { Id = 180101019, AdSoyad = "28" },
                new Ogrenci() { Id = 180101049, AdSoyad = "29" },
                new Ogrenci() { Id = 180101059,AdSoyad="30"},
                new Ogrenci() { Id = 180101059,AdSoyad="31"},
                new Ogrenci() { Id = 180101059,AdSoyad="32"},

            };
            return View(ogr);
        }


        public ActionResult KisiSinif3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sinif3(int Sutun1, int Sutun2, int Sutun3)
        {
            ViewBag.su1 = Sutun1;
            ViewBag.su2 = Sutun2;
            ViewBag.su3 = Sutun3;
            return View();
        }

    }
}