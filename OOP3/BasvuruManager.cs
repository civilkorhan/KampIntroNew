using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager kredimanager,List<ILoggerService> loggerServices)  // parametre atadık tüm kredileri tutabilen ve toplu halde birden fazla çağırılacak ise list kullandık lojik kısmına dikkat.
        {                                                                                       //  burada List<ILoggerServices> ekleyerek Method injection yaptık.
            //KonutKrediManager konutKrediManager=new KonutKrediManager();  // Tüm başvurular konut kredisi üzerinden hesaplanır.
            //konutKrediManager.Hesapla();
            //

            kredimanager.Hesapla();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.log();
            }
        }
        public void KrediOnBilgilendirme(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

