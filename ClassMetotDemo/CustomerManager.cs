using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Musteri customer)
        {
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.Age + " kişisi eklendi.");
        }

        public void Delete(Musteri customer)
        {
            Console.WriteLine(customer.Id + "numaralı müşteri silindi");
        }

        public void List(Musteri customer)
        {
            Console.WriteLine("Id:" + customer.Id);
            Console.WriteLine("Adı:" + customer.Name);
            Console.WriteLine("Soyadı:" + customer.Surname);
            Console.WriteLine("Yaşı:" + customer.Age);
            Console.WriteLine("----------");
        }
    }
}
