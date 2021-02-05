using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Id = 123456789;
            customer1.Name = "Seda";
            customer1.Surname = "Aktepe";
            customer1.Age = 24;

            Musteri customer2 = new Musteri();
            customer2.Id = 123459876;
            customer2.Name = "Eda";
            customer2.Surname = "Kamış";
            customer2.Age = 18;

            Musteri customer3 = new Musteri();
            customer3.Id = 432156789;
            customer3.Name = "Hüsnü";
            customer3.Surname = "Şen";
            customer3.Age = 56;

            Musteri[] customer = new Musteri[] { };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("-------Eklenen Müşteri-------");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("-------Silinen Müşteri-------");
            customerManager.Delete(customer3);
            Console.WriteLine("-------Listenen Müşteri-------");
            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);
        }
    }
}
