using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    public class PhysicalProductModel : PhysicalProductBaseClass, IProductModel
    {
        // Bu sınıf bir fizksel ürün sınıfıdır. Dolayısıyla ürünleri kargo ile göndermemiz gerekiyor.
        public string UrunAdi { get; set; }
        public bool SiparisGerceklesmeKontrol { get; private set; }

        public void UrunSevk(CustomerModel musteri)
        {
            if (SiparisGerceklesmeKontrol == false)
            {
                Console.WriteLine($"{ UrunAdi } siparişinin sevk simülesyonu { musteri.Isim } adlı müşteri icin { musteri.Sehir } konumu hedeflenerek başlatılıyor");
                SiparisGerceklesmeKontrol = true;
            }
        }
    }
}