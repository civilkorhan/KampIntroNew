using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TasitKrediManger tasitKrediManger = new TasitKrediManger();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

            
            FileLoggerService fileLoggerService = new FileLoggerService();
            DataBaseLoggerService dataBaseLoggerService = new DataBaseLoggerService();
            SmsLoggerService smsLoggerService = new SmsLoggerService();

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManger, konutKrediManager };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManger, new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService(), new FileLoggerService() });

            basvuruManager.KrediOnBilgilendirme(krediler);
        }
    }
}
