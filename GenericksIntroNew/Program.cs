using System;
using System.Collections.Generic;

namespace GenericksIntroNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int,string>ogrenciler=new Dictionary<int,string>();
            ogrenciler.Add(11,"Korhan");
            Console.WriteLine(ogrenciler);
        }
    }
}
