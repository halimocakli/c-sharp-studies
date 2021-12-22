using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNeDegildir
{
    public class MusteriGenericClass<T> // <T> standart kalıpır ve opsiyoneldir
    {
        public T musteriID { get; set; }
        public T musteriNumara { get; set; }
        public string musteriTcKimlikNumarasi { get; set; }
        public string musteriIsim { get; set; }
        public string musteriSoyIsim { get; set; }
        public DateTime musteriDogumTarihi { get; set; }

        public T musteriNumarasiAl()
        {
            return musteriNumara;
        }
    }
}
