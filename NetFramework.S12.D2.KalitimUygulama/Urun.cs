using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    public class Urun : BaseClass
    {
        // Urun classımıza özel propertyleri buraya ekleyeceğiz

        public string Marka { get; set; }   // Belirtmiş olduğumuz markalar dahilinde ürün eklenebilsin
        public string Model { get; set; }

        private decimal _AlisFiyat; // 0'dan küçük olamaz
        public decimal AlisFiyat
        {
            get { return this._AlisFiyat; }
            set
            {
                if (value > 0)
                {
                    _AlisFiyat = value;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz ürün alış fiyatı sıfıran küçük veya sıfıra eşit olamaz.");
                }
            }
        }

        private decimal _SatisFiyat;    // AlisFiyat'tan küçük olamaz
        public decimal SatisFiyat
        {
            get { return _SatisFiyat; }
            set
            {
                if (value >= _AlisFiyat)
                {
                    _SatisFiyat = value;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz ürün satış fiyatı, alış fiyatından küçük olamaz");
                }
            }
        }

        private decimal _KampanyaFiyat; // 0'dan küçük olamaz
        public decimal KapmanyaFiyat
        {
            get { return _KampanyaFiyat; }
            set
            {
                if (value >= 0)
                {
                    _KampanyaFiyat = value;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz kapmanya fiyatı negatif değer olamaz.");
                }
            }
        }
    }
}
