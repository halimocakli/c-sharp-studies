using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S09.D1.KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnekleme gerçekleşiyor.
            Musteri M1 = new Musteri();
            //M1.isim = "Halim Can";
            //M1._soyisim = "Ocaklı";

            /* Kapsülleme işlemini ne zaman ve nasıl kullanırız?
             *
             * Classın içerisindeki bir alanın değer alma ve değer okuma kısımlarına müdahale ettiğimiz işlemlere Encapsulation-Kapsülleme denir.
             * Müşteri Class'ı içerisinde tanımladığımız alanları özelleştirmek için kapsüllemeyi kullanırız.
             * Aşağıdaki durumlar kapsülleme işlemibe örnektir.
             *
             * Field içerisine değer ataması yapılamasın ama değer okunabilsin.
             * Field içerisine değer ataması yapılabilsin ama değer okunamasın.
             * Field içerisine değer ataması yapılabilsin ama değerin yalnızca ilk 4 hanesinin okunmasına izin verilsin.
             * Field içerisine değer ataması yapılabilsin ve değerler okunabilsin ancak bu iki işlem, bizim belirlediğimiz bir süreçten geçtikten sonra veriler gösterilebilsin.
             */

            // Class
            // Field
            // Property
            // Get/Set

            // Genel olarak kapsülleme konusuna giriş yaptık.
            // M1.emailAdres = "halimcanocakli@gmail.com"; => Musteri sınıfı içerisinde private olarak bulunan alan, metot olarak kullanılamadığı için hata alırız.
            // M1.EmailAdres = "halimcanocakli@gmail.com";
            // Console.WriteLine(M1.EmailAdres);

            // Senaryo 1 : Field içerisine değer ataması yapılamasın ama değer okunabilsin.

            Console.WriteLine("Müşteri ID değer : " + M1.ID.ToString());

            #region Ara Ödev

            // M1.TCKimlikNumarasi = "78895436652";    // Değer Ataması yapılamadı
            string TC = M1.TCKimlikNumarasi;        // Değer okuması yapıldı

            #endregion

            M1.isim = "Halim";
            M1.SoyIsim = "Ocaklı";
            Console.WriteLine(M1.EmailAdres);

            Console.ReadLine();

        }
    }
}
