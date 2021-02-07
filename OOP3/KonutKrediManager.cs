using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    /// <summary>
    /// bir interface'ı ebeveyn olarak kullanan class lar mutlaka interface içerisindeki methodları kullanmalı.
    /// Bu class da methodları kullanmak için, "ICrediManager" altı çizili kelime üzerinde geldiğinde,
    /// çıkan ampüle tıkla ve "Implement Interface"'e bas
    /// </summary>
    class KonutKrediManager : ICrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
