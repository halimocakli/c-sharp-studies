using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    public class Urun : BaseClass
    {
        public Urun()
        {
            Console.WriteLine("Urun - Yapıcı Metot");
        }

        // Override anahtar kelimesini kullanarak BaseClass içerisinde Virtual anahtar kelimesi kullanılarak oluşturulan EkranaYaz() sanal metodunu eziyoruz.
        // Bu noktadan sonra EkranaYaz() metodunu çağırdığımızda aşağıdaki işlemler koşturulacak.
        public override void EkranaYaz(string data)
        {
            Console.WriteLine("Urun sınıfı => " + data);
        }
    }
}
