using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S06.D1.ArrayListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Arraylist, .Net kütüphanelerinden biri olan System.Collections'a ait bir sınıftır. Bu nedenle program içerisinde ArrayList kullanmak istiyorsak içinde bulunduğu kütüphaneyi
             * çağırmalıyız. ArrayList, klasik dizilerle çalışırken karşılaştığımız birçok sorunu ortadan kaldıran yeni bir koleksiyon sınıfıdır. Klasik dizilerle çalışırken dizinin boyutunun
             * derleme aşamasında bilinmesi zorunluluğu vardı. ArrayList ile oluşturacağımız nesneler için böyle bir kısıtlama yoktur. Çalışma zamanında koleksiyona istediğimiz gibi
             * yeni nesneler ekleyebilir ve koleksiyondan yeni nesneler çıkarabiliriz. Klasik diziler aynı tür elemanları içeren koleksiyonlardır. Fakat ArrayList ile farklı türden nesneleri
             * aynı koleksiyon içerisinde saklayabiliriz. Farklı türden nesnelerin aynı koleksiyon içerisinde bulunması "boxing" ve "unboxing" işlemleri kullanılarak sağlanır.
             *
             * Klasik diziler ile çalışırken çoğu zaman diziyi ne kadar büyüklükte açacağımız belli olmaz. Bu tür durumlarda dizi yeteri kadar büyüklükte açılır. Açılan dizinin
             * elemanları çoğu durumda kullanılmayan gereksiz bilgiler de olabilir. Bu durumda performans kaybı meydana gelir. Halbuki ArrayList ile bir dizinin boyutunu çalışma
             * zamanında belirleyebiliriz. Biz diziye eleman ekledikçe dizi otomatik olarak büyütürülür. Klasik dizilerde olmayan diğer bir özellik ise diziden eleman çıkararak
             * dizinin boyutunu küçültmektir. Normal dizilerden farklı olarak ArrayList nesnelerinden çalışma zamanında da bir eleman çıkartılabilir.
             *
             * Bir ArrayList'e eklenen elemanlar Object türüne aktarılarak saklanır. Bu da her türlü sınıf nesnesinin ArrayList dizilerine eklenebileceğini gösterir. Ancak dizideki
             * elemanlara tekrar ulaşabilmek için object nesnelerinden orijinal sınıf türüne geri dönmemiz gerekir. Bunun için object referanslarına unboxing işlemi uygulanmalıdır.
             *
             * ArrayList sınıfı ile farklı türden verileri organize edebilmemize rağmen açıkça bu amaç için çok nadir kullanırız. Birbirleriyle bağlantılı olan temel veya türemiş
             * tüm referansları bu tür dizilerde saklamak daha mantıklı olacaktır. Birbirleriyle çok yakından ilişkisi olmayan türden nesneleri aynı çatı altında toplamak algoritmik
             * açıdan çok sık karşılaşacağımız bir durum değildir.
             */

            int Capasity = 0;   // Koleksiyonun alabileceği maksimum değeri ifade eder. Herhangi bir andaki dizi kapasitesini öğrenmemizi sağlar.
            int Count = 0;      // Koleksiyon içerisinde halihazırda var olan değer sayısını ifade eder.

            // Yukarıdaki kavramlar oldukça önemli. Örneğin Count'ın ve Capasity'nin for döngüsü sayacı olarak kullanıldığını düşünün...
            // Capasity ve Count, koleksiyona herhangi bir değer eklemesi yapılmadan önce 0'dır. Değer eklendiğinde şu şekilde değişir:
            // Count değer sayısı kadar artar. Yani birer birer artış ya da eklenen değer sayısı kadar artış söz konusudur.

            // Capasity, ilk değer eklemesinde 4 artar. Count 4'e ulaştığında 8 olur. Oldukça esnek öyle değil mi?
            // ArrayList'in bu davranışu Generic Collections için de geçerlidir.

            ArrayList A1 = new ArrayList();     //ArrayList oluşturuldu

            #region ArrayList - Tek Değer Ekleme

            // Add() metodu ArrayList içerisine tek kullanımda bir değer yerleştirmemizi sağlar.
            // Bu metod object veri tipinden değer aldığı için yerleşecek değerin türü önemli değildir.
            // Add() metodu parametre olarak aldığı elemanı dizinin sonuna ekler.

            A1.Add("Halim Can Ocaklı");
            Capasity = A1.Capacity;
            Count = A1.Count;
            A1.Add(100);

            #endregion

            #region ArrayList - Birden Fazla Değer Ekleme

            ArrayList A2 = new ArrayList();

            A2.Add("Mert");
            A2.Add("Turabi");
            A2.Add("Enes");
            A2.Add("Oğuzhan");
            A2.Add("Handan");
            A2.Add("Hüseyin");
            A2.Add("Beyza");
            A2.Add("Ceren");
            A2.Add("Ahmet");
            A2.Add("Deniz");

            A1.AddRange(A2);    // AddRange() metodu ArrayList içerisine tek kullanımda birden fazla değer yerleştirmemizi sağlar.
                                // A1 Koleksiyonunun içini AddRange() ile besledik ve bunu yaparken 10 elemanlı A2 koleksiyonunu kullandık.
                                // A1'in içinde halihazırada iki adet değer vardı, son işlemle tek seferde 10 adet daha değer ekledik.

            #endregion

            #region Capasity & Count İnceleme

            Capasity = A1.Capacity;
            Count = A1.Count;

            #endregion

            #region Koleksiyon İçindeki Değer Ulaşmak

            // Peki bir ArrayList içerisindeki elemanlara nasıl ulaşabiliriz?
            // Koleksiyonların içindeki değerlerin tamamı object türünde tutulur.
            // Bu nedenle herhangi bir indexteki değeri görmek istediğimizde, o indexi, veri türü object olan bir değişkene atarız.

            object O1 = A1[3];                  // A1[3] = "Turabi" (Object)
            string S1 = A1[3].ToString();       // Object to String (Unboxing)  => A1[3] = "Turabi" (String)
            int I2 = (int) A1[1];               // Object to Integer (Unboxing) => A1[1] = 100

            A1[3] = "İkbal";    // Değişim işlemi yapıldı

            /* NOT
             *
             * Farklı türden nesneleri ArrayList dizisine eklediğimizde foreach döngüsü yardımıyla unboxing işlemini açıkça yapamayız. Çünkü her eleman için ancak
             * boxing işleminin yapıldığı türe ilişkin unboxing işlemi gerçekleşir. Kısacası eğer unboxing yapmak istiyorsak, bu işlemi yapacağımız elemanın boxing
             * yapılmadan önce sahip olduğu veri türünü bilmemiz gerekir ve eğer bunu biliyor olsak bile birbirinden farklı türlerin boxing işlemine tabi tutularak
             * barındırıldığı ArrayList elemanlarını foreach ile tek seferde unboxing işlemine tabi tutamayız.
             *
             */

            #endregion

            #region ArrayList Sıralama

            // Z - A Sıralama
            // Bu işlem yapılırken koleksiyon içerisindeki değerler karşılaştırılmaz, değerlerin indexleri değiştirilir.

            A1.Reverse();   // Liste ters çevrildi
            
            // A - Z Sıralama

            // Bu sıralama yapılırmadan önce liste içerisindeki aynı ve farklı türden değerler kontrol edilecek ve karşılaştırılacak.
            // Eğer koleksiyon içerisinde birbirinden farklı türde değerler varsa hata verir.
            // Bu nedenle ArrayList içerisinde sahip olduğumuz Integer değeri yok ederek geriye sadece String veri tipi bırakalım ki hata almayalım.

            A1.Remove(100);     // Integer değer listeden kaldırıldı.
            A1.Sort();              // Liste A - Z doğrultusunda sıralandı 

            #endregion

            #region Koleksiyonlar - Yardımcı Komutlar

            // IndexOf() metodu koleksiyon içerisinde aranan değerin hangi indexte olduğunu geriye Integer değer döndürerek bulmamızı sağlar.
            // Bu metot ile RemoveAt() metodu birlikte kullanılırsa programdan alınan verim artabilir (Değer silme kısmına bakınız)
            int IndexDegeri = A1.IndexOf("Halim Can Ocaklı");

            //Clear() metodu koleksiyon içerisinde var olan bütün değerleri siler. Dolayısıyla Count 0'lanır.
            //A1.Clear();

            //TrimToSize() metodunu kullanarak değerlerini sildiğimiz koleksiyonun ilk oluşturulduğunda sahip olduğu Capasity değerine tekrar sahip olamasını sağlarız => (4)
            //A1.TrimToSize();

            // ToArray() metodunu kullanarak ArrayList'imizi bir diziye dönüştürebiliriz. Dönüştürülen dizinin türü object'tir. Çünkü liste içindeki değerlerin türleri birbirinden farkı olabilir.
            object[] D1 = A1.ToArray(); // Yeni dizimiz oluştu. Böylece aynı elemanlara sahip dizimiz ve ArrayList'imiz oldu.
            // ToList() metodu ile de diziyi bir listeye yani koleksiyona dönüştürebiliriz.



            //Contains() metodu koleksiyon içerisinde aranan değerin var olup olmadığına bakar ve geriye TRUE/FALSE döndürür
            bool Kontrol1 = A1.Contains("Halim Can Ocaklı");
            bool Kontrol2 = A1.Contains(900);

            #endregion

            #region ArrayList Koleksiyonu İçindeki Değeri Silme

            // RemoveAt() metodu ile ArrayList içerisinden index numarasını kullanarak değer silebiliriz.
            // Remove() fonksiyonundan farklı olarak değeri silmek için parametre olarak değerin kendisini değil değerin indexini alır.
            // Bir database üzerinde işlem yaparken verinin kendisi yerine verinin index numarını kullanarak silme işlemi yapmak daha mantıklı.

            A1.RemoveAt(3);

            // RemoveRange() metodu ile ArrayList içerisindeki belirli index aralığını silebiliriz.
            // İlk parametre silmeye başlayacağımız indexi, ikinci parametre o indexten itibaren kaç eleman sileceğimizi belirtir.

            A1.RemoveRange(1,2);

            // Remove() metodu ile ArrayList içerisindeki object türünden değeri silebiliriz.
            // Remove() metodu ile diziden bir elemanı çıkarmak dizinin kapasitesini değiştirmez.
            // Remove() metodu ile diziden çıkarılmak istenen eleman eğer dizide mevcut değilse hiçbir iş yapılmadan işlem devam eder.
            A1.Remove("İkbal");

            #endregion

            #region Ödev

            // 10 elemanlı (String) Arraylist içindeki değerleri Z - A olacak şekilde sıralayınız

            ArrayList isimler = new ArrayList();
            isimler.AddRange(A2);

            isimler.Sort();
            isimler.Reverse();

            #endregion
        }
    }
}
