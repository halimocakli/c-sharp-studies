using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public class Musteri
    {
        public int  ID { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string eMailAdres { get; set; }

        public int YeniKayit(Musteri m)
        {
            Console.WriteLine("Database'e kayıt işlemi tamamladı");
            return 1;
        }

        public int KayitGuncelle(Musteri m)
        {
            Console.WriteLine("Müşteri kaydı güncellendi");
            return 1;
        }

        public int KayitSil(int id)
        {
            Console.WriteLine("Müşteri kaydı silindi");
            return 1;
        }
    }
}
