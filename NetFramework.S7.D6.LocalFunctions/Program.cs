using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D6.LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local Function özelliği .Net Framework'e 4.7.0 sürümünden sonra geldi.
            // Metotların içinde metotlar tanımlayabiliyoruz ve bu metotlara ancak tanımlandığı metotların içinden çağırabiliyoruz.
            // Local Function'ın amacı belirli bir metot içerisinde yer alan özel durumları fonksiyon olacak şekilde tutmak ve kod karmaşasını ortadan kaldırmaktır.

            LocalFunctionKullanimi(12, 22);
        }

        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            // Aşağıdaki metodun yaşamı LocalFunctionKullanimi metodunun scop'u/bloğu içerisinde devam eder.
            int topla(int gelenSayi1, int gelenSayi2)
            {
                return gelenSayi1 + gelenSayi2;
            }

            int toplamDeger = topla(sayi1, sayi2);
            Console.WriteLine(toplamDeger);
        }
    }
}
