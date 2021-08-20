using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    public class DigitalProduct : IDigitalProductModel
    {
        // Bu sınıf bir dijital ürün sınıfıdır. Örnek olarak: Film, Yazılım, Dijital Gazete vs.
        // Dolayısıyla bu ürünü diğer ürünler gibi sevk edemeyiz ya da adrese gönderemeyiz.
        // Sonuç olarak dijital ürünü ancak e-mail ile gönderebiliriz.

        public string UrunAdi { get; set; }

        public bool SiparisGerceklesmeKontrol { get; private set; }

        public int GeriyeKalanIndirmeler { get; private set; } = 5;

        public void UrunSevk(CustomerModel musteri)
        {
            if (SiparisGerceklesmeKontrol == false)
            {
                Console.WriteLine($"{ UrunAdi } siparişinin mail ile gönderilme işlemi { musteri.Isim } adlı müşteri icin { musteri.EmailAdres } adresi hedeflenerek başlatılıyor");
                GeriyeKalanIndirmeler--;
                if (GeriyeKalanIndirmeler < 1)
                {
                    SiparisGerceklesmeKontrol = true;
                    GeriyeKalanIndirmeler = 0;
                }
            }
        }
    }
}
