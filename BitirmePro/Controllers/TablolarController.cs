using BitirmePro.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmePro.Controllers
{
    public class TablolarController : Controller
    {
        private ExcelImportDBEntities2 db = new ExcelImportDBEntities2();
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


            int t = ((5 * Sutun1) + (5 * Sutun2) + (5 * Sutun3));
            ViewBag.d = t;


            SqlConnection conn = new SqlConnection("Server=DESKTOP-MC7TQNE\\SQLExpress;Database=ExcelImportDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select Id,AdSoyad from Ogrenci1",conn);

            List<Ogrenci1> ogrenci = new List<Ogrenci1>();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ogrenci.Add(
                      new Ogrenci1
                      {
                         Id = (int)dr["Id"],
                         AdSoyad = (string)dr["AdSoyad"],
                      });
            }
            conn.Close();

            return View(ogrenci);
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

            
            return View();
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