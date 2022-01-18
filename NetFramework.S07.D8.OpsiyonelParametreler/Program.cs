using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D8.OpsiyonelParametreler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# 4.0'dan itibaren metotlara opsiyonel parametreler tanımlanabilmektedir. Opsiyonel parametreler sayesinde metot bildirimi sırasında
             * istenen parametreye varsayılan değer verilerek ilgili parametrelerin gönderilmediği durumda metot içinde alacağı değer belirtilmektedir.
             * Özellikle parametre sayısı çok olan metotlarda kullanışlı olan bu özellik sayesinde daha kısa metot çağrımlarına imkan sağlanmaktadır.
             * Aynı zamanda bir metodun farklı overload versiyonlarının da yazılmasının önüne geçilmektedir.
             */

            /*
             * Metot bildiriminde parametrelerin varsayılan değerleri atama operatörü ile belirtilen durumlarda ilgili parametre metot çağrımında
             * opsiyonel hale gelmektedir. Örneğin ikinci ve üçüncü parametresi opsiyonel olan bir metot aşağıdaki gibi bildirilebilir:
             */

            Metot("Halim");
            Metot("Halim", "Ocaklı");
            Metot("Halim", "Ocaklı", 22);

            Console.ReadLine();
        }

        public static void Metot(string a, string b = "Halim", int c = 9)
        {
            Console.WriteLine("a = " + a + " b = " + b + " c = " + c.ToString());
        }
    }
}
