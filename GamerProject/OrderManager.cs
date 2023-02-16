using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class OrderManager : IOrderService
    {
        IKampanyaManager _kampanyaManager;

        public OrderManager(IKampanyaManager kampanyaManager)
        {
            this._kampanyaManager = kampanyaManager;
        }

        public void Order(Gamer gamer)
        {
            Console.WriteLine("Satış Gerçekleştirildi: "+gamer.FirstName);
        }
    }
}
