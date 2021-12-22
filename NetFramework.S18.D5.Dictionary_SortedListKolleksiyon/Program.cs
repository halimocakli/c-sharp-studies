using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D5.Dictionary_SortedListKolleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Kolleksiyonlar konuları olan Dictionary ve Sort kolleksiyonları aslında Gneric olmayan tarafta işlediğimiz HashTable kolleksiyonu ile aynıdır.

            // Generic olmayan kolleksiyon davranışı
            Hashtable HashTableList = new Hashtable();
            HashTableList.Add(1, "Bir");
            HashTableList.Add(2, "İki");
            HashTableList.Add(3, true);
            HashTableList.Add(4, "Dört");
            // HashTableList.Add(4, "Beş"); => HATA
            // Hatırlarsanız Hashtable'da Key değeri Unique olmalıydı.

            // Kendi belirlediğimiz türlerden olacak şekilde tip güvenli Hashtable => Dictionary
            // Dictionary<TKey, TValue>

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "İki");
            DictionaryList.Add(3, "Üç");
            DictionaryList.Add(4, "Dört");
            DictionaryList.Add(5, "Beş");
            // DictionaryList.Add(1, "Test"); => HATA

            // Silinmesini istediğimiz key değerini liste içerisinde arama ve eğer varsa sildikten sonra True değeri yoksa False değeri geriye döndürmek
            // DİKKAT => Silmek için Remove() metoduna Key değeri verdik. Index değil.
            bool silmeKontrol = DictionaryList.Remove(2);
            if (silmeKontrol)
            {
                Console.WriteLine("Bildirdiğiniz değer silidi");
            }
            else
            {
                Console.WriteLine("Bildirdiğiniz değer liste içerisinde bulunamadı. Silme işlemi başarısız.");
            }
            // Key'i ve karşısındaki Value'yu listeden sildikten sonra hata ile sildiğimiz key değerine value atamak isteyebiliriz. Bunu engellemek için kontrol metotları kullanalım.
            // ContainsKey() metodu ile liste içerisinde Key değeri arayabiliriz. Bunun sonucunda geriye True veya False döner.
            bool arananKeySonucu = DictionaryList.ContainsKey(1);
            if (arananKeySonucu)
            {
                string gelenDeger = DictionaryList[1];  // 1 Keyinin karşılığı olan Value değerini ele alıyoruz çünkü gelenDeğer değişkeninin türü string
                gelenDeger = "Yenilenen Değer";
                DictionaryList[1] = gelenDeger;
                // DictionaryList[1]'e yani 1 Key değerine gelenDeger değişkenini atadık. Böylece Value değiştirebildik.
            }
            else
            {
                Console.WriteLine("Aranan Key değeri kolleksiyon içerisinde bulunamadı");
            }

            // Yukarıdaki işlemleri Value için de yapabiliriz.

            bool arananValueSonuc = DictionaryList.ContainsValue("Beş");
            if (arananValueSonuc)
            {
                Console.WriteLine("Aradığınız Value değeri bulundu");
            }
            else
            {
                Console.WriteLine("Aranan Value değeri bulunamadı");
            }

            // foreach ile içerideki değerleri okuyalım
            foreach (KeyValuePair<int, string> VARIABLE in DictionaryList)
            {
                Console.WriteLine("Key : {0} || Value : {1}", VARIABLE.Key, VARIABLE.Value);
            }

            // DictionaryList içerisindeki her şeyi silmek için Clear() metodu kullanılır
            DictionaryList.Clear();

            // SortedList kolleksiyonu DictionaryList kolleksiyonunun yaptığı her şeyi yapar ve neredeyse aynısıdır.
            // Fark olarak; int üzerinden konuşacak olursak küçükten büyüğe doğru sıralama yapar.
            SortedList<int, string> SortedList = new SortedList<int, string>();
            SortedList.Add(1, "Bir");
            SortedList.Add(2, "İki");
            SortedList.Add(3, "Üç");
            SortedList.Add(4, "Dört");
            SortedList.Add(5, "Beş");
            SortedList.Add(2000, "İki Bin");
            SortedList.Add(1000, "Bin");
            SortedList.Add(0, "Sıfır");
        }
    }
}
