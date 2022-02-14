using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    public abstract class BaseClass
    {
        /*
         * BaseClass sınıfının bildiriminde abstract anahtar sözcüğü kullandığımızda çalışma mantığı değişir. Uygulamaya BaseClass sınıfını şablon olarak kullanacağımızı
         * bildirmiş oluyoruz. Biz bu sınıfı bir kural kütüphanesi gibi görmek istiyoruz. BaseClass sınıfından kalıtılan sınıflar, bu kısımda yazdığımız kurallara uysunlar istiyoruz.
         * Böyle bir durumda Program sınıfında örneklediğimiz BaseClass nesnesi hata verir çünkü abstract olarak bildirilen sınıf türlerinden nesne örneklenemez.
         *
         * Not: Abstract ile işaretlenmiş sınıf Sealed anahtar sözcüğüyle kalıtılmamak üzere mühürlenemez ya da Static olarak kullanılamaz.
         */

        public DateTime KayitTarih { get; set; }
        public DateTime GuncellemeTarih { get; set; }

        public BaseClass()
        {
            KayitTarih = DateTime.Now;
            GuncellemeTarih = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("BaseClass içerisindeki Test() metodu çalıştı");
        }

        /*
         * Abstract olarak işaretlediğimiz metotların metot bodyleri olmaz. Peki neden olmaz? Biz şunu söylüyoruz, ben bir şablon(abstract) sınıf hazırlayacağım(BaseClass) ve
         * hazırlamış olduğum bu şablon sınıf içerisinde bazı metotların da şablon olarak durmasını istiyorum ve bu sınıfı(BaseClass) kalıtan diğer nesne(Musteri), benim içeride
         * şablon olacak şekilde hazırlamış olduğum bu şablonları kullanmak zorunda kalsın. Tam olarak anlatmaya ve uygulamaya çalıştığımız şey bu. BaseClass sınıfı, Program
         * sınıfında yani ana sınıfımızda nesne örneği alınamayan, bir başka programcı tarafından erişilebilir olsa bile new ile örneklenemeyen, içerisinde benim hazırladığım
         * metotları ve benim yazmış olduğum fieldları karşı tarafa verdiğim zaman kullanmasını zorunlu kıldığım bir şablondur, bir kurallar yığınıdır. Dolayısıyla aşağıda
         * ürettiğimiz TestAbstract() metodu halihazırda bir şablon metottur ve zaten metodu çağıran nesne onu ezmek zorunda kalacağı için metodun bodysine ihtiyaç yoktur.
         * Yalnızca metot imzası dediğimiz bölüm yazılır ve bırakılır.
         *
         * Not: Abstract anahtar sözcüğü bir metot imzası değildir.
         *
         * Aslında TestAbstract metodunu oluşturarak, -BaseClass sınıfından kalıtılan nesneye- eğer bu nesneyi kalıtıyorsan bu şekilde bir metot oluştur ve bunun bodysini
         * kendi içinde yaz diyoruz(Bu uygulamada bunu musteri sınıfına söylüyoruz).
         *
         * Musteri sınıfına gittiğimizde göreceğiz ki sınıf içerisinde TestAbstract() metodunun bodysi yazılmadığı için Musteri sınıfı hata vermekte. Çünkü Musteri sınıfı BaseClass
         * sınıfından kalıtıldı ve dolayısıyla BaseClass sınıfı içerisinde yazılan tüm Abstract metotlar Musteri sınıfı içerisinde ya da BaseClass sınıfından kalıtılan 
         * tüm sınıflar içerisinde kullanılmak ve bodysi yazılmak zorunda.
         */
        public abstract void TestAbstract();

        // Dolayısıyla Musteri sınıfı içerisinde bir TestAbstract() metodu oluşturduk ve Override ederek çalıştırdık

    }

}
