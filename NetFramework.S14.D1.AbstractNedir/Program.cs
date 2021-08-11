using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Sınıf Giriş - Sefer Algan

            /*
             * Nene yönelimli programlamada sınıf hiyerarşisi oluştururken bazen hiyerarşinin en tepesinde bulunan sınıf türünden nesnelerin programcı için pek bir anlamı
             * olmayabilir. Hiyerarşinin en tepesinde bulunan sınıfın kendisinden türerilecek diğer sınıflar için ortak özellikleri bir araya getiren bir arayüz gibi davranmasını
             * isteyebiliriz. Örneğin Memeli sınıfında tanımlanan Konus() isimli bir metot çağrıldığında yapılacak iş belli değildir. Çünkü hangi memeli hayvanın mimikleri ile
             * konuşacağı belli değildir. Eğer Konus() metodu memeli sınıfında bildirilmezse bu sefer Memeli sınıfında türeyecek sınıfların (Kedi, Koyun) çok biçimliliği desteklememesi
             * söz konusu olur. O zaman bir tek çözüm var: Memeli sınıfında Konus() metodu bildirilsin ama herhangi bir iş yapması için özelleştirlmesin, sadece Memeli sınıfından
             * türeyecek diğer sınıflar için bir arayüz oluştursun. İşte bu tür metotlara ve sınıflara ABSTRACT METOT YA DA ABSTRACT SINIF denir.
             *
             * Abstract sınıflar ya abstract metotlar "abstract" anahtar sözcüğü kullanılarak bildirilir. Bir temel sınıf içerisinde bildirilen abstract metotların temel sınıf içerisinde
             * gövdesi yoktur. Ancak bu temel sınıftan türeyen bütün sınıflar bu metodu devre dışı bırakmalıdır yani override etmelidir. Abstract metotlar içsel olarak zaten Virtual
             * oldukları için ayrıca "virtual" anahtar sözcüğünü kullanarak virtual olduklarını belirtmeye gerek yoktur.
             *
             * Abstract sınıflar ve abstract metotlar "abstract" anahtar sözcüğü kullanılarak bildirilir. Bir abstract sınıf türünden nesne tanımlanamaz. Abstract sınıflar sadece
             * kendilerinden türeyen sınıflar için bir arayüz oluştururlar.
             *
             * Abstract sınıflar temel sınıfın tek başına anlamlı bir nesneyi ifade etmediği durumlarda kullanılır. Abstract sınıfları kullanabilmek için bu sınıflardan türeyen
             * yeni sınıflar bildirmemiz gerekir.
             *
             * Abstract bir sınıftan türeyen sınıf nesneleri üzerinden abstract sınıfa ait yapıcı metotlar kullanılarak abstract sınıfın üye değişkenleri değiştirilebilir. Örneğin:
             */

            Kedi kedi = new Kedi("Van", 5, 13);
            Console.WriteLine("Kedinin eni= " + kedi.en);
            Console.WriteLine("Kedinin boyu= " + kedi.boy);

            Console.WriteLine();

            /*
             * Metot ve sınıflar gibi property'ler de abstract olarak bildirilebilir.
             *
             *      abstract class AbstractProperty
             *      {
             *          abstract public int A
             *          {
             *              get;
             *              set;
             *          }
             *      }
             *
             * AbstractProperty sınıfından türeyen bir sınıf A properysini hem get hem de set bloklarıyla beraber uygulamak zorundadır. Eğer temel sınıfta get ya da set bloklarından
             * herhangi biri bildirilmemiş olsaydı tureyen sınıfta sadece ilgili bloklar yazılırdı.
             */

            #endregion

            #region Abstract Sınıf Giriş - Cengiz Atilla 

            /*
             * - C# programlama dilinde aslında VIP dediğimiz alana geldik. Bu bölümde öğreneceğimiz konuların örnek kullanımları ve açıklamaları
             * uygulama yaptığımız zaman net olarak anlaşılacaktır.
             *
             * - Bölüme başlamadan önce neden bu bölümden VIP olarak bahsettiğimiz üzerinde duralım. Interface veya Abstract (Interface daha sık kullanılır)
             * aslında bizim uygulama içerisinde kullanmayacağımız ama her noktada varlığından faydalanacağımız tanımlardır.
             *
             * - Kurumsal projelerde kodlama yaptığımızda çok sık göreceğimiz bu bu kavramları kendi başımıza proje yaptığımız zaman (tasarım deseni olarak zorunlu değilse) kullanmayız.
             * Fakat kurumsal projelerde bir ekibin kodlanmasında görev alıyorsak sık sık kullandığımız tanımlardır.
             *
             * - Hatırlarsanız nesne yönelimli programlama konusuna girdiğimiz bölümlerden bu yana devamlı olarak nesnelerimizi oluşturduk ve farklı kullanımlar olsa bir şekilde
             * nesnemizi örnekledik ve kullandık. Nesnelerimizin içerisinde birçok tanım oluşturduk ve bu tanımları çağırıp kullandık.
             *
             * => Abstract ve Interface tanımlarında bir örnekleme işlemi söz konusu değildir. Kendimize işi yapacak bir rol model çıkartırız. Nasıl olacağının kurallarını
             * hazırlar ve nesnelerimizde kurallarımızı kullanırız.
             *
             * Bu bölümde, oluşturmuş olduğumuz nesnelerimizi nasıl kurallar ile şartlayabileceğimizi konuşacağız.
             *
             * Not: Bu bölümde anlatılan konular biraz havada kalabilir. Bu konuları pratik yaparak oturtabilmek için derslerde biraz ilerlememiz gerekiyor.
             */

            // => BaseClass sınıfında aldığımız notu buraya aktaralım:
            /*
             * BaseClass sınıfının bildiriminde abstract anahtar sözcüğü kullandığımızda çalışma mantığı değişir. Uygulamaya BaseClass sınıfını şablon olarak kullanacağımızı
             * bildirmiş oluyoruz. Biz bu sınıfı bir kural kütüphanesi gibi görmek istiyoruz. BaseClass sınıfından kalıtılan sınıflar, bu kısımda yazdığımız kurallara uysunlar istiyoruz.
             * Böyle bir durumda Program sınıfında örneklediğimiz BaseClass nesnesi hata verir çünkü abstract olarak bildirilen sınıf türlerinden nesne örneklenemez.
             */
            // => BaseClass T1 = new BaseClass(); <=
            // BaseClass sınıfımızı şablon olarak düzenledik. Peki biz bu şablonu nerede kullanacağız? Bir başka sınıfta kullanacağız.

            /*
             * Musteri sınıfı BaseClass sınıfından kalıtıldı. BaseClass sınıfı abstract bir sınıf. Yani Program sınıfı içerisinde örneklendiğinde yukarıda gördüğünüz üzere
             * hata alıyoruz. Peki BaseClass'tan kalıtılan Musteri sınıfını burada örneklersek nasıl bir sonuç alırız? Bu noktada Kalıtım mimarisi kendinden ödün vermez
             * ve tıpkı önceki uygulamalarda gördüğümüz üzere yapıcı metotlar üzerinden giderek işlemi tamamlar ve fieldlara değerler atanır. Dikkat ederseniz BaseClass'In kendisini
             * örneklediğimizde hata aldık ama BaseClass'tan kalıtılan bir sınıfı örneklediğimizde hata almadık. Kalıtım kuralları gereği bu şekilde olmalı.
             */

            Musteri M1 = new Musteri();
            M1.Test();
            M1.TestAbstract();

            /*
             * Peki biz "Abstract" anahtar sözcüğünü ne zaman kullanırız? Ekip olarak bir kod yazdığımızı düşünün ve database'e giden bir metot şeklimiz olmalı. Ekip içerisindeki
             * her elemanın kendi işini yaptığını ve kendi alanında çözümler üretmeye çalıştığını bu nedenle bir karmaşa yaşandığını hayal edin. Bu karmaşanın içerisinde şöyle bir
             * karar verdik: projemiz içerisinde ortak amaçla kullanacağımız bazı metotlar olabilir ve herkes kendi çözümünü üretmeye çalışırken bu metotlara birbirinden farklı
             * isimler verebilir. Dolayısıyla aynı işleve sahip birden fazla farklı isimli metot üretilir ki bunu istemeyiz. O halde bir kolaylık olması için standart metot ismi
             * belirleyelim. İşte tam bu noktada belirli bir işleve sahip ve birden fazla ekip üyesinin üzerinde çalışacağı metot ismi Abstract ve Interface ile belirlenerek
             * şablon haline getirilir. Böylece yukarıda da bahsettiğimiz gibi şablon sınıfı olarak oluşturduğumuz BaseClass sınıfı içerisinde şablon haline getirdiğimiz metodu,
             * BaseClass'tan kalıtılan her sınıf içerisinde aynı isimle kullanılmak zorunda kalırız ve bu bize büyük kolaylık sağlar.
             */

            // KISACASI ABSTRACT BİR YOL GÖSTERİCİDİR.

            SuperMusteri SP1 = new SuperMusteri();
            SP1.TestAbstract(); // Musteri uzerinde override edilen TestAbstract() metoduna ulaşıp onu kullanacak.

            #endregion

            #region Özet

            /* SONUÇ
             *
             * Abstract sınıflar başka sınıflardan türetilmez ve örneklenemez, dolayısıyla direkt Abstract sınıf nesnesi üzerinden çağırılamaz. Kullanmak için Abstract
             * sınıftan türeyen sınıf üzerinden nesne örneklemesi yapılır ve bu nesne üzerinden Abstract sınıf metotlarına ulaşılır. Abstract sınıfın metotları da
             * Abstract ise bu metotların bodysi olamaz ve Abstract sınıftan kalıtılan sınıflar yoluyla bodysi yazılarak kullanılır. Abstract içerisinde statik metot
             * bildirilmez ve Virtual anahtar sözcüğü ile işaretlenen metot kullanılamaz çünkü Virtual metodun bir bodysi olmak zorundandır ve eğer metot bir Abstract metot ise
             * bodysi olamayacağı için Virtual anahtar sözcüğü ile işaretlenemez. Ancak metot Abstract değilse Virtual kullanılabilir.
             *
             * 1-) Abstract sınıf türünden nesneler tanımlanamaz.
             * 2-) Abstract sınıflar, abstract metotlar içerebilir. Abstract metotlar ancak abstract sınıf içerisinde bildirilebilir.
             * 3-) Abstract sınıflar "sealed" anahtar sözcüğü ile işaretlenemezler. "sealed" anahtar sözcüğü bir sınıftan türetme yapılamaycağını bildirir.
             * 4-) Abstract bir sınıftan türeyen sınıflar temel sınıftaki bütün abstract metotları uygulamalıdır. Yani metodun gerçek gövdesi türeyen sınıflarda yazılmalıdır.
             * 5-) Bütün abstract sınıflar içsel olarak vbirtual'dur. Bu yüzden ayrıca virtual olduklarını belirtmeye gerek yoktur.
             * 6-) Abstract metotlar türeyen sınıfta mutlaka bildirilmelidir.
             * 7-) Statik metotlar abstract olarak bildirilemez. Aynı şekilde abstract metot bildiriminde override ve virtual anahtar sözcükler kullanılamaz.
             * 8-) Sınıflarda abstract propertyler de bildirilebilir, türeyen sınıflarda bu abstract propertyler override anahtar sözcüğü ile tekrar bildirilmelidir.
             */

            #endregion

            Console.ReadLine();
        }
    }
}
