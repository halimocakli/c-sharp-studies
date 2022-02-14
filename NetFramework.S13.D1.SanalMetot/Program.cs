using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sanal Metotlar - Giriş

            /*
             * Şu ana kadar bir nesne üzerinden çağırdığımız metotların tamamı derleme zamanında belirgindi. Yani derleme aşamasında hangi nesne üzerinden hangi metotların
             * çağrılabileceği bilinmekteydi. Şu ana kadar öğrendiğimiz bilgilerle bunun aksini gerçekleştirmek zaten mümkün değildir. Ancak bu kısımda göreceğimiz sanal metot
             * kavramı ile çalışma zamanında metot seçme işinin nasıl olduğunu inceleyeceğiz.
             *
             * Sanal metotlar temel sınıflar içerisinde bildirilmiş ve türeyen sınıflar içerisinde de tekrar bildirilen metotlardır. Sanal metotlar OOP tekniğindeki çok biçimli-
             * liği (polymorphism) uygulayan yapılardır. Temel sınıfta bir sanal metot bildirildiğinde bu temel sınıftan türeyen sınıflar, temel sınıftaki sanal metodu devre dışı
             * bırakarak kendilerine uygun metot gövdesi oluşturabilirler. Sanal metotların en önemli özelliği geç bağlam (late binding) özelliğini desteklemesidir.
             *
             * Sanal metotlar sayesinde temel sınıf türünden bir referansa, türeyen sınıf referansları aktarıldığında, temel sınıf referansı üzerinden kendisine aktarılan türeyen
             * sınıfın sanal metodu çağrılabilir. Eğer türeyen sınıf sanal metodu devre dışı bırakmamışsa temel sınıftaki sanal metot çağrılır. Çağrılan metodun hangi türe ait
             * olduğu ise çalışma zamanında belirlenir. Metotların bu şekilde çalışma zamanında belirlenmesine LATE BINDING denir.
             *
             * Sanal metotlar "virtual" anahtar sözcüğü kullanılarak bildirilir. Bu anahtar sözcük, metot bildiriminin başına eklenirse soyut metotlar bildirilmiş olur. Türeyen
             * sınıfta, temel sınıftaki virtual metotları devre dışı bırakmak için ise "override" anahtar sözcüğü kullanılır.
             */

            /*
             * - Bir önceki bölüm içerisinde Kalıtım konusunu inceledik. Hatırlarsanız kalıtım içerisinde, kalıtılan sınıf, kendisini kalıtan sınıfa içerisindeki private
             * metotlar haricinde tüm metotlar için kullanım izni sunmaktaydı.
             *
             * - Örnek olarak BaseClass adına sahip sınıfımı Urun sınıfı kalıttığı zaman BaseClass içerisinde bulunan metotlara ve özelliklere erişebiliyor, BaseClass içerisindeki
             * tanımları kendi tanımları gibi kullanabiliyordu.
             *
             * - BaseClass içerisinde EkranaYaz adında bir metot olsa Urun sınıfı içerisinde EkranaYaz metodu çağırıldığı zaman BaseClass içerisinde bulunan şekli ile çalışıp
             * metot işlemini tamamlayabiliyordu.
             *
             * - Sanal metot dediğimiz bu bölümümüzde BaseClass içerisinde bulunan bir metodun istenilirse türeyen sınıf içerisinde nasıl yeniden şekillenebileceğini inceleyeceğiz.
             *
             * - Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı metotların object nesnesinden bize geldiğini hatırlatmıştık.
             *
             * - Birazdan sanal metot anlatımına object içerisinde bize standart olarak gelen ToString metodunu inceleyerek başlayacağız.
             *
             * - Sanal metotları, X-Men filminde bulunan Mystique karakterine benzeteibiliriz. Ortama göre kendi şeklini değiştirebilen bir karakter olması buna örnek olabilir.
             *
             * - Object => ToString();
             *
             * Musteri M1 = new Musteri();
             * - Yukarıdaki nesne örnekleme işlemini artık biliyoruz. Örnekleme işlemi yapılırken arka planda Musteri nesnesi Object nesnesinden kalıtılır ve Object nesnesinin
             * sahip olduğu bütün metot ve özellikleri kullanabilir. ToString(); metodu buna örnek olarak verilebilir.
             *
             * - ToString(); metodunun kendine özgü bir çalışma stili var. ToString(); metodunu çağırdığımız zaman çağırılan classın Namespace'sini ve Class adını bize
             * geri döndürür. Bu .Net Framework içerisindeki standart kullanım şeklidir.
             *
             * - Object nesnesi içerisinde gelen ToString(); metodu sanal bir metottur ve body kısmını/içeriğini değiştirebiliriz. 
             */

            #endregion

            #region Örnek - 1

            Musteri M1 = new Musteri();
            M1.Isim = "Halim Can";
            M1.SoyIsim = "Ocaklı";
            string ToStringMesage = M1.ToString();
            Console.WriteLine(ToStringMesage);

            // Yukarıda bahsettiğimiz üzere ToString(); metodu çağırıldığı sınıfın Namespace'ini ve Class adını bize geri döndürecek
            // => NetFramework.S13.D1.SanalMetotNedir.Musteri

            #endregion

            // Birkaç örnek daha yaparak devam edelim.

            Console.WriteLine();

            #region Örnek - 2

            Memeli memeli1 = new Memeli(10, 30);
            Kedi kedi1 = new Kedi("Ankara", 5, 10);
            Koyun koyun1 = new Koyun("Merinos", 50, 65);

            memeli1 = kedi1;
            memeli1.Konus();

            memeli1 = koyun1;
            memeli1.Konus();

            /*
             * Yukarıdaki programı derleyip çalıştırdığımızda;
             *
             * => Ben bir kediyim!
             * => Ben bir koyunum!
             *
             * yazdığını görürüz. Eğer Konus() metodu sanal metot olmasaydı;
             *
             * => Ben konuşamam
             *
             * yazısı yazacaktı. Yani Memeli sınıfındaki metot çağrılacaktı.
             */

            #endregion

            /* !ÖNEMLİ!
             *
             * Sanal metotlar sayesinde temel sınıf referanslarına, türeyen sınıf referansları atandığında, temel sınıf referansı üzerinden türeyen sınıfa ait metotları
             * çağırabilmekteyiz. Bu yöntemle sadece temel sınıfta sanal olarak bildirilmiş metotların türeyen sınıfta devre dışı bırakılmış olan metotlarına erişilebilir.
             */

            Console.WriteLine();

            #region Örnek - 3

            /*
             * Şimdi sanal sınıfların etkili kullanımına bir örnek daha verelim. Aşağıdaki programda statik AlanBul() metodu kendisine gönderilen Ucgen ve Dortgen nesnelerinin
             * alanlarını ekrana yazdırmaktadır. AlanBul() metodu parametre olarak Sekil türünden nesneler beklemesine rağmen Sekil sınıfında tanımlanan sanal Alan() metodu
             * sayesinde metodun parametresi olan Sekil referansı üzerinden Alan() metodu her sınıf için ayrı ayrı olacak şekilde çağrılmaktadır.
             */

            Ucgen ucgen = new Ucgen(10, 50);
            AlanBul(ucgen);

            Dortgen dortgen = new Dortgen(10, 50);
            AlanBul(dortgen);

            Sekil sekil = new Sekil(10, 50);
            AlanBul(sekil);

            /*
             * Gördüğünüz gibi statik AlanBul() metodu Sekil türünden bir parametre beklemesine rağmen Sekil türünden türeyen Ucgen ve Dortgen nesnelerini de kabul etmektedir.
             * Üstelik bu Ucgen ve Dortgen nesneleri metodun parametresi olan Sekil nesnesine aktarılmasına rağmen Ucgen ve Dortgen sınıflarındaki Alan() metotları çağırılabildi.
             * Bunu sağlayan da şüphesiz Alan() metodunun sanal olarak bildirilmesi ve türeyen sınıflarda bu metodun devre dışı bırakılmasıdır.
             */
            #endregion

            // Türeyen sınıflar, temel sınıflardaki sanal metotları devre dışı bırakmak zorunda değildir.
            // Böyle bir durumda eğer temel sınıf referansına, türeyen sınıf referansı aktarılırsa bu referans üzerinden temel sınıfa ait sanal metot çağırılır.
            // Hiyerarşik yapıdaki sınıflarda, yukarıda bahsettiğimiz durum gerçekleşirse sınıf hiyerarşisinde en alttan en üste doğru ilgili metodun devre dışı bırakıldığı sınıfa ait metot çalıştırılır.

            /*
             * Bu örneklerde de görüldüğü üzere tek bir metot ile birçok sınıfa ait farklı versiyondaki metotlar çağırılabilmektedir. Üstelik bu işlem aynı nesne
             * üzerinden gerçekleşmektedir. Bir nesnenin bu şekilde çoklu özellik göstermesine ÇOK ÇEŞİTLİLİK - POLYMORPHİSM denilmektedir.
             */

            #region Özet

            /*
             * 1-) Eğer metot sanal olarak bildirilmemişse, derleyici nesnelerin tür bilgisinden faydalanarak derleme zamanında hangi metodun çağırılacağını bilir.
             * 2-) Eğer metot sanal olarak bildirilmişse, derleyici derleme aşamasında ürettiği kod ile çalışma zamanında referansın türüne göre ilgili sınıfın
             * devre dışı bırakılmış metodunu çağırır.
             * 3-) Hangi metodun çağırılacağının çalışma zamanında belirlenmesine GEÇ BAĞLAMA - LATE BINDING denir.
             * 4-) Sanal metot bildirmek için "virtual" anahtar sözcüğü kullanılır.
             * 5-) Türeyen sınıfta, temel sınıftaki sanal metodu devre dışı bırakmak için "override" anahtar sözcüğü kullanılır.
             * 6-) Türeyen sınıfta devre dışı bırakılan metotların ismi, temel sınıfta sanal metot olarak işaretlenmiş metotların isimleriyle aynı olmalıdır.
             * 7-) Türeyen sınıfta devre dışı bırakılan metotların parametrik yapısı temel sınıftaki sanal metodun parametrik yapısı ile aynı olmalıdır.
             * 8-) STATİK METOTLAR SANAL OLARAK BİLDİRİLEMEZ!
             * 9-) Türeyen sınıflar, temel sınıftaki sanal metotları devre dışı bırakmak zorunda değildir. Bu durumda temel sınıf referansları üzerinden
             * temel sınıfa ait metot çağrılır.
             */

            #endregion

            Console.ReadLine();
        }

        public static void AlanBul(Sekil sekil)
        {
            Console.WriteLine("Şeklin alanı = " + sekil.Alan());
        }
    }
}
