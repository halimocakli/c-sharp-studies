using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    public class Musteri // Object => Framework standart olarak tüm nesneleri Object'ten türetir.
    {
        public int MusteriID { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }

        // Teorik kısımda bahsettiğimiz body biçimlendirme işlemini override anahtar sözcüğü ile yapabiliriz.
        // Override anahtar kelimesini kullandığımızda, override hangi classın içerisinde bulunuyorsa, temel sınıfın tüm metotlarını gösterir.
        // Musteri nesnesi object nesnesinden türediği için aşağıda override anahtar sözcüğünü kullandığımızda object nesnesinin metotlarını göreceğiz.

        public override string ToString()
        {
            // base anahtar sözcüğü içinde bulunduğu classın kalıtıldığı classı işaret eder. Yukarıda da bahsettiğimiz üzere burada Object'i işaret ediyor.
            // return base.ToString(); => Orijinal Body

            // Şimdi ToString(); metodunun bodysinde değişikliğe gideceğiz.

            return Isim + " " + SoyIsim;

            // Yukarıdaki modifikasyonla birlikte artık Object nesnesi içerisindeki ToString(); metodu yerine Musteri nesnesi içerisinde yazdığımız ToString(); metodu çalışacak.
        }
    }
}
