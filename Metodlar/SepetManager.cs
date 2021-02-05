using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        /// <summary>
        /// name convention
        /// </summary>
        public void Ekle(Urun urunx)
        {
            Console.WriteLine("sepete eklendi: " + urunx.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("sepete eklendi:" + urunadi);
        }
    }
}
