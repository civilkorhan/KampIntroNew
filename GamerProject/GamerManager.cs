using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class GamerManager : IGamerService
    {
        IGamerDogrulamaService _gamerDogrulamaService;

        public GamerManager(IGamerDogrulamaService gamerDogrulamaService)// GamerManager ı burada Doğrulama interface'ine bağımlı hale getirdik.
        {
            this._gamerDogrulamaService = gamerDogrulamaService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerDogrulamaService.Dogrulama(gamer)==true)
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("Gamer Not Added");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Uptade(Gamer gamer)
        {
            Console.WriteLine("Gamer Uptaded");
        }
    }
}
