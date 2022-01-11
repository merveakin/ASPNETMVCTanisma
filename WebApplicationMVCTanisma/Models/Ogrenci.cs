using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCTanisma.Models
{
    public class Ogrenci : IEquatable<Ogrenci>
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Öğrenci adı boş geçilemez!")]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Adınız 2 ile 20 karakter aralığında olmalıdır!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Öğrenci soyadı boş geçilemez!")]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Soyadınız 2 ile 20 karakter aralığında olmalıdır!")]
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }

        public static List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>();

        public static List<Ogrenci> OgrencileriGetir()
        {
            if (OgrenciListesi.Count == 0)
            {
                OgrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(){Id=1, Ad="Merve",Soyad="Akın",DogumTarihi=new DateTime(1996,04,26) },
                new Ogrenci(){Id=2, Ad="Melike",Soyad="Akın",DogumTarihi=new DateTime(1999,11,30) },
                new Ogrenci(){Id=3, Ad="Furkan",Soyad="Akın",DogumTarihi=new DateTime(2006,01,06) },
                new Ogrenci(){Id=4, Ad="Kaan Ali",Soyad="Yıldırım",DogumTarihi=new DateTime(2019,08,07) }
            };
            }
            return OgrenciListesi;
        }

        public bool Equals(Ogrenci other)
        {
            return Id == other.Id;
        }
    }
}