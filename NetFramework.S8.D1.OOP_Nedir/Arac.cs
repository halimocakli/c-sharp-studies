using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S08.D1.OOP_Nedir
{
    class Arac
    {
        // boş
        // Marka model
        // Marka model model yıl
        // marka model model yıl Km

        // void BilgileriGoruntule();
        // void FiyatAta();

        // satış fiyatı - max indirim tutarı

        public string Marka;
        public string Model;
        public decimal AlisFiyati;
        public decimal SatisFiyati;
        public decimal MaxIndirimTutari;
        public decimal Fiyat;
        public decimal Km;
        public int ModelYil;
        public int YakitTipi;
        public int VitesTipi;


        public Arac()
        { }

        public Arac(string _aracMarka, string _aracModel)
        {
            Marka = _aracMarka;
            Model = _aracModel;
        }

        public Arac(string _aracMarka, string _aracModel, int _aracModelYil)
        {
            Marka = _aracMarka;
            Model = _aracModel;
            ModelYil = _aracModelYil;
        }

        public Arac(string _aracMarka, string _aracModel, int _aracModelYil, decimal _aracKm)
        {
            Marka = _aracMarka;
            Model = _aracModel;
            ModelYil = _aracModelYil;
            this.Km = _aracKm;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka : {0} - Model : {1} - Model Yil : {2}", Marka, Model, ModelYil);
        }

        public void FiyatBelirle(decimal _aracFiyat)
        {
            decimal fiyatHesap = SatisFiyati - MaxIndirimTutari;
            if (_aracFiyat < fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi");
            }
            else
            {
                this.Fiyat = _aracFiyat;
                Console.WriteLine("Fiyat güncellendi");
            }
        }
    }
}
