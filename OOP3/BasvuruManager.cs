using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // herkesin referansını tutmak için CrediManager'ın parametresini almalıyım.
        // parantez içine hangi krediyi çağırısan onun hesaplası çalışır.

        //method injection : basvuruyap methodunun hangi interface'i kullancağını enjekte ediyoruz.
        /// <summary>
        /// public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService){loggerService.Log();}

        /// </summary>
        public void BasvuruYap(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {

            // Başvuran bilgilerini değerlendirme

            // böyle yaparsam tüm başvurları sadece konut kredisi üzerinden değerlendirmiş olurum. YANLIŞ.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Calculate();

            crediManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credits)
        {
            //listede li kredileri dolaş ve hangisi seçiliyse onu hesapla
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
