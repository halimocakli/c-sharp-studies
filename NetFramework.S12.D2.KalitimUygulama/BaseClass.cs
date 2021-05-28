using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    public class BaseClass
    {
        public static int sayac = 1;    // İlk oluştuğunda 1 değerini otomatik olarak alsın
        public BaseClass()
        {
            _ID = sayac;
            sayac++;
        }

        private int _ID; // BaseClass'tan türeyen nesnelerin id değerini manuel olarak vermek yerine otomatik bir yapı oluşturulacak
        public int ID
        {
            // BaseClass'tan türeyen nesnelerin id değerini manuel olarak vermek yerine otomatik bir yapı oluşturulacak
            get
            {
                return this._ID;
            }
            private set { }

        }

        private string _Barkod;
        public string Barkod
        {
            get { return _Barkod; }
            set
            {
                bool kontrolIslemi = SanalDatabase.DbBarkodKontrol(value);
                if (!kontrolIslemi) // Değer SanalDatabase içerisinde bulunamadı dolayısıyla ekleme yapacağız.
                {
                    _Barkod = value;
                }
                else
                {
                    Console.WriteLine("Bu barkod değeri daha önce SanalDatabase'e girilmiştir.");
                }
            }
        }  // Her ürün barkodu unique olmak zorunda

        public DateTime OlusturmaTarih { get; set; }
        public int OlusturanKullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int GuncelleyenKullanici { get; set; }
        public bool Silindi { get; set; }
    }
}
