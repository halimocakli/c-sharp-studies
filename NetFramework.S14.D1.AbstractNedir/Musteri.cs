using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    public class Musteri : BaseClass
    {
        public int MusteriID { get; set; }

        public Musteri()
        {
            MusteriID = 1;
        }

        /*
         * Musteri sınıfı BaseClass sınıfından kalıtıldı. BaseClass sınıfı abstract bir sınıf. Yani Program sınıfı içerisinde örneklendiğinde yukarıda gördüğünüz üzere
         * hata alıyoruz. Peki BaseClass'tan kalıtılan Musteri sınıfını burada örneklersek nasıl bir sonuç alırız? Bu noktada Kalıtım mimarisi kendinden ödün vermez
         * ve tıpkı önceki uygulamalarda gördüğümüz üzere yapıcı metotlar üzerinden giderek işlemi tamamlar ve fieldlara değerler atanır. Dikkat ederseniz BaseClass'In kendisini
         * örneklediğimizde hata aldık ama BaseClass'tan kalıtılan bir sınıfı örneklediğimizde hata almadık.
         */

        public override void TestAbstract()
        {
            Console.WriteLine("Musteri sınıfının içerisindeki TestAbstract() metodu çalıştı.");
        }
    }
}
