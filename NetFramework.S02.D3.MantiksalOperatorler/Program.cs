using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S02.D3.MantiksalOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * && : Ve Operatörü
             * || : Veya Operatörü
             */

            int sayi1 = 10;
            int sayi2 = 15;
            int sayi3 = 20;

            #region Ve "&&" Operatörü - Tanım

            bool veOperatoruSonuc = sayi1 > sayi2 && sayi1 < sayi3; // True geri dönmesi için her ikisinden de True sonucu gelmesi gerekiyor


            #endregion

            #region Veya "||" Operatörü - Tanım

            bool veyaOperatoruSonuc = sayi1 < sayi2 || sayi1 < sayi3;   // Herhangi bir karşılaştırma sonucundan True dönerse sonuç True olur

            #endregion
        }
    }
}
