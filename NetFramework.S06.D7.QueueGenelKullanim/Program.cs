using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S06.D7.QueueGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Queue veri yapısı çalışma biçimi olarak Stack sınıfına benzer. Ancak algoritma aynı değildir. Queue bir kuyruğu temsil eder. Kuyrukta ilk giren ilk çıkar mantığı
             * geçerlidir. Gerçek hayattaki kuyruklarda da böyledir. Mesela otobüs sırasına ilk giren kişi otobüse ilk önce biner. Queue veri yapısında da kuyruğa ilk eklenen eleman
             * gruptan ilk önce çıkartılır. Queue sınıfında kuyruğun en başındaki elemanı çıkarmak ve bu elemanla geri dönmek için Dequeue() metodu kullanılır. Bu metot Stack sınıfının
             * Pop() metodunun karşılığı gibi düşünülebilir. Enqueue() metodu ile de parametre olarak verilen object nesnesi kuyruğun sonuna eklenir. Bu da Stack sınıfındaki Push()
             * metodunun karşılığıdır. Diğer bir metot olan Peek() metodu ise kuyruktaki ilk elemanın değerini döndürür ancak kuyruktan bu elemanı çıkarmaz. Stack sınıfındaki Peek()
             * metodu ile aynıdır.
             */

            // NOT => Boş bir Queue nesnesi ile Dequeue() metodunu kullanmak InvalidOperationException istisnai durumunu oluşturur.

            // ToArray() => Stack sınıfında olduğu gibi kuyruğun elemanlarını klasik bir diziye aktarır.
            // TrimToSize() => Kuyruğun kapasitesini kuyruktaki eleman sayısına düşürür. Yani Count ve Capasity özellikleri birbirlerine eşitlenir.

            #region Queue - Uygulama 1

            Queue Q1 = new Queue();

            // Enqueue() metodu ile içeriye data ekleriz
            Q1.Enqueue("Bir");
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");

            // Peek() metodu kolleksiyon içerisindeki datayı gösterir ve kolleksiyon içerisinde tutar
            object O1 = Q1.Peek();

            // Dequeue() metodu kolleksiyon içerisindeki datayı gösterir ve datayı kolleksiyondan siler
            object O2 = Q1.Dequeue();

            #endregion

            #region Queue - Uygulama 2

            Queue Q2 = new Queue();

            Q2.Enqueue("Bir");
            Q2.Enqueue("İki");
            Q2.Enqueue("Üç");
            Q2.Enqueue("Dört");
            Q2.Enqueue("Beş");
            Q2.Enqueue("Altı");
            Q2.Enqueue("Yedi");
            Q2.Enqueue("Sekiz");

            Console.WriteLine("Kuyruğun ilk hali...");
            EkranaYaz(Q2);

            string isim = (string)Q2.Dequeue();
            Console.WriteLine("Kuyruktan {0} yazısını aldık.", isim);

            isim = (string)Q2.Dequeue();
            Console.WriteLine("Kuyruktan {0} yazısını aldık.", isim);

            isim = (string)Q2.Peek();
            Console.WriteLine("Kuyruğun tepesindeki yazı: {0}", isim);

            #endregion
        }

        public static void EkranaYaz(Queue kuyruk)
        {
            Queue yeniKuyruk = (Queue)kuyruk.Clone();

            if (kuyruk.Count != 0)
            {
                while (yeniKuyruk.Count > 0)
                {
                    Console.WriteLine("\t" + yeniKuyruk.Dequeue().ToString());
                }
            }
            else
            {
                Console.WriteLine("Kuyruk boş!");
            }
        }
    }
}
