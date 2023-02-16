using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal interface IKampanyaManager
    {
        void Add(Kampanya kampanya);
        void Uptade(Kampanya kampanya); 
        void Delete(Kampanya kampanya); 

    }
}
