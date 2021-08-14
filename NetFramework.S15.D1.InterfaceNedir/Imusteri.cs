using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public interface Imusteri
    {
        // Field'lar

        int Id { get; set; }
        string isim { get; set; }
        string soyIsim { get; set; }

        // Metotlar

        int YeniKayit(string isim, string soyisim);
        int KayitDuzenle(int id, string isim, string soyisim);
        int KayitSil(int id);
    }
}
