using System;
using System.Collections.Generic;

namespace KoleksiyonlarNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>isimler = new List<string> {"Korhan","Furkan","Şevval"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            
            isimler.Add("Yeşim");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
            List<string> isimler2 = new List<string>();
            Console.WriteLine(isimler2.Count);

        }
    }
}
