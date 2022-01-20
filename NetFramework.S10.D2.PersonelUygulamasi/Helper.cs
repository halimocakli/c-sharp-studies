using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public static class Helper
    {
        // Static classlar örneklenemez ve içlerinde ancak static metotlar tanımlanabilir.
        // Static class içerisinde static olmayan field tanımları yapılamaz.

        // Static yapıcı metotlar private olarak tanımlanmalıdır.
        // Static yapıcı metot program içerisinde ilk çağrıdan sonra tekrar çalışmaz, toplamda bir kere çalışır.
        static Helper() // Default olarak private'tır
        {
            Console.WriteLine("Helper => Static Class => static CTOR");
        }
        // Standart yapıcı metot => Her nesne örneği alındığında uygulama yapıcı metodu çalıştırır.
        // Static yapıcı metot   => Uygulama içerisinde ne kadar çağırılırsa çağırılsınlar sadece ilk çağrılmada çalışırlar.

        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            //Email gönderme işlemi eğitimin ilerleyen kısımlarında devam edecek.
            Console.WriteLine("Mail göderim işlemi başarıyla tamamlandı");
        }
    }
}

