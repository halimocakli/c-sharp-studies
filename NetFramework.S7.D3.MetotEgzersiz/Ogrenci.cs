using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D3.MetotOdev1
{
    public class ogrenci
    {
        public void ogrenciNotHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3)
        {
            Console.WriteLine("Öğrencinin Bilgileri Aşağıdaki Gibidir.");
            Console.WriteLine("Ad Soyad  : {0} {1}", ad, soyad);

            decimal ortalama = ortalamaHesapla(not1, not2, not3);
            ortalamaNotDegerlendir(ortalama);

            // Okunaklık açısından yüksek boyutlu projeler için aşağıdakine nazaran yukarıdaki kullanım daha uygundur.

            // ortalamaNotDegerlendir(ortalamaHesapla(not1, not2, not3));
        }

        // Diyelim ki kullanıcıdan istenen not değerlerinden biri belirli. O halde aşağıdaki kullanım makuldür.
        // Buna göre not3 değeri 45'e sabitlenir ve Program sınıfı içerisindeki metottan not3 parametresi silinir.
        // Eğer metottan not3 parametresini silmezsek ve kullanıcıdan not2 için değer alırsak(aşağıdaki metot kullanılırken) bu sefer yine girilen değer not3'e atanır.
        // Bunula birlikte opsiyonel yani sabitlediğimiz not2 değeri metot parametreleri içerisinde aşağıda oldupu gibi en sona yazılmalıdır. Aksi halde hata alınır.
        // Opsiyonel/sabitlenmiş parametreden sonra yeni parametre yazılacaksa o yeni parametre de opsiyonel olmak durumundadır.

        /*
        public void ogrenciNotHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3 = 45)
        {
            Console.WriteLine("Öğrencinin Bilgileri Aşağıdaki Gibidir.");
            Console.WriteLine("Ad Soyad  : {0} {1}", ad, soyad);

            decimal ortalama = ortalamaHesapla(not1, not2, not3);
            ortalamaNotDegerlendir(ortalama);
        }
        */

        // Eğer herhangi bir erişim belirleyicisi belirtmezsek .net bunu default olarak private kabul eder
        void ortalamaNotDegerlendir(decimal ogrenciOrtalama)
        {
            if (ogrenciOrtalama < 45)
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Kaldınız", ogrenciOrtalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Geçtiniz", ogrenciOrtalama);
            }
        }

        private decimal ortalamaHesapla(decimal Ogrencinot1, decimal Ogrencinot2, decimal Ogrencinot3)
        {
            // decimal ortalama = (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;
            // return ortalama;
            return (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;
        }
    }
}