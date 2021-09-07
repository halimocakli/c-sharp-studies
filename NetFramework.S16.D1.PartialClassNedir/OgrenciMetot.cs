using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public partial class Ogrenci
    {
        public int YeniKayitOgrenci(Ogrenci o)
        {
            Console.WriteLine("Öğrenci kayıt işlemi başarılı");
            return 1;
        }

        public int KayitGuncelleOgrenci(Ogrenci o)
        {
            Console.WriteLine("Oğrenci kaydı güncellendi");
            return 1;
        }

        public int KayitSilOgrenci(int id)
        {
            Console.WriteLine("Öğrenci kaydı silindi");
            return 1;
        }
    }
}
