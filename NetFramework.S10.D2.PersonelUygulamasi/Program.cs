using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Önce static yapıcı metot çalışır.
            // Çünkü standart yapıcı metot içerisinde, static metot içerisinde değer atadığım bir field kullanmak isteyebilirim.
            // Dolayısıyla önce değer atanması gerektiği için ilk olarak static yapıcı metot çalışır.

            // Static ve Standart yapıcı metotların davranışlarını incelemek için P1 ve P2 nesnelerini oluşturduk

            Personel P1 = new Personel();
            P1.Isim = "Halim Can";
            P1.Soyisim = "Ocaklı";
            P1.Emailadres = "halimcanocakli";
            P1.cinsiyet = 717770001;    //Bay

            Personel P2 = new Personel();
            P2.Isim = "Halim Can";
            P2.Soyisim = "Ocaklı";
            P2.Emailadres = "halimcanocakli";
            P2.cinsiyet = 717770001;    //Bay

            // Static metot kullanımı
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            // Static yapıcı metot program içerisinde ilk çağrıdan sonra tekrar çalışmaz, toplamda bir kere çalışır.
            // Bu durumun kontrolü için Helper.emailGonder metodu iki kere çalıştırıldı. Debug ile kontrol edebilirsiniz.
        }
    }
}
