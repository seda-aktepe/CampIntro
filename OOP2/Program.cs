using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //Seda Aktepe
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerId = 1;
            musteri1.CustomerNo = "12345";
            musteri1.CustomerName = "seda";
            musteri1.CustomerSurname = "aktepe";
            musteri1.CustomerTcNo = "22222222222";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.CustomerId = 2;
            musteri2.CustomerNo = "54321";
            musteri2.CompanyName = "kodlama.io";
            musteri2.TaxNo = "1234567890";


            //musteri classı hem gerçek hem tüzel müşterinin referansını tutabiliyor.
            //referans: GerçekMusteri, TuzelMusteri
            Musteri musteri3 = new GercekMusteri();
            musteri3.CustomerId = 3;
            musteri3.CustomerNo = "21345";

            Musteri musteri4 = new TuzelMusteri();
            musteri4.CustomerId = 3;
            musteri4.CustomerNo = "21345";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

        }
    }
}
