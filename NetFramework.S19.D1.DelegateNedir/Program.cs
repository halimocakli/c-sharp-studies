using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D1.DelegateNedir
{
    class Program
    {
        delegate void MatematikselIslemler(int Sayi1, int Sayi2);
        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama işleminin sonucu = {0}", sonuc);
        }
        static void Cikart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkartma işleminin sonucu = {0}", sonuc);
        }
        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işleminin sonucu = {0}", sonuc);
        }

        static void Main(string[] args)
        {
            /*
             * Delegate => Metot Tutucu olarak da isimlendirilir.
             * Aynı metot imzasına sahip metotları tutan ve onları bir liste olarak kendi içerisinde barındıran yapıdır.
             * Metot imzası, bir metodun aldığı parametrelerin ve geri döndürdüğü değerin veri türüdür.
             * Yani biz birden fazla metodu aynı anda çağırmak yerine bir delegate üzerinden çağırıp metotları sırasıyla çağırabiliriz.
             * Linq sorgularında sıklıkla kullanılır.
             * Her delegenin base sınıfı "Delegate" sınıfıdır.
             * Kısacası delegate'ler bir metot silsilesidir ve çalıştığında bir veya birden fazla metodu tetikler.
             *
             * ==> Delegate int MatematikselIslemler(int A, int B) <==
             *
             * Yukarıdaki prototipte görüldüğü gibi, iki adet int parametre alan ve geriye int değer döndüren metotlarımızı bir delegate içerisinde tutabiliriz.
             *
             * Diyelim ki bu örnek delegete içerisine "Topla", "Çarp", "Çıkart" metotlarımızı belli bir sıra ile ekledik. İlgili delegate çağırıldığı zaman,
             * eklenme sırasına göre metotlarımız çalışacaktır.
             */

            Topla(10, 20);
            Cikart(20, 2);
            Carp(20, 2);

            Console.WriteLine("\nStatic metotlar çalıştı\n");

            // En standart haliyle üç adet static metot oluşturdum ve bunları kullandım, peki bu metotları bir delege içerisinde nasıl kullanabilirim?

            MatematikselIslemler M1 = new MatematikselIslemler(Topla);  // MatematikselIslemler delegemizi örnekledik, yarattığımız nesnenin Topla metodunu işaret etmesini sağladık.
            M1.Invoke(20, 30);    // Invoke() metodu, ilgili delegeyi çağırmamızı sağlar.

            Console.WriteLine("\nMatematikselIslemler delegesi içerisindeki Topla() metodu çalıştı\n");

            // Şimdi ise delegemize yeni metotlar ekleyelim

            M1 += Carp;
            M1 += Cikart;

            M1.Invoke(30, 3);

            Console.WriteLine("\nMatematikselIslemler delegesi içerisindeki bütün metotlar çalıştı\n");

            // Şimdi de delegemizin hangi metotları işaret ettiğini görelim

            Console.WriteLine("Delegate tarafından işaret edilen metotlar yazdırılıyor...\n");

            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();

            foreach (var VARIABLE in IsaretEdilenMetotlar)
            {
                Console.WriteLine(VARIABLE.Method.Name);
            }

            // Şimdi ise delegate'mizin işaret ettiği metotları runtime'da delegate içerisinden çıkartalım

            Console.WriteLine("\nCarp() metodu delegate içerisinden çıkartılıyor...\n");

            M1 -= Carp;
            foreach (var VARIABLE in M1.GetInvocationList())
            {
                Console.WriteLine(VARIABLE.Method.Name);
            }

            Console.WriteLine("\nCikart() metodu delegate içerisinden çıkartılıyor...\n");

            M1 -= Cikart;
            foreach (var VARIABLE in M1.GetInvocationList())
            {
                Console.WriteLine(VARIABLE.Method.Name);
            }

            Console.WriteLine("\nCarp() metodu delegate içerisine yeniden ekleniyor...\n");

            M1 += Carp;
            foreach (var VARIABLE in M1.GetInvocationList())
            {
                Console.WriteLine(VARIABLE.Method.Name);
            }

            Console.ReadLine();
        }
    }
}
