using System;

namespace DongulerNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // döngüler birbirini tekrar eden yapılarda kullanılır.
            for (int i = 1; i <= 10; i++)
            {
               Console.WriteLine(i);
            }
            // array diziler
            string[] kurslar = new string[]
            {
                "python","c#","c++","java"
            };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            string etiketIsmı = "Kazak";
            Console.WriteLine(etiketIsmı); // 1.Sayfa içi simüle edildi.
            Console.WriteLine(etiketIsmı); // 2.Sayfa içi simüle edildi.
            Console.WriteLine(etiketIsmı); // 3.Sayfa içi simüle edildi.
            Console.WriteLine(etiketIsmı); // 4.Sayfa içi simüle edildi.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
