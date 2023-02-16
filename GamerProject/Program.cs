using System;

namespace GamerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Gamer gamer1 = new Gamer(); // Burada instiance denkelemin tamamı yazılarak gösterildi.
            gamer1.Id = 11;
            gamer1.FirstName = "KORHAN";
            gamer1.LastName = "DALMAZ";
            gamer1.IdentityNumber = 111111111111; // Yanlış veri girilmiş ve ona göre sonuç alınmıştır.

            GamerManager gameManager = new GamerManager(new GamerDogrulamaManager());
            gameManager.Add(gamer1);



            OrderManager orderManager = new OrderManager(new Kampanya { Id = 11434, KampanyaName = "Yeni Kampanya", KampanyaNo = "1468" }); // Kampanya Class'ı OrderManager'e enjekte oldu.
            orderManager.Order(new Gamer { FirstName="FURKAN",LastName="DALMAZ",Id=123,IdentityNumber=12234}); // Burada instiance denklemin sadece sağ tarafı new kısmı kullanılarak gösterişmiştir
                                                                                                               // AMAÇ 2 ŞEKİLDE DE İNSTİANCE YAPILDIĞINI GÖSTERMEKTİR.     
        }
    }
}
