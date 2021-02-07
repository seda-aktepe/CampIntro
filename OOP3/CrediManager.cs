using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    /// Tüm kredi manager classları hesapla işini farklı elealır.
    /// CrediManager tüm kredi managerlar için ebeveyn (base) görevi görür. Ancak tek başına bir anlam ifade etmez.
    /// Bu tip alternatif yani imzanın(void Calculate()) aynı olduğu ama içerisinin farklı olduğu durumlarda
    /// base de oluşturduğumuz classı class olarak değilde interface olarak oluştururuz.
    /// 
    //  class CrediManager
    //  {
    //      public void Calculate()
    //      {

    //      }
    //  }


    // Kodun son hali;
    /// interface aslında şablon görevi görür.
    /// eğer birisi bir interface kullanırsa aşağıda ki metodu kullanmak zorunda
    /// bir interface'in birden fazla methodu olabilir.
    /// okunurluğu bilinsin diye interface adlarının başında "I" olur.
    /// bir interface'ı ebeveyn olarak kullanan class lar mutlaka interface içerisindeki methodları kullanmalı.
    /// interface'i genellikler operayonel metodlarda kullanırız.
    interface ICrediManager
    {
        void Calculate();
        void BiseyYap();
    }
    //** interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    // Credi Manager bir interface ve bu interface'ı kullanan classlar, interface içerisinde ki methodları kullanmak zornda.
}
