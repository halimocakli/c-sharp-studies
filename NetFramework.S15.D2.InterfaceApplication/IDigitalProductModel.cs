using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    public interface IDigitalProductModel : IProductModel
    {
        /*
         * Görüldüğü gibi IDigitalProductModel Interface'ine IProductModel Interface'i implement edilebiliyor.
         * Bu durum daha sağlıklı bir kod oluşmasını sağlar çünkü dikkat ederseniz Program Class'ı dosyası içerisinde bulunan OrnekVeriEkle() metodu
         * içerisinde DigitalProduct türünden bir itemi IProductModel Interface'i türünden elemanlar tutan listeye ekliyoruz. IProductModel
         * Interface'ini IDigitalProduct Interface'ine implement ettiğimiz için bir problem çıkmayacaktır. Class Inheritence gibi düşünebiliriz.
         */

        // Program Class'ı içerisinde bulunan foreach bloğu içindeki if bloğuna giderek notları okursanız daha iyi anlarsınız
        int GeriyeKalanIndirmeler { get; }
    }
}
