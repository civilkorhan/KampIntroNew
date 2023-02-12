using System;

namespace AssignClasses
{
    internal class Program
    {
        static void Main(string[] args)
        { Person person1 = new Person();
            person1.PersonalId = 123;
            Person person2 = new Person();
            person2.PersonalName = "Korhan";

            Customer customer = new Customer();
            customer.PersonalName = "Furkan";

            Person person3 = new Customer(); // person burada customer'ında adresini tutabildiğini gösterdim.


            customer.PersonalName = "Şevval";
            Console.WriteLine(customer.PersonalName);
            Console.WriteLine(person3.PersonalName);

            Employee employee = new Employee();
            employee.PersonalName = "Coşkun";

            PersonalManager personalManager = new PersonalManager();
            personalManager.Add(employee); // burada metoda person atanmasına rağmen employee de gönderebildim.Aynı kodu farklı nesneler için de kullanabildim.
                
           


        }
    }
    class Person
    {
        public int PersonalId { get; set; }
        public string PersonalName { get; set; }
        public string PersonalLastName { get; set; }
    }
    class Customer : Person
    {
        public int CreditCardId { get; set; }

    }
    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }
    class PersonalManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.PersonalName);
        }
    }
        
        

}
