using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D1.GenericOncesiIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            SanalDatabase virtualDataBase = new SanalDatabase();
            virtualDataBase.yeniKayit(1);
            virtualDataBase.yeniKayit(2);

            /// Bu kısımda, generic mimari yokken nasıl veri kaydı aldığımızı vs konuştuk
        }
    }
}
