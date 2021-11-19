using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D3.ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;
            eklenecekData1[4] = 800;
            eklenecekData1[5] = 50;
            eklenecekData1[6] = 6;
            eklenecekData1[7] = 7;

            // Oluşturduğumuz diziyi sayilar listemize ekleyeceğiz

            /* Uzun yol
             *
             * for (int i = 0; i < eklenecekData1.Length; i++)
             * {
             *      sayilarim.Add(eklenecekData1[i]);
             * }
             *
             */

            // Kısa yol

            sayilarim.AddRange(eklenecekData1);
            // eklenecekData1 dizisi int türünden ve sayilarim listesi de int türünden.
            // Yani <T> tipi liste ile listeye eklenecek dizi veya değerin türce uyuşması, AddRange() metodunun kullanımı için şarttır.

            // ----------------------------------------------------------------------------------------------------------------------------------------------//

            // ListGeneric ilk oluşturulduğunda Count değeri 1 ve Capacity değeri 4 olur. Bu değerler üzerinden bellekte yer ayırılır.

            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

            sayilarim.TrimExcess(); // Count ve Capacity değerleri eşitlenir.

            // Soru : sayilarim kolleksiyonu içerisinde bulunan datayı ekrana yazdırmak istiyoruz, nasıl yapabiliriz?

            sayilarim.ForEach(i => Console.WriteLine(i));   
            // => Lambda ifadesi ---> İlgili kolleksiyon içerisinde arama yap.
            // => Lambda ifadesi Linq konusudur ve List<T> konusu içerisinde kullanımını gördük.

            int bulunanDeğer = sayilarim[3];
            Console.WriteLine("List<T> kolleksiyonu içerisinde 3. Index'te bulunan değer : {0}", bulunanDeğer);

            // sayilarim Listesinde bulunan istediğimiz indexe değer atamak için Insert() metodunu kullanırız.
            sayilarim.Insert(3, 100);
            // 3. indexe 100 sayısı eklendi ve önceden 3. indexte duran değer 4. indexe kaydirildi.

            // Any() metodu linq mimarisi kullanır.
            // İçeride herhangi bir değer varsa True döndür
            bool kontrol1 = sayilarim.Any();
            // sayilarim listesinde bulunan değerleri kontrol eder ve 5'ten büyük değer varsa geriye true döndürür.
            bool kontrol2 = sayilarim.Any(i => i > 5);

            sayilarim.Sort();   // A-Z ya da 1-N arası sıralama
            sayilarim.Reverse();    // Z-A sıralama

            // Liste içindeki en yüksek değeri bulmak için
            int enBuyukDeger = sayilarim.Max();

            // Liste içerisindeki en küçük değeri bulmak için
            int enDusukDeger = sayilarim.Min();

            // Liste içerisindeki degerleri toplamak için
            int toplamDeger = sayilarim.Sum();

            // Uygulama Alanı Bölümü => List<T> Uygulama - Windows Form

            // Belirtilen değer listeden silinir. Geriye bool ifade döndürülür.
            bool silmeIslemiSonuc = sayilarim.Remove(100);

            // Belirtilen şartı sağlayan değer ya da değerler listeden silini ve geriye silinen sayı adedi döndürülür.
            int silinenAdet = sayilarim.RemoveAll(i => i > 3);

            // Belirtilen indexteki değeri siler ve geriye bir şey döndürmez.
            sayilarim.RemoveAt(2);

            // liste içerisindeki tüm elemanları silmek için
            sayilarim.Clear();
        }
    }
}
