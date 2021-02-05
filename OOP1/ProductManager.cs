using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        /// int toplamaSonucu = productManager.Topla(3,6);
        /// burada return kullanma amacımız ortaya çıkan değeri daha sonra
        /// kullanabilmek.
        /// Çıkan sonucu toplamaSonucu değişkenine atarız.
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /// void = emir kipidir. Git yap bitir.
        /// Ancak void kullanımında sadece fonksiyona verilen işlem yapılır.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
