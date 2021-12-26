using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S02.D4.AtamaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * = : Atama işlemi gerçekleştirir
             * +=
             * -=
             * *=
             * /=
             */

            #region "=" Operatörü Kullanımı

            int sayi1 = 10;

            #endregion

            #region "+=" Operatörü Kullanımı

            sayi1 += 2;
            Console.WriteLine(sayi1);

            #endregion

            #region "-=" Operatörü Kullanımı

            sayi1 -= 2;
            Console.WriteLine(sayi1);

            #endregion

            #region "*=" Operatörü Kullanımı

            sayi1 *= 2;
            Console.WriteLine(sayi1);

            #endregion

            #region "/=" Operatörü Kullanımı

            sayi1 /= 2;
            Console.WriteLine(sayi1);

            #endregion
        }
    }
}
