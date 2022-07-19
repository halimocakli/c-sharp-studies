
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S03.D1.IF_ElseKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanım

            if (true)
            {
                // Bu işlemleri yap
            }
            else
            {
                // Bu işlemleri yap
            }

            #endregion

            #region If-Else Merhaba

            int sayi1 = 10;
            int sayi2 = 15;

            bool sonuc = sayi1 < sayi2;
            if (sonuc)
            {
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden küçüktür");
            }
            else
            {
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür");
            }

            // Yukarıdaki kodu biraz daha kısa olacak şekilde yazalım

            if (sayi1 < sayi2
            )
            {
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden küçüktür");
            }
            else
            {
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür");
            }

            // Biraz daha kısaya doğru gidelim

            if (sayi1 < sayi2)
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden küçüktür");
            else
                Console.WriteLine("Sayı 1 - Sayı 2 değerinden büyüktür");

            // İf tek başına da kullanılabilir



            #endregion
        }
    }
}
