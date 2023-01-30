using System;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class'tan bir örnek oluşturuyoruz.Aşağıdaki yaptıpımız işlem bu.
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(55,78);

            dortIslem.Topla(11,3425);

            dortIslem.Topla(0,478);

            dortIslem.Topla(239056,33);


        }
    }
}
