using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    // Egitmen Classının yanına iki nokta koyduktan sonra TemelTip Classımı ekledim.
    // Dolayısıyla artık Egitmen sınıfı, TemelTip sınıfının içerisinde bulunan tüm field ve metotları miras aldı ve onları kullanma hakkı kazandı.
    // TemelTip sınıfını entegre edildi

    // Eski Hali => public sealed class Egitmen: TemelTip
    public sealed class Egitmen : Personel
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }

        /*
         * Program nesnemiz içerisinde de bahsettiğimiz üzere aşağıdaki fieldlar Personel nesnemize özel olduğu için Egitmen nesnesi içerisinden silindi ve Egitmen nesnesi Personel
         * nesnesinden kalıtılarak aşağıdaki fieldların Egitmen nesnesi tarafından da kullanımına imkan sağlandı.
         *
         * public DateTime IsBaslangicTarihi { get; set; }
         * public DateTime IsBitisTarihi { get; set; }
         * public int IzinGunSayisi { get; set; }
         */

        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesinin yapıcı metodu çalıştı");
        }

    }
}
