using System;

namespace ClassMetotDemoNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1122;
            musteri1.MusteriIsmi = "Arzu";
            musteri1.MusteriSoyismi = "DALMAZ";
            musteri1.MusteriNo = 4455;
            Musteri musteri2 = new Musteri();
            musteri2.Id = 1122;
            musteri2.MusteriIsmi = "Korhan";
            musteri2.MusteriSoyismi = "DALMAZ";
            musteri2.MusteriNo = 4455;
            Musteri musteri3 = new Musteri();
            musteri3.Id = 1122;
            musteri3.MusteriIsmi = "Furkan";
            musteri3.MusteriSoyismi = "DALMAZ";
            musteri3.MusteriNo = 4455;
            Musteri musteri4 = new Musteri();
            musteri4.Id = 1122;
            musteri4.MusteriIsmi = "Şevval";
            musteri4.MusteriSoyismi = "DALMAZ";
            musteri4.MusteriNo = 4455;

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Cıkar(musteri2);
            musteriManager.Ekle(musteri4);


        }
    }
}
