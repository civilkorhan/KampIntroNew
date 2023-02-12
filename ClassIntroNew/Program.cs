using System;

namespace ClassIntroNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursEgitmeni = "Korhan DALMAZ";
            kurs1.kurs = "C#";
            kurs1.IzlenmeOranı = 10;
            
            Kurs kurs2=new Kurs();
            kurs2.KursEgitmeni = "Yalçın Ahmet YALÇIN";
            kurs2.kurs = "Pyhton";
            kurs2.IzlenmeOranı = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursEgitmeni = "Tarık Buğra KOCABIYIK";
            kurs3.kurs = "Herşey";
            kurs3.IzlenmeOranı = 5;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursEgitmeni+":"+kurs.kurs);
            }
            Product product1 =new Product();
            product1.ProductId = 1122;
            product1.ProductName = "Masa";
            product1.UnitPrice = 59.99;

            Product product2 = new Product();
            product2.ProductId = 1122;
            product2.ProductName = "Kamera";
            product2.UnitPrice = 54.99;

            Product product3 = new Product();
            product3.ProductId = 1122;
            product3.ProductName = "Televizyon";
            product3.UnitPrice = 79.99;

            Product[] products = new Product[] { product1, product2, product3 };
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı: "+products[i].ProductName);
            }
            Console.WriteLine("***For Bitti***");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("***Foreach Bitti***");
            int a = 0;
            while (a < 3) ;
            Console.WriteLine("Ürün Adı: " + product.ProductName);


        }
        class Kurs
        {
            public string KursEgitmeni { get; set; }
            public string kurs { get; set; }
            public int IzlenmeOranı { get; set; }
        }
       
       

        
    }
}
