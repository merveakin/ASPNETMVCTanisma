﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCTanisma.Models;

namespace WebApplicationMVCTanisma.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()
        {
            List<Ogrenci> ogrList = Ogrenci.OgrencileriGetir();
            return View(ogrList);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Ogrenci ogr)
        {
            //veri tabanı bulunmadığından Id'yi kendimiz burada oluşturuyoruz.
            var tumOgrler = Ogrenci.OgrencileriGetir();
            ogr.Id = tumOgrler.Count + 1;

            //Öğrenci eklemesi yapalım.
            Ogrenci.OgrenciListesi.Add(ogr);
            //Ekleme yapıldıktan sonra Listele Action'ına redirect olalım.

            return RedirectToAction("Listele");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            //gelen id>0 ise listede onu bulu Vİew'e gönderecek.
            if (id > 0)
            {
                Ogrenci bulunanOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x => x.Id == id);
                return View(bulunanOgr);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Guncelle(Ogrenci ogr)
        {
            Ogrenci guncellenecekEskiOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x => x.Id == ogr.Id);

            if (guncellenecekEskiOgr != null)
            {
                ////Öğrenciyi bulduk. Bulunan öğrenciye yeni değerler atanacak.
                //guncellenecekEskiOgr.Ad = ogr.Ad;
                // = işaretinin sağında Güncelle sayfasına girdiğimiz bilgiyi aldık ve bizdeki mevcut öğrenciye atadık.
                guncellenecekEskiOgr.Ad = ogr.Ad;
                guncellenecekEskiOgr.Soyad = ogr.Soyad;
                guncellenecekEskiOgr.DogumTarihi = ogr.DogumTarihi;
            }


            return RedirectToAction("Listele");
        }

        [HttpGet]
        public ActionResult Sil(int id)
        {
            var silinecekOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x=> x.Id==id);
            return View(silinecekOgr);
        }

        [HttpPost]
        public ActionResult Sil(Ogrenci ogr)
        {
            if (ogr.Id > 0)
            {
                Ogrenci.OgrenciListesi.Remove(ogr);
            }
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public ActionResult Sil2(Ogrenci ogr)
        {
            if (ogr.Id>0)
            {
                Ogrenci.OgrenciListesi.Remove(ogr);
                return Json(new { success = true });
            }
            return Json(new { success = false, error = "Beklenmedik hata oluştu!" });
        }

    }
}