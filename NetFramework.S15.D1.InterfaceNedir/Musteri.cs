using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public class Musteri : Imusteri
    {
        private int _id;
        private string _isim;
        private string _soyisim;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string isim
        {
            get { return _isim; }
            set { _isim = value; }
        }

        public string soyIsim
        {
            get { return _soyisim; }
            set { _soyisim = value; }
        }

        public int YeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("YeniKayit() metodu çalıştı.");
            return 1;
        }

        public int KayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("KayitDuzenle() metodu çalıştı.");
            return 1;
        }

        public int KayitSil(int id)
        {
            Console.WriteLine("KayitSil() metodu çalıştı.");
            return 1;
        }
    }
}
