using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass - Yapıcı Metot");
        }

        /*
         * "Virtual" anahtar kelimesi kullandığımız zaman metodumuz sanal metot olur. Kalıtım mimarisinde sanal fonksiyonun temel görevi şudur:
         * eğer biz bu sanal metodu hiç ellemezsek BaseClass içerisinde yazılmış olduğu gibi çalışır. Ancak "override" anahtar kelimesini kullanarak
         * farklı bir keyword ile türemiş olan sınıftan türetilen sınıfın sanal metotlarına dokunursak o zaman türemiş olan sınıf temel sınıfın
         * sanal metodunu ezer ve kendi içerisindeki body ile çalıştırır.
         */

        public virtual void EkranaYaz(string data)
        {
            Console.WriteLine("BaseClass sınıfı => " + data);
        }
    }
}
