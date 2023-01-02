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

        public ActionResult Sinif1()
        {
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
                new Ogrenci() { Id = 180101021, AdSoyad = "ezgi" }
            };
            return View(ogr);
        }
        public ActionResult Sinif2()
        {
            return View();
        }
        public ActionResult Sinif3()
        {
            return View();
        }

    }
}