using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Müşteri adında bir nesne oluşturalım ve oluşturmuş olduğumuz nesnemizin içerisine static olarak bir ArrayList oluşturlarım.
             * Oluşturmuş olduğumuz ArrayListimizi sanal bir Database mantığıyla kullanacağız.
             * Müşteri sınıfımızın içerisine;
             *      => ID
             *      => Isim
             *      => Soyisim
             *      => EmailAdres
             *      => KullaniciAdi
             *      => Sifre
             * isimleri ile field'lar oluşturalım
             *
             * Oluşturduğumuz bu field listesinden bazılarının kapsülleme filtreleri aşağıdaki gibi olmalıdır:
             *
             * Kullanıcı adı değeri sanal olarak oluşturmuş olduğumuz database'imiz içerisinde aransın ve eğer kullanıcı adı sanal database
             * içerisinde bulunursa field içerisine eklenmek istenen değer eklenemesin (Kapsülleme)
             *
             * Müşteri ekle adında static bir metot oluşturalım, parametre olarak müşteri tipi alsın. Metot içerisinde;
             *
             *      => Müşteri nesnesinin null olup olmadığını ve müşteri nesnesi içerisindeki kullanıcı adının dolu olması şartına bakılsın.
             *
             *      => Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak oluşturduğumuz database'imize eklemeden önce email adresi üzerinden
             *         bir kontrol sağlasın eğer sistemde aynı email adresi ile bir müşteri değeri var ise eklemesin yok ise sanal database içerisine
             *         ilgili nesneyi eklesin.
             */

            Musteri M1 = new Musteri();
            M1.MusteriID = 1;
            M1.Isim = "Halim Can";
            M1.soyisim = "Ocaklı";
            M1.EMailAdres = "halimcanocakli@gmail.com";
            M1.KullaniciAdi = "halimaga";
            M1.sifre = "123";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri() 
            {
                MusteriID = 2,
                Isim = "Sabri",
                soyisim = "Hodjic",
                EMailAdres = "sabri.hocaoglu@gmail.com",
                KullaniciAdi = "sabriaga",
                sifre = "321"
            };

            Musteri.MusteriEkle(M2);

            // Kontrol metotlarımızın çalışıp çalışmadığını kontrol etmek için aşağıdaki uygulama yapıldı. Hata alacağız

            Musteri M3 = new Musteri();
            M1.MusteriID = 1;
            M1.Isim = "Halim Can";
            M1.soyisim = "Ocaklı";
            M1.EMailAdres = "halimcanocakli@gmail.com";
            M1.KullaniciAdi = "halimaga";
            M1.sifre = "123";

            Musteri.MusteriEkle(M3);
        }
    }
}
