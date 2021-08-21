using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    public interface ICustomerModel
    {
    // Bu Interface'i oluşturma sebebimiz, bir sınıftan kısa yoldan nasıl Interface oluşturacağımızı göstermektir.
    // Bu Interface'i CustomerModel sınıfından oluşturduk.
    // CustomerModel üzerine gelip Ctrl + . => Interface içindeki ögeleri seç => oluştur

    string Adres { get; set; }
    string EmailAdres { get; set; }
    string Isim { get; set; }
    string Sehir { get; set; }
    string SoyIsim { get; set; }
    string TelefonNumarasi { get; set; }
    }
}
