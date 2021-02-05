using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)//main içinde ne varsa o çalışır
        {
            // do not repeat yourself - Kendini tekrarlama

            // değişkenler veri tutar, veri değişkenler ile yönetilir.
            // type safety - tip güvenliği
            // verileri çift tırnak ile yaz.
            // kategoriEtiketi bir değer tutucu, alias(takma ismi)

            //VERİ TİPLERİ //
            //string - text değerlerini tutar
            // int sayısal değerleri tutar.Çift tırnak içinde yazılmaz
            //double veri tipi ondalıklı sayı değerlerini tutar.
            //bool - boolean true ve false değeri alır.

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.50;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            // ŞART BLOKLARI //

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            // 
        }
    }
}
