using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D5_EkDers.MetotParametrelerindeMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aşağıdaki kullanım büyük boyutlu uygulamalar için uygun ve okunaklıdır.
            decimal toplam = Topla(12M, 45M);
            EkrandaGoster(toplam);

            // Aşağıdaki kullanım küçük boyutlu uygulamalar için uygundur ve bellekte az yer kaplar
            EkrandaGoster(Topla(12M, 45M));
            // Bir metot en fazla bir metodu çağırıyorsa bu kullanım uygundur ancak yine de kullanımı kod okunaklığını sıkıntıya sokablir.
        }

        static void EkrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }

        static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal Topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }

        static string Topla(string metin1, string metin2)
        {
            return metin1 + " " + metin2;
        }
    }
}
