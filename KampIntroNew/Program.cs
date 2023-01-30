using System;

namespace KampIntroNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // değişkenler veri tutuculardır.
            // type safety
            // önce bir değer tutucu yap sonra onu yazdır her değişiklikte tek bir yeri değiştirerek devam et.
            string kategoriEtiketi = "Kategoriler";
            Console.WriteLine(kategoriEtiketi); 
            // double ondalıklı sayılar için 
            // bool şart bloğu
            bool sistemeGirişYapmışMı=false;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Botonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Botunu");
            }
                   
            if (sistemeGirişYapmışMı==true)
            {
                Console.WriteLine("Kullanıcı Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
