using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // DÖNGÜLER //
            // birbirini tekrar eden işlemler için kullanılan yapılardır.

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine("************************************************");
            //array - diziler

            string[] kurslar = new string[] {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python",
                "C++",
                "C#"
            };

            for (int i = 0; i < kurslar.Length; i++)
            // i sayaç demek.
            // i++ durumu bir bir arttırır.
            // i=i+2 veya i+=2 şeklinde yazılırsa 2 2 arttırır.
            // kurslar.Length ifadesi kurslar array(dizi)'indeki kurs sayısı kadardır.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti, şimdi foreach zamanı :)");

            foreach (string kurs in kurslar)
            // foreach dizilerde kullanılır.
            // foreach dizi temelleri yapıları tek tek her bir elemanı dolaşmaya yarar.
            // in kurslar = kursları dolaş
            // kurs ifadesi bir alias'dır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

            // Java da yukarı kodları çalıştırmak istersen sadece 
            // console.writeline ifadesini System.out.println yazmak ve veri tiplerinin baş harflerini büyütmek gerekir.
        }
    }
}
