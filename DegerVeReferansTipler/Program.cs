using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 65;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 kaç ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar[0] ? 999

            // int, string, double,float,bool -> değer tip
            // array, class, interface -> referans tip


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Seda";

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Employee employee = new Employee();

            Person person3 = customer;

            //person3. dediğimizde creditcarta erişemiyoruz 
            ///çünkü person classı içerisinde öyle bir değerimiz yok.
            ///creditcardnumber değerine eişmek için Customer class'ına boxing yapıyoruz.
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }


    //base class -temel sınıf:person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
