using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D5.MetotlarinAsiriYuklenmesi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Metotlar aşırı yüklenerek(overload) aynı isimde birden fazla metot tanımlanabilir. Peki çalışma zamanında bu metotlar nasıl belirlenecek ve
             * isimler aynı olduğuna göre hangi metodu  çağırdığımız nasıl anlaşılacak? İşte bunun için metotların imzalarına (method signature) bakılır.
             * Metot imzası bir metodun karakteristik özelliklerini içeren bir tür bilgidir. Bir metodun imzası, metodun adı, parametrelerinin sayısı ve
             * türleri ile alakalıdır. Metodun geri dönüş değeri metodun imzasına dahil değildir. Metot imzaları parametrelerin türünü de kapsadığı için
             * aynı isme sahip fakat farklı türde parametre alan metotlar bildirebiliriz. Bunu aşağıdaki örnekte görebiliriz:
             */

            Topla(12, 10);  // Bu çağrım her ikisi de int türünden parametrelere sahip Topla() metodunu çalıştırır.
            Topla("C#","öğreniyorum");

            // NOT => Metotların geri dönüş değerleri, metot imzalarında ayırt edici özellik değildir.
            /*
             * Topla() metodunu çağırdıktan sonra derleyici aşağıda hazırladığımız aşırı yüklenmiş metotları incelemeye başlar. Her bir metodun ismi ve parametre
             * sayısı aynı olmasına rağmen farklı metot çağrımlarında farklı metotlar çalışmıştır. Bunun sebebi de metotların farklı imzalara sahip olmasıdır.
             * Derleyici hangi metodu çağıracağına karar vermek için önce metot bildirimi ile metot çağrımı arasındaki tam uyumu arar, yani iki integer türünden
             * parametre alacak şekilde bildirilmiş bir metodu, iki integer türünden parametre ile çağırmak her zaman tam uyumluluğu gösterir. Eğer aranan tam
             * uyumluluk bulunamaz ise parametreler arasında küçük türün büyük türe dönüştürülmesinin yasal olabileceği metot çağrılır. Yani hep en uygunu aranır.
             */

            // Yukarıdaki anlatıma örnek olarak aşağıdaki metot kullanımını verebiliriz.
            // Gönderdiğimiz parametrelerden biri float diğeri ise int türündendir. Uygunluk ölçütü bakımından, her iki parametresi de double türünden olan metodumuz çalışır.
            Topla(12.5f, 14.7);

            /*
             * Farklı sayıda parametre içeren metotları seçmede ise aynı sayıda parametre içeren metotları seçmek gerekir; aynı sayıda parametre içeren metotlar
             * birden fazla ise yukarıda bahsedilen tür dönüşümü ile ilgili olan özellik devreye girer. Örneğin:
             */

            Topla(5, 10);
            Topla(5, 10, 15);
            Topla(5, 10, 15.56);

            /*
             * .NET sınıf kütüphanesindeki birçok metoda aşırı yüklemeler yapılmıştır. Örneğin Console sınıfının WriteLine metodunu 19 değişik biçimde kullanabiliriz.
             * Bu sayede bu metot ile ekrana istediğimiz türden verileri rahatlıkla yazabiliyoruz. Eğer her tür için farklı isimde metotlar olsaydı bu hem hızlı program
             * geliştirmemize engel olurdu hem de birçok metot ismini ezberlememiz gerekirdi.
             */

            Console.ReadLine();
        }

        static void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void Topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void Topla(string metin1, string metin2)
        {
            Console.WriteLine(metin1 + " " + metin2);
        }

        static void Topla(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void Topla(int sayi1, int sayi2, int sayi3)
        {
            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine(toplam);
        }

        static void Topla(int sayi1, int sayi2, double sayi3)
        {
            double toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine(toplam);
        }
    }
}
