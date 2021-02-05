using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T verdiğim tipe karşılık gelir.string int bool vs
    {
        T[] items; //dizi
        // Main içerisinde mylist'i(class) newledğimizde aşağıdaki constructor çalışır.
        // bir class(MyList) newlendiğinde çalışan bloğa constructor denir.
        public MyList()//constructor
        {
            items = new T[0];
            // 0 elemanlı bir items arrayı oluşturduk
        }
        public void Add(T item)
        {
            //dizinin ilk elemanını geçiçi arrrayde tutarız
            T[] tempArray = items;
            //yukarıda 0 elemanlı bir dizi oluşturduk.
            //Bu 0 elemanlı diziye bir değer ataması yapmak için items arrayını 1 arttırıyoruz.
            // Diziye her değer ataması yaptığımızda heap de yeni bir alan oluşur ve eski değerleri tempArray tutar.
            items = new T[items.Length + 1];
            //Diziye her eleman eklemesi yapıldığında tempArrayın tuttuğu değer uçar.
            // tempArraydeki eski değerlerin uçmaması için bir döngü yazıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                //tempArray deki değerleri items'a atadık.
            }

            //tempArray deki 5elemanı items arraye geçirdikten sonra sonda ki kalan bir boş elemanı itemın son elemanına atamasına yaptık.
            items[items.Length - 1] = item;
        }
    }
}