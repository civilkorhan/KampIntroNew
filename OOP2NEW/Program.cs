using System;

namespace OOP2NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = "1122";
            musteri1.MusteriIsmi = "Korhan DALMAZ";
            musteri1.TcNo = "1133";

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = "1144";
            musteri2.SirketIsmi = "Dalmaz Holding";
            musteri2.VergiNo = "2288";

            Musteri musteri3 = new GercekMusteri(); // Musteri class'ı gerçek musterinin referansını tutabilir.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteri=new MusteriManager();
            musteri.Ekle(musteri4);

        }
    }
}
