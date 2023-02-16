using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class KampanyaManager : IKampanyaManager
    {
        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Added");
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Deleted");
        }

        public void Uptade(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Uptaded");
        }
    }
}
