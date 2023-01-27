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
        private ExcelImportDBEntities4 db = new ExcelImportDBEntities4();
        // GET: Tablolar
        public ActionResult Tablolar()
        {
            return View();
        }
        //M108
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

            SqlConnection conn = new SqlConnection("Server=DESKTOP-MC7TQNE\\SQLExpress;Database=ExcelImportDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select Numarası,Adı,Soyadı from Ogrenci3",conn);

            List<Ogrenci3> ogrenci = new List<Ogrenci3>();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ogrenci.Add(
                      new Ogrenci3
                      {
                         Numarası = (int)dr["Numarası"],
                         Adı = (string)dr["Adı"],
                         Soyadı = (string)dr["Soyadı"]
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
        public ActionResult Sinif2(int Sutun2,int Sutun3,int Sutun4)
        {
            ViewBag.su2 = Sutun2;
            ViewBag.su3 = Sutun3;
            ViewBag.su4 = Sutun4;
            SqlConnection conn = new SqlConnection("Server=DESKTOP-MC7TQNE\\SQLExpress;Database=ExcelImportDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select Numarası,Adı,Soyadı from Ogrenci3", conn);

            List<Ogrenci3> ogrenci = new List<Ogrenci3>();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ogrenci.Add(
                      new Ogrenci3
                      {
                          Numarası = (int)dr["Numarası"],
                          Adı = (string)dr["Adı"],
                          Soyadı = (string)dr["Soyadı"]
                      });
            }
            conn.Close();

            return View(ogrenci);
        }

        //M109
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

            SqlConnection conn = new SqlConnection("Server=DESKTOP-MC7TQNE\\SQLExpress;Database=ExcelImportDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select Numarası,Adı,Soyadı from Ogrenci3", conn);

            List<Ogrenci3> ogrenci = new List<Ogrenci3>();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ogrenci.Add(
                      new Ogrenci3
                      {
                          Numarası = (int)dr["Numarası"],
                          Adı = (string)dr["Adı"],
                          Soyadı = (string)dr["Soyadı"]
                      });
            }
            conn.Close();

            return View(ogrenci);
        }
        
        public ActionResult KisiM111()
        {
            return View();
        }
        [HttpPost]
        public ActionResult M111(int Sutun1, int Sutun2, int Sutun3)
        {
            ViewBag.su1 = Sutun1;
            ViewBag.su2 = Sutun2;
            ViewBag.su3 = Sutun3;

            SqlConnection conn = new SqlConnection("Server=DESKTOP-MC7TQNE\\SQLExpress;Database=ExcelImportDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select Sıra,Numarası,Adı,Soyadı from Ogrenci3", conn);

            List<Ogrenci3> ogrenci = new List<Ogrenci3>();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ogrenci.Add(
                      new Ogrenci3
                      {
                          Sıra = (int)dr["Sıra"],
                          Numarası = (int)dr["Numarası"],
                          Adı = (string)dr["Adı"],
                          Soyadı = (string)dr["Soyadı"]
                      }) ; 
            }
            conn.Close();

            return View(ogrenci);
        }
       
        public ActionResult KisiM110()
        {
            return View();
        }
        [HttpPost]
        public ActionResult M110(int Sutun1, int Sutun2, int Sutun3)
        {
            ViewBag.su1 = Sutun1;
            ViewBag.su2 = Sutun2;
            ViewBag.su3 = Sutun3;

            SqlConnection conn = new SqlConnection("Server=DESKTOP-MC7TQNE\\SQLExpress;Database=ExcelImportDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select Numarası,Adı,Soyadı from Ogrenci3", conn);

            List<Ogrenci3> ogrenci = new List<Ogrenci3>();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ogrenci.Add(
                      new Ogrenci3
                      {
                          Numarası = (int)dr["Numarası"],
                          Adı = (string)dr["Adı"],
                          Soyadı = (string)dr["Soyadı"]
                      });
            }
            conn.Close();

            return View(ogrenci);
        }
        
        
    }
}