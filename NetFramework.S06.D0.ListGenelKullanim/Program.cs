using System;
using System.Collections.Generic;

namespace NetFramework.S6.D0.ListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * "List" veri yapısı dizilere çok benzer. Listeler diziler ile aynı fonksiyona sahiptir ama dizilerden farklı
             * olarak bir avantaj sağlar: Listeler bir boyut sahip olmak zorunda değildir. Yani listeleri tanımlarken belirli
             * bir boyuta sahip olmak zorunda değiliz, ihtiyaca göre eleman ekleyip çıkartabiliriz. Hatırlarsanız dizi boyutunu
             * derleme işleminden önce belirtmemiz gerekiyordu ve eğer diziye sahip olduğu kapasiteden fazla eleman eklemeye
             * çalışırsak hata alıyorduk. "List" ile oluşturulan veri yapısında böyle durumlar söz konusu değildir. Çalışma zamanında
             * bile liste boyutu değiştirilebilir. 
             */

            // Uygulanması => List<VERI_TIPI> NESNE = new List<VERI_TIPI>();

            // List nesnesini tanımladıktan sonra List sınıfının özellik ve metotlarını kullanarak işlem yapabiliriz.

            // Count => Eleman sayısını döndürür
            // Add(ELEMAN) => Kuyruğun sonuna eleman ekler
            // RemoveAt(INDEX) => Belirtilen index değerine sahip eleman silinir
            // Clear() => Tüm elemanları siler
            // Reverse() => Elemanları ters çevirir
            // Sort() => Elemanları sıralar
            // Contains(ELEMAN) => Belirtilen elemanın olup olmadığını kontrol eder, varsa true yoksa false döndürür
            // IndexOf(X) => Parametre olarak belirtilen nesnenin ilk bulunduğu elemanın index değerini döndürür
            // CopyTo(int array, i) => Liste elemanlarını iki boyutlu bir diziye, belirtilen index numarasından itibaren aktarır

            List<int> Li = new List<int>();

            Li.Add(1);
            Li.Add(2);
            Li.Add(3);
            Li.Add(4);
            Li.Add(5);
            Li.Add(6);
            Li.Add(7);

            List<int> secLi = new List<int>() { 8, 9, 10, 11, 12, 13, 14 };

            secLi.Add(15);
            secLi.Add(16);

            secLi.RemoveAt(8);

            foreach (var VARIABLE in secLi)
            {
                Console.WriteLine(VARIABLE);
            }

            if (Li.Contains(2))
            {
                Console.WriteLine("Eleman Mevcut");
            }

            Console.WriteLine("Eleman Sayısı: {0}", Li.Count);
            Li.Reverse();
            Li.Sort();

            Console.WriteLine("0. İndexteki Eleman :{0}", secLi[0]);

            int[] numbers = new int[4] { 20, 30, 40, 50 };

            List<int> reList = new List<int>(numbers);

            int[] secNumbers = new int[4];

            reList.CopyTo(secNumbers, 0);

            Console.WriteLine();

            foreach (var VARIABLE in secNumbers)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadLine();
        }
    }
}
