using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            c1.Id = 1;
            c1.Name = "Zeynep";
            c1.Surname = "Demir";

            Customer c2 = new Customer();
            c2.Id = 2;
            c2.Name = "Merve";
            c2.Surname = "Deniz";

            Customer c3 = new Customer();
            c3.Id = 3;
            c3.Name = "Meryem";
            c3.Surname = "Demir";

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine();
            Console.WriteLine("--Ekleme İşlemi--");
            customerManager.Add(c1);
            customerManager.Add(c2);
            customerManager.Add(c3);

            Console.WriteLine();
            Console.WriteLine("--Silme İşlemi--");

            customerManager.Delete(c1);
            customerManager.Delete(c2);
            customerManager.Delete(c3);

            Console.WriteLine();
            Console.WriteLine("--Listeleme İşlemi--");

            customerManager.List(c1);
            customerManager.List(c2);
            customerManager.List(c3);


            




        }
    }
}
