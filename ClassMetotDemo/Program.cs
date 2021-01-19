using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Metin Reha";
            customer1.Surname = "Ermetin";
            customer1.Id = 3169420;
            customer1.Funds = 666;

            Customer customer2 = new Customer();
            customer2.Name = "Buğra Taşkın";
            customer2.Surname = "Yalçın";
            customer2.Id = 67567555;
            customer2.Funds = 313166;

            Customer[] customerarray = new Customer[] { customer1, customer2 };
            

            //Methods
            CustomerManager custommanager = new CustomerManager();
            custommanager.Add(customer1);
            Console.WriteLine("--------------customer1 add---------------\n");

            custommanager.Delete(customer1);
            Console.WriteLine("-------------customer1 delete----------------\n");

            custommanager.Add(customer2);
            Console.WriteLine("---------------customer2 add--------------\n");

            custommanager.Delete(customer2);
            Console.WriteLine("-------------customer2 delete----------------\n");

            custommanager.Make_a_List(customerarray);
            Console.WriteLine("------customer1 and customer2 make a list------");

        }
    }
}
