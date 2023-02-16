using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class OrderManager : IOrderService
    {
        IKampanya _kampanya;

        public OrderManager(IKampanya kampanya)
        {
            _kampanya = kampanya;
        }

        public void Order(Gamer gamer)
        {
            Console.WriteLine("Satış Gerçekleştirildi: "+gamer.FirstName);
        }
    }
}
