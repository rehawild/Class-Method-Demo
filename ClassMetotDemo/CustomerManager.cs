using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine( customer.Name +" "+ customer.Surname +
                " isimli müşteri listenize eklendi ");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine( customer.Name +" "+ customer.Surname +
                " isimli müşteri listenizden silindi ");
        }

        public void Make_a_List(Customer[] customers)
        {
            //I MADE TWO DIFFERENT LOOPS FOR A BETTER UNDERSTANDING
            
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine(i+1 + ".Müşterinin Adı: " + customers[i].Name);
                Console.WriteLine(i+1 + ".Müşterinin Soyadı: " + customers[i].Surname);
                Console.WriteLine(i+1 + ".Müşterinin Id'si: " + customers[i].Id);
                Console.WriteLine(i+1 + ".Müşterinin Hesaptaki Toplam Para Miktarı : " + customers[i].Funds);
                Console.WriteLine("-----------------------------\n");
            } 

            /*
            foreach (Customer custom in customers)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Müşterinin Adı: " +  custom.Name);
                Console.WriteLine("Müşterinin Soyadı: " + custom.Surname);
                Console.WriteLine("Müşterinin Id'si: " + custom.Id);
                Console.WriteLine("Müşterinin Hesaptaki Toplam Para Miktarı: " + custom.Funds);
                Console.WriteLine("-----------------------------");
            }
            */
        }
    }
}
