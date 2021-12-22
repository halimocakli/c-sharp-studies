using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D2.Delegate_IsimsizMetotKullanimi
{
    class Program
    {
        delegate void EkranaYaz(string Isim, string SoyIsim);
        static void Main(string[] args)
        {
            // Halihazırda bildiğimiz şekilde delegate içerisine var olan metot ekledik
            EkranaYaz TestI = new EkranaYaz(TestIMetot);

            // Şimdi ise delegate çalışırken, runtime'da yazdığımız metodun yani isimsiz metodun delegate tarafından işaret edilmesini sağlayalım
            EkranaYaz TestII = new EkranaYaz(delegate (string Isim, string SoyIsim)
            {
                Console.WriteLine(Isim + " " + SoyIsim);
            });
            // Böylece isimsiz metot kullanımını görmüş olduk.

            // Lambda Expression'ın Delegate ile kullanımını görelim
            EkranaYaz TestIII = (Isim, SoyIsim) =>
            {
                Console.WriteLine(Isim + " " + SoyIsim);
            };

            TestI("Halim Can", "Ocaklı => TestI() metodu çalıştı");
            TestII("Turabi", "Uygun     => TestII() metodu çalıştı");
            TestIII("Sabri", "Hocaoğlu   => TestIII() metodu çalıştı");

            Console.ReadLine();
        }

        static void TestIMetot(string Isim, string SoyIsim)
        {
            Console.WriteLine(Isim + " " + SoyIsim);
        }
    }
}
