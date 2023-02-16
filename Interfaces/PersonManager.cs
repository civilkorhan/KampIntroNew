using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class PersonManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.add();
        }
    }
}
