using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    // TemelTip sınıfını entegre edildi
    public sealed class Ogrenci : TemelTip
    {
        // Sealed anahtar sözcüğü ile mühürlenen Ogrenci nesnesinden artık kalıtımsal olarak bir örnek alınamaz.
        // Sealed anahtar sözcüğü ile mühürlenen nesneler en fazla başka bir nesnenin içerisinde InnerType olarak kullanılabilir.
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesi yapıcı metodu çalıştı.");
            // TemelTipMetot2(); => Protected erişim belirleyicisi ile işaretlenen TemelTipMetot2 metodu içinde bulunduğu classın dışında ancak çağırıldığı class, nesne tanımlaması yapıldığı
            // class tarafından türetildiyse kullanılabilir
        }

    }
}
