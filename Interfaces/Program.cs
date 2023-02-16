using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager= new CustomerManager();
            //customerManager.Add();
            PersonManager personManager = new PersonManager();
            personManager.Add(new EmployeeManager()); //instance vermenin amacı referansı göstermektir referansta denklemin sağ tarafında new ile gösterilir.
        }
    }
}
