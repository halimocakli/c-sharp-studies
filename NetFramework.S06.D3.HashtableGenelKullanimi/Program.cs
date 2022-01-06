using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S06.D3.HashTableGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ArrayList ve Array sınıflarında elemanlara erişmek için bir index numarası kullanıyorduk. Ancak bazen index numrası yerine bir koleksiyondaki elemanlara
             * bir anahtar değer ile erişmek isteyebiliriz. Bu durumu simule eden sınıf System.Collections isim alanında bulunan HashTable sınıfıdır. HashTable sınıfında
             * koleksiyonlar bir anahtar(key)-değer(value) ikilisi olarak saklanır. Yani belirlenen anahtarlara ilişkin çeşitli değerleri tutmak için HashTable sınıfını
             * kullanabiliriz. HashTable ile anahtar ve değer ikilisi hash tablosu denilen bir tabloda saklanmaktadır. Her bir ikiliyi temsil eden bir hash kodu vardır.
             * Bu hash kodu bir anahtar-değer ikilisinin tek/biricik olmasını sağlamaktadır. Biz bir hash tablosundaki bir anahtara karşılık gelen değeri elde etmek
             * istediğimizde bu hash kodu kullanılır. Dolayısıyla bir anahtara karşılık gelen değeri elde etmek için maksimum performans sağlanır. Hash tablosu sayesinde
             * çok sayıda anahtar değer ikilisi içeren koleksiyonlarda arama ve anahtar değerlerinin karşılığını elde etme gibi işlemler daha kısa sürede gerçekleşir.
             */

            Hashtable H1 = new Hashtable();

            // key değeri hashtable içerisinde benzersiz olmak durumunda ancak value değeri için aynı durum söz konusu değil.
            // Yani aynı anahtar değeri bir daha eklediğimizde hata alırız.

            #region Yeni Değer Ekleme

            /*
             * Bir HashTable koleksiyonu oluşturduktan sonra koleksiyona bir anahtar-değer çifti eklemek için HashTable sınıfının Add() metodunu ya da
             * HashTable sınıfındaki indexleyici kullanılır. 
             */

            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");
            H1.Add("Cars", "Araba");
            H1["Key4"] = "Value4";  // İndexleyici kullanarak

            /*
             * Add()
             */

            /*
             * H1.Add("Cars", "Araba");
             * H1.Add("Cars", "Arabalar");
             *
             * Yukarıdaki kullanım hata verecektir.
             */

            #endregion

            #region HashTable Değer Değiştirme

            H1["House"] = "Villa";
            // House key değerinin karşısındaki value değeri "Ev"di. Bunu "Villa" olacak şekilde değiştirdik.

            #endregion

            #region Yardımcı Metotlar

            // Contains() metodu, verilen key değerinin listede olup olmadığını kontrol eder ve buna göre TRUE-FALSE döndürür.

            bool Kontrol1 = H1.Contains("House");   // True
            bool Kontrol2 = H1.Contains("Door");    // False

            // ContainsKey() metodu, Contains() metodu ile aynı işleve sahiptir

            bool Kontrol3 = H1.ContainsKey("House");

            // ContainsValue() metodu, Contains() ve ContainsKey() metodundan farklı olarak "key" değeri yerine "value" değerini inceler.

            bool Kontrol4 = H1.ContainsValue("Ev");

            // Count() metodu ile kolleksiyon içerisinde kaç değer var olduğunu görebilir ve yazdırabiliriz.

            int kolleksiyonIcindekiToplamDeger = H1.Count;

            // Remove() metodu, içerisine bir key alır ve bu keyin karşılığındaki value değerini key değeri ile birlikte ortadan kaldırır.
            // Remove() metodu ile belirtilen anahtar değer eğer null referans ise ArgumentNullException istisnai durumu oluşur.
            // Eğer belirtilen anahtar sadece okunabilir ya da HashTable sınıfı sabit kapasiteli ise NotSupportedException istisnai durumu oluşur.

            H1.Remove("Cars");

            /* void CopyTo(Array dizi, int index) Metodu
             *
             * HashTable içindeki key-value çiftlerini bir boyutlu Array dizisine indeks elemanından itibaren kopyalar. Kopyalama işleminin yapıldığı dizi
             * DictionaryEntry sınıfı türündendir. DictionaryEntry sınıfı ile bir key-value ikilisi temsil edilir. DictionaryEntry sınıfındaki Key ve Value
             * özellikleri ile anahtar ve değerlere erişilebilir. Sadece H1 nesnesindeki anahtarları bir diziye kopyalamak için:
             */

            object[] array = new object[3];
            H1.Keys.CopyTo(array, 0);

            foreach (var VARIABLE in array)
            {
                Console.WriteLine("Key: {0}",VARIABLE);
            }

            // H1 nesnesi içerisindeki değerleri diziye kopyalamak için:

            H1.Values.CopyTo(array,0);

            foreach (var VARIABLE in array)
            {
                Console.WriteLine("Value: {0}",VARIABLE);
            }

            // Key-Value değerlerini birlikte yazdırmak için

            foreach (DictionaryEntry VARIABLE in H1)
            {
                Console.WriteLine("Key: {0} - Value: {1}", VARIABLE.Key, VARIABLE.Value);
            }

            // Clear() metodu, kolleksiyon içerisindeki tüm değerleri siler.

            H1.Clear();

            #endregion

            Console.ReadLine();
        }
    }
}
