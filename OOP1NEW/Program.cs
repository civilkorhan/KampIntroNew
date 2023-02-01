using System;

namespace OOP1NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 2;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 100;
            product1.UnitsInStock = 10;
           ////PascalCase    camelCase
           // ProductManager productManager;
           // string isim;
           ProductManager productManager=new ProductManager();
            productManager.Add(product1);
            productManager.Uptade(product1);
            productManager.Topla(56, 92);
           
          
            int sonuc2 = productManager.Topla(56, 92);
            Console.WriteLine(sonuc2*2);

        }
    }
}
