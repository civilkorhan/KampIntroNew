using System;

namespace MetotlarNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Product urun1=new Product();
            urun1.Id = 111455;
            urun1.UrunAdi = "Kazak";
            urun1.UrunFiyati = 35;
            urun1.Aciklama = "Kışlık Kazak";
            urun1.StokAdedi = 10;

            Product urun2 = new Product();
            urun2.Id = 111454;
            urun2.UrunAdi = "Mont";
            urun2.UrunFiyati = 99;
            urun2.Aciklama = "Kaşe Mont";
            
            Product urun3 = new Product();
            urun3.Id = 111452;
            urun3.UrunAdi = "Atkı";
            urun3.UrunFiyati = 17;
            urun3.Aciklama = "Yün Atkı";

            Product[]Products=new Product[] {urun1,urun2,urun3};
            foreach (Product product in Products)
            {
                Console.WriteLine(product.UrunAdi+":"+product.UrunFiyati);
            }
            Console.WriteLine("****Metotlar****");
            //instance:örneklendirme demektir.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Telefon","Akıllı Telefon",1000);

            sepetManager.Ekle2("Telefon", "Akıllı Telefon", 1000);


            sepetManager.Ekle2("Telefon", "Akıllı Telefon", 1000);





        }
    }
    // metotlar tekrar tekrar kullabilirliği artıran çözümlerdir.
}
