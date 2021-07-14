using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + "kişisi eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + "kişisi silindi.");
        }

        public void List(Customer customer)
        {
            
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
        }


    }
}
