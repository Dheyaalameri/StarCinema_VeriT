using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCinema
{
   public class Musteri 
    { 
      public Guid ID { get; set; }
      public string AD { get; set; }
      public string Soyad { get; set; }
      public string Telefon { get; set; }
      public string Email { get; set; }
      public string Adres { get; set; }

        public override string ToString()
        {
            return $"{AD} {Soyad}";
        }
    }

    public class Film
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public string Tur { get; set;}
        public string Sure { get; set; }
        public string Yoneten { get; set; }
        public string YapimYili { get; set;}
        public override string ToString()
        {
            return $"{AD} {Sure}";
        }

    }

    public class Gosterim 
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public Guid FilmID { get; set; }
        
        public string Saat { get; set; }
        public string Salon { get; set; }
        public string koltuk { get; set; }
        public DateTime tarih {  get; set; }
        public double Fiyat { get; set; }

    }

    public class Odeme 
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public double Tutar {  get; set; }
        public DateTime tarih { get; set; }
        public string Tur { get; set; }
        public string Aciklama { get; set; }

    }
}
