using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarNew
{
    internal class SepetManager
    {
        //naming conventions doğru yazış şekli
        //pyhton da def ile yapılan metot işemi yapılyor..
        //normal parantez görüyosan metot tutuyor anlamına gelir.

        public void Ekle(Product product) // burada parametre eklemiş olduk.Ne ekleyeceğimizi belirttik
        {
            Console.WriteLine("Sepete Eklendi"+":"+product.UrunAdi);
        
        }
        public void Ekle2(string productName, string productAciklama, double ProductFiyatı) //sıkıntılı kullanım bu metotda bir değişiklik olduğu zaman metodun kullanıldığı her yerde değişiklik olacak.
        {
            Console.WriteLine("Sepete Eklendi" + ":" +productName);
        }

    }
}
