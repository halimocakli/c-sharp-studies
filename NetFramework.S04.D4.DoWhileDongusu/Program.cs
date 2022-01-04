using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S04.D4.DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanım

            // While döngüsünden farklı olarak şart ne olursa olsun döngü bloğu içerisindeki işlemler bir kere çalışacaktır
            do
            {
                Console.WriteLine("Merhaba Do-While");
            } while (1 == 2);

            #endregion
        }
    }
}
