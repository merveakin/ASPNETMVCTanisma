﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVCTanisma.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public static List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>();

        public static List<Ogrenci> OgrencileriGetir()
        {
            if (OgrenciListesi.Count == 0)
            {
                OgrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(){Id=1, Ad="Merve",Soyad="Akın",DogumTarihi=new DateTime(1992,11,14) },
                 new Ogrenci(){Id=2, Ad="Melike",Soyad="Akın",DogumTarihi=new DateTime(1990,11,14) },
                  new Ogrenci(){Id=3, Ad="Furkan",Soyad="Akın",DogumTarihi=new DateTime(1991,11,14) },
                   new Ogrenci(){Id=4, Ad="Kaan Ali",Soyad="Yıldırım",DogumTarihi=new DateTime(1980,11,14) }
            };
            }
            return OgrenciListesi;
        }
    }
}