using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1NEW
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler.Ürün Eklendi: " + product.ProductName);
        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi");
        }
        public int Topla(int sayi1, int sayi2)
            {
            return sayi1 + sayi2;  // burada çıkan sonucu başka bir yerde kullanabilirim.
            
            
            }
        public void Topla2(int sayi1,int sayi2)
        {
            Console.WriteLine( sayi1+sayi2 ); // burada çıkan sonucu başka bir yerde kullanamam.
        }
    }
}
