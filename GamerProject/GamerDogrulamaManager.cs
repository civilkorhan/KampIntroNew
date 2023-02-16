using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class GamerDogrulamaManager : IGamerDogrulamaService
    {
        public bool Dogrulama(Gamer gamer)
        {
            if (gamer.FirstName == "KORHAN" && gamer.LastName == "DALMAZ" && gamer.Id == 11 && gamer.IdentityNumber == 11111111111)
            {
                return true;
            }
            else (
            {
                return false;
            }
            
                
            
        }
    }
}
