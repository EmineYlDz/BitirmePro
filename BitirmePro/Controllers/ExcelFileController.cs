﻿using BitirmePro.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excel = Microsoft.Office.Interop.Excel;

namespace BitirmePro.Controllers
{
    public class ExcelFileController : Controller
    {
        // GET: ExcelFile
        public ActionResult Excel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(FormCollection formCollection)
        {
            var ogrenciList = new List<Ogrenci1>();
            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["UploadFile"];
                if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
                {
                    string filename = file.FileName;
                    string fileContentType = file.ContentType;
                    byte[] fileBytes = new byte[file.ContentLength];
                    var data = file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                    using(var  package = new ExcelPackage(file.InputStream))
                    {
                        //ExcelPackage ucretsiz lisans kullanımı için var!!
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        var currentSheet = package.Workbook.Worksheets;
                        var workSheet = currentSheet.First();
                        var noOfCol = workSheet.Dimension.End.Column;
                        var noOfRow = workSheet.Dimension.End.Row;
                        for (int rowIterator = 2; rowIterator<= noOfRow; rowIterator++)
                        {
                            var ogrenci = new Ogrenci1();
                            ogrenci.Id = Convert.ToInt32(workSheet.Cells[rowIterator, 1].Value);
                            ogrenci.AdSoyad = workSheet.Cells[rowIterator, 2].Value.ToString();
                            ogrenciList.Add(ogrenci);
                        }
                    }
                    ViewBag.mas2 = "Excel dosyanız başarıyla yüklendi!";
                }
               
            }

            using(ExcelImportDBEntities2 excelImportDBEntities = new ExcelImportDBEntities2())
            {
                foreach(var item in ogrenciList)
                {
                    excelImportDBEntities.Ogrenci1.Add(item);
                }
                excelImportDBEntities.SaveChanges();
            }
            return View("Excel");
        }
    }
}