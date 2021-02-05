using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyList<int> isimler = new MyList<int>();
            // MyList<Product> isimler = new MyList<Product>();

            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(15);

            Console.WriteLine("Hello World!");
        }
    }
}
