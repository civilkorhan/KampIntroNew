using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoNew
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriIsmi+" " +musteri.MusteriSoyismi+" Eklendi");
        }
        public void Cıkar(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriIsmi + " " + musteri.MusteriSoyismi + " Çıkarıldı");
        }
        public void Guncellendi(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriIsmi + " " + musteri.MusteriSoyismi + " Güncellendi");
        }
      
    }
}


    

