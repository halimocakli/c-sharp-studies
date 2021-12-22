using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir
{
    public class Musteri
    {
        public int musteriID { get; set; }
        public Guid musteriNumara { get; set; }
        public string musteriIsim { get; set; }
        public string musteriSoyIsim { get; set; }
        public DateTime musteriDogumTarihi { get; set; }
    }
}
