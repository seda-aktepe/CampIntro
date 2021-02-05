using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////burası heap de yeni bir alan oluşturdu
            //string[] isimler = new string[] { "Seda", "Engin", "Murat", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ///// arraylar süslü parantez dışında index tanımlandığında çalışmaz
            ///// burada heap te tekrardan bir alan oluşturdun ve 4.sıraya ilkeri atadın
            ///// ancak 0.sırada kimse olmadığı için ekrana bir şey basmaz.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>(); //birinci yöntem
            List<string> isimler4 = new List<string> { "Seda", "Engin", "Murat", "Kerem" }; //ikinci yöntem
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
