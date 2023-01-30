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
        }
        class Kurs
        {
            public string KursEgitmeni { get; set; }
            public string kurs { get; set; }
            public int IzlenmeOranı { get; set; }
        }
       

        
    }
}
