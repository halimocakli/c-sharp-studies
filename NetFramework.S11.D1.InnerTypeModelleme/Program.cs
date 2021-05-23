using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();     // Nesnemiz örneklendi
            M1.KullaniciID = 1;
            M1.TcKimlikNo = "12986532789";
            M1.Isim = "Halim Can";
            M1.SoyIsim = "Ocaklı";
            M1.OlusturmaTarih = DateTime.Now;

            // Aşağıda MusteriAdres türünden oluşturduğumuz MusteriAdresleri dizisini/kolleksiyonunu örnekleyerek içine değer alması için alan yaratıyoruz.
            // Buna göre MusteriAdres sınıfı içerisindeli fieldlar 5 farklı tekrar içe oldurulabilecek (0.index, 1. index, ...)
            // Bu işlem ile, Musteri türünden örneklediğimiz M1 nesnesi içerisinde "null" olarak görünen MusteriAdresleri InnerType'ı MusteriAdresi türünden örneklenmiş oldu.
            //****** M1.MusteriAdresleri = new MusteriAdres[5];*******

            // Yukarıdaki yöntem sürekli kendini tekrar eder. Yani 1. indeks ve diğer indeksleri için de aynı işlemi yapmamız gerekir ki kod okuma ve düzeltme için verimsiz bir yöntemdir.
            // Asla yapmayın!!!
            // Bu yöntemin yerine ilgili nesnenin yapıcı metodunda gerekli örneklemeyi yapmak daha mantıklıdır.


            // Musteri nesnemiz içerisinde oluşturduğumuz MusteriAdresleri kolleksiyonumuzun 0. ID'sine bir MusteriAdres nesne tanımı yaptık
            // Bu yöntemle Inner Type kavramını uygulamış oluyoruz
            M1.MusteriAdresleri[0] = new MusteriAdres()
            {
                Il = "İstanbul",
                Ilce = "Pendik",
                Adres = "Çamçeşme Mah. Şehit Ömer Ay Sk. No: 22 D: 9",
                adresTip = "Ev Adresi"
            };

            M1.MusteriAdresleri[0].MusteriAdresTestMetot(); // Nesne üzerinde tanımlı Inner Type içerisindeki metoda ulaşmak


            // Musteri nesnemiz içerisinde oluşturduğumuz MusteriSiparisBilgileri kolleksiyonumuzun 0. ID'sine bir MusteriSiparisBilgisi nesne tanımı yaptık
            // Bu yöntemle Inner Type kavramını uygulamış oluyoruz
            M1.MusteriSiparisBilgileri[0] = new MusteriSiparisBilgisi();
            M1.MusteriSiparisBilgileri[0].siparisNumarasi = "SIP0001"; 
            // Musteri türünden örneklediğimiz M1 nesnesi içerisinde bulunan MusteriSiparisBilgisi türünden oluşturduğumuz MusteriSiparisBilgileri adlı kolleksiyonun/Inner Type'ın
            // 0. indexinde bulunan Urun tipinden örneklediğimiz Urunler kolleksiyonunun/Inner Type'ının 0. indeksindeki fieldlara atama yapalım.
            M1.MusteriSiparisBilgileri[0].Urunler[0] = new Urun()
            {
                urunID = 1,
                urunTanim = "Telefon",
                urunFiyat = 1500
            };
        }
    }
}
