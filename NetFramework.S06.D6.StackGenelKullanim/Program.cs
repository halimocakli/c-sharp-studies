using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S06.D6.StackGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * System.Collections isim alanında tanımlı bir veri türü olan Stack sınıfı bilgisayar bilimlerinde Yığın olarak adlandırılır. Yığınlar bir veri grubudur.
             * Öyle ki bu gruptan belli bir anda ancak gruba en son eklenen elemanın değeri elde edileblir. Değeri elde edilebilecek bu eleman gruba en son eklenen elemandır.
             * Dolayısıyla grup içerisinde bulunan ilk elemanı elde edebilmek için ilk eleman dışındaki bütün elemanların gruptan çıkması gerekir. Yığın ve benzeri veri
             * gruplarında Pop() ve Push() gibi iki önemli metot bulunur. Pop() metodu bir yığından yığına eklenen son elemanı çıkarır ve bu çıkarılan eleman değeri ile
             * geri döner. Push() metodu ise yığına yeni bir eleman eklemek için kullanılır. Yığın veri yapısının temel çalışma prensibine kısaca Son Giren İlk Çıkar
             * ya da Last In First Out(LIFO) şeklinde açıklanabilir. Bu mantığı kafanızda iyice canlandırmak için şöyle bir örnek verelim. Bir masaya sırayla üst üste
             * tabakların dizildiğini düşünün. Bu masanın üzerinde 10 tabak olduğunu farz edelim. Üstten 5. tabağa erişebilmek için son eklenen 4 tabağı kaldırmamız gerekir.
             * Dolayısıyla tabaklardan oluşan kümedeki ilk tabağa erişebilmek için bütün tabakları önceden kaldırmış olmanız gerekir. Gördüğünüz gibi masaya konulan ilk tabak
             * gruptan en son çıkarken gruba en son eklenen tabak gruptan ilk çıkan eleman olmuştur.
             */

            // 1000 Row'luk data bloğu geldiğini düşünelim bu dataların hepsini başarılı olması durumuna göre dışarı çıkaracağız, bu durumda stack'ten yardım alırız.

            // Stack sınıfı ArrayList gibi dinamik bir veri yapısıdır. Yani Push() metodu ile yeni bir eleman eklendiğinde eğer kapasite yetersiz ise halihazırdaki kapasite 2 kat arttırılır.
            // Pop() metodu yığında bulunan en üstteki elemanı geri döndürür ve bu elemanı yığından çıkarır.
            // Peek() metodu ise son elemanı yığından silmeden geri döndürür.
            // Bir metoda eleman eklemek için Push() metodu kullanılır. Push() metodu object türünden parametre aldığı için yığına her türden eleman eklenebilir.

            // NOT => Eğer yığın boşken Pop() metodu kullanılırsa InvalidOperationException istisnai durumu meydana gelir.

            // Count => Yığındaki eleman sayısını verir.
            // Clear() => Yığındaki tüm elemanları siler. Count 0 olur.
            // ToArray() => Yığındaki elemanlar klasik object türünden bir diziye aktarılır.
            // Contains() => Object türünden bir parametre alarak verilen parametrenin yığında mevcut olup olmadığını sorgular. Varsa geriye True döner.

            // Bir yığındaki elemanların tamamına bir koleksiyon gibi erişmek için Stack sınıfının GetEnumerator() metodunu kullanarak Stack sınıfına ilişkin IEnumerator referansı elde etmeliyiz.

            #region Stack Metotları - 1

            Stack S1 = new Stack();

            // Push() metodu ile bir datayı obje tipinde olacak şekilde kolleksiyona ekler
            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            // Pop() metodu, koleksiyon içerisine aldığımız son datayı LIFO prensibi kullanarak bize gösterecek ve gösterdiği her datayı koleksiyondan çıkaracak.
            object O1 = S1.Pop();

            // Peek() metodu, koleksiyon içerisine aldığımız son datayı LIFO prensibi kullanarak bize gösterecek ancak gösterdiği datayı koleksiyondan silmeyecek.
            object O2 = S1.Peek();

            #endregion

            #region Stack Metotları - 2

            // Yeni bir yığın tanımlayalım
            Stack S2 = new Stack();

            // Yığına çeşitli değerler ekleyelim
            S2.Push(5);
            S2.Push(98);
            S2.Push(17);
            S2.Push(4);
            S2.Push(88);
            S2.Push(65);
            S2.Push(32);
            S2.Push(97);

            Console.WriteLine("Yığınımızın ilk hali...");
            EkranaYaz(S2);

            // Yığının tepesinden bir sayı alınıyor.
            // Bu değer sayı değişkenine atanıp ekrana yazdırılıyor.

            int sayi = (int)S2.Pop();
            Console.WriteLine("\nYığından {0} sayısını aldık.", sayi);

            // Yığının tepesinden bir sayı daha alınıyor.
            // Bu değer sayı değişkenine atanıp ekrana yazdırılıyor.

            sayi = (int)S2.Pop();
            Console.WriteLine("\nYığından {0} sayısını aldık.", sayi);

            // Şimdi yığının en tepesindeki sayıyı yığından çıkarmadan değerini öğrenelim.

            sayi = (int)S2.Peek();
            Console.WriteLine("\nYığının tepesindeki sayı: {0}", sayi);

            Console.ReadLine();

            #endregion
        }

        public static void EkranaYaz(Stack yigin)
        {
            Stack yeniYigin = (Stack)yigin.Clone();

            if (yigin.Count != 0)
            {
                while (yeniYigin.Count > 0)
                {
                    Console.WriteLine("\t" + yeniYigin.Pop().ToString());
                }
            }
            else
            {
                Console.WriteLine("Yığın boş!");
            }
        }
    }
}
