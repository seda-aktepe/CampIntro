using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Seda";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#"; // KursAdi strgin oluşturulduğu için c# dedik
            kurs1.KursEgitmeni = "Seda";
            kurs1.izlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Engin";
            kurs2.izlenmeOrani = 101;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berkay";
            kurs3.izlenmeOrani = 102;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (var kurs in kurslar) //kurs bir takma isim x y z yazabilirsin
            {
                Console.WriteLine(kurs.KursAdi);
            }


        }
    }

    class Kurs // sanki kendi veri tipimi yazıyormuşum gibi
    {
        // aşağıdakiler bir element ve Kurs class'ı içinde tanımlanıyor.
        // aşağıdaki yazım şekli prop yaz tab tab yap.
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int izlenmeOrani { get; set; }
    }
}