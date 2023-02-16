using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class EmployeeManager : IPersonManager
    {
        

        public void add()
        {
            Console.WriteLine("Employee Added");
        }
    }
}
