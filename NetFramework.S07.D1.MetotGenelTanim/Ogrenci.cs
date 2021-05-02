using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D1.MetotGenelTanim
{
    public class Ogrenci
    {
        // Class'ımızı bütün uygulama içerisinde kullanabilmek için erişim belirleyicimizi "public" olarak ekleyelim.
        // Yani Program classı üzerinden, Ogrenci classı içindeki metodu çağırmak ve kullanmak istiyorsak erişim belirleyicimizi public olarak belirlemeliyiz.
        // Metotlarımız geriye bir değer döndürmüyorsa "void" olarak etiketleyebiliriz.

        public void selamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci");
        }

        /* Bir metot tanımlamak için nelere ihtiyacımız var?
         *
         * [ErisimBelirleyicisi] <GeriDonusDegeri> MetotAdi (Parametreler)
         * {
         *      Metot için gerek kodlar...
         * }
         * Yukarıda bir metodun prototipini görüyorusunuz
         *
         ************************************************
         * Erişim Belirleyicisi
         *
         * Public  => Metot, kendi classının dışında da kullanılabilir
         * Private => Metot, kendi classının dışında bir classta kullanılamaz
         * Protected
         * Internal
         * Internal Protected
         */

        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        private void OgrenciMetot2(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        public void OgrenciMetot3(string ogrenciAdi, string ogrenciSoyadi)
        {
            OgrenciMetot2("Halim","Ocaklı");
        }

        /* Yukarıdaki örnekleri özetleyecek olursak;
         *
         * OgrenciMetot1() metodumuz "public" erişim belirleyicisine sahip olduğu için,
         * hem kendi class'ı içerisinden hem de başka bir class içerisinden çağırılabilir/erişilebilir.
         * Bununla birlikte Program isimle class içerisinde çağırılmıştır.
         *
         *
         * OgrenciMetot2() metodumuz "private" erişim belirleyicisine sahip olduğu için,
         * kendi classından/içinde bulunduğu classtan başka bir classta kullanılamaz ve o class içerisinden çağırılamaz.
         * Bununla birlikte Ogrenci class'ı içerisinde bulunan OgrenciMetot3 metodu yoluyla çağırılmıştır.
         *
         *
         * OgrenciMetot3() metodumuz "public" erişim belirleyicisine sahip olduğu için,
         * hem kendi class'ı içerisinden hem de başka bir class içerisinden çağırılabilir/erişilebilir.
         * Bu metot içerisinde OgrenciMetot2() metodu çağırılmıştır. Dolayısıyla OgrenciMetot3() metodunu kullanarak
         * OgrenciMetot2() metodunu hem halihazırda içinde bulunduğu class içerisinde çağırabilir hem de içinde bulunduğu
         * classtan farklı bir class içerisinde kullanabiliriz.
         *
         */
    }
}
