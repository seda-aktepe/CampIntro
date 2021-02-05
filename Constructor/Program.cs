using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
        }
    }
    class Customer
    {
        // Default constructor ctor kısa yolu 
        public Customer()
        {
            Console.WriteLine("yapıcı blok çalıştı"); ;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
