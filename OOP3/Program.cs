using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interfacelerde o intefaceı implemente eden classın referans numarasını tutabilir.
            // referans no: IhtiyacKrediManager, TasitKrediManager, KonutKrediManager
            // aynı interface değilde normal classlarda olduğu gibi.
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICrediManager tasitKrediManager = new TasitKrediManager();
            ICrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Calculate(); // Bunu BasvuruManager içerisinde yazdığımız için 
            // 18.satırda basvuruManager içerisinde BAsvuruYap methodunu çağırıyoruz.

            ILoggerService dbLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService); // parantez içerisinde ekrandan seçilen öğremin girildiğini düşün.
            basvuruManager.BasvuruYap(tasitKrediManager, loggers);
            // basvuruManager.BavuruYap(konutKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() });
            // basvuruManager.BavuruYap(konutKrediManager, smsLoggerService);

            
            List<ICrediManager> credits = new List<ICrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            // basvuruManager.KrediOnBilgilendirmesiYap(credits);



        }
    }
}
