using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kalıtım Giriş

            /*
             * Kalıtım OOP tekniğinin en önemli özelliğidir. Kalıtım yolu ile nesneler birbirlerinden türetilir. Türeyen sınıflar türediği sınıfın özelliklerini
             * kalıtım yolu ile devraldığı gibi kendisi de yeni özellikler tanımlayabilir. Türetme yolu ile bir bir nesne, kendi özelliklerini yeni/türeyen nesneye aktarır.
             * İstenirse türeyen nesne kendisine has özellikler de içerebilir. Türetme ile sınıflar arasında hiyerarşik bir yapı sağlanır. Örneğin Stream sınıfı
             * bir akımın sahip olabileceği minimum özelliklere sahiptir. FileStream ve NetworkStream sınıfları ise Stream sınıfının bütün özelliklerini kalıtım yolu
             * ile aldıkları için her iki sınıfta da ortak bir takım özellikler vardır ancak her iki sınıf, kendi içinde kendi işlerine yönelik özel özellikler
             * barındırırlar. Örneğin Stream sınıfında bulunan ReadByte() metodu akımdan bir bytelık bilgi okur, aynı şekilde bu metot FileStream ve NetworkStream
             * sınıflarında da bulunur. Bu metot kalıtım yolu ile bu sınıflara geçmiştir. Ancak her akımdan bir bytelık bilgi farklı şekillerde elde edildiği için
             * her sınıf kendi içinde bu metodu yeniden yazmış olabilir. Ama bu bizim için önemli değil, önemli olan arayüzün aynı olması ve her iki durumda da
             * ilgili akımdan bir bytelık veri okunmasıdır.
             *
             * Sınıfları türetmeyi daha iyi anlamak için şu şekilde bir örnek verelim: Memeliler diye bir sınıf tasarlamış olalım. Kedi, köpek, inek gibi bütün hayvanlar
             * memeli grubuna girmektedir. Ancak her hayvanın kendisine haz özellikleri vardır. Bu hayvanları Memeli olarak tanımlayabiliyor olsak da kedi ve köpek arasındaki
             * tek benzerlik memeli olmaları olabilir. Bu durumda her hayvanı farklı bir sınıf ile ifade ederek sorunu çözebiliriz. Ancak her sınıfta memeli hayvanların
             * özelliklerini tanımlama zor olur. Bunun yerine memeli hayvanların ortak özelliklerini Memeli isimli bir sınıfta toplamalıyız. Bu sınıfta her memeli hayvanda
             * bulunması gereken özellikler tanımlanır. Diğer Kedi, Kopek gibi sınıflar ise Memeli sınıfının bir devamı olarak tasarlanır. Her özel sınıf Memeli sınıfına
             * ait özellikleri ister gizler isterse tekrar kullanır. İsterse de Memeli sınıfını özellikleri dışında kendine yeni özellikleri ekler. Gördüğünüz gibi
             * Memeli sınıfını bir kere tanımlayarak  kalıtım yolu ile diğer özelleştirilmiş sınıfları Memeli sınıfından türeterek tasarlayabiliriz. Memeli sınıfının
             * özelliklerini kalıtım yolu ile Kedi sınıfına aktarmaya "kalıtım yolu ile türetme" denilmektedir.
             */

            #endregion

            /*
             * Kalıtım -> Inheritence -> Miras Alma
             *
             * - Kalıtım yolu ile oluşturmuş olduğumuz nesnelerimiz birbirlerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir.
             * - C# programlama diline başlarken tip dönüşümlerinde tüm nesneleri tanıyan ve her türden nesneyi kabul eden "Object" tipinden bahsetmiştik.
             *
             * - Object tipi framework içerisindeki tüm nesnelerin atası bir tip olduğu için -tüm nesnener Object nesnesinden kalıtıldığı için- türetilen tip
             * kendisinden türeyen tüm tipleri tanır ve tam bir uyumluluk sağlar.
             *
             * Ogrenci O1 = new Ogrenci();
             * Yukarıdaki nesne örneği alınan Ogrenci nesnesi aslında Object tipinden türetilmiş bir nesnedir.
             */

            // Aşağıda oluşturmuş olduğumuz özel tip en temelde object türünden türer ve onun metotlarını kalıtım yolu ile alır(Equals, GetHashCode, GetType, ToString vs.)

            // Ogrenci O1 = new Ogrenci();

            // O1. -> Kutucuktan çıkan metotları inceleyin

            /*
             * - Uygulama içerisinde gördüğünüz gibi öğrenci nesnesi aslında bizim oluşturduğumuz özel bir tip ama içeride bizim ona yazmadığımız metotların olduğunu
             * ve bunların object nesnesinden kalıtılma ile geldiğibi gördük.
             *
             * - Kalıtım konusunu biz aslında yine ilişkisel veritabanı mantığında ortak değerlere sahip olan alanlarımızı nesnesel olarak modellerken kullanırız.
             *
             * - C# programlama  dilinde oluşturmuş olduğumuz tüm nesnelerimiz default olarak türetilmeye açık halde gelmektedir. İstersek oluşturmuş olduğumuz nesnelerimizin
             * türetilmesini engelleyebiliriz. Uygulamayı dış programcılara verdiğimizde yani yayımladığımızda nesnemin kullanılmasını istemem. Çünkü güvenlik problemi oluşturabilir.
             *
             * - Bu bölüm içerisinde erişim belirleyicilerinden internal erişim belirleyicisini inceleyeceğiz.
             *
             * - Uygulamalarımızın veritabanlarını oluşturacağımız zaman bazen uygulama seviyesindeki bazı ayarların kayıt bazında tutulmasının istenmesinden veya uygulamamızın
             * içerisindeki tanımların birbirinin bazı alanlarının aynı olması nedeni ile tablolar aynı kolonları içerebilirler.
             *
             * - Yazmış olduğumuz kodlarımız ise veritabanlarımızdan data alma veya data gönderme temel görevlerini yerine getirebilmek için şemasal olarak database tiplerinin modelleri
             * olarak oluşurlar.
             *
             * - OOP'de kalıtım tam bu noktada bize yardımcı olur ve sınıflarımızı tanımlarken merkezi bir mimari ile daha az ve daha merkezli kod yazmamızı sağlar.
             */

            TemelTip T1 = new TemelTip();
            T1.TemelTipMetot1();

            Egitmen E1 = new Egitmen();
            Console.WriteLine("Egitmen nesnesi örneklendi");
            E1.TemelTipMetot1();    // Egitmen nesnesi TemelTip nesnesinden türetildiği için TemelTip metotlarını kullanabilir.

            /*
             * Kalıtım söz konusu olduğunda:
             * Yukarıda Egitmen sınıfı türünden örneklediğimiz E1 nesnesini ele alalım. Nesne örnekleme işlemi yapılırken derleyici önce örneklenecek nesne sınıfına gider yani
             * Egitmen sınıfına. Ardından bu sınıf içerisinde bir yapıcı metot olup olmadığı kontrol edilir ve eğer varsa yapıcı metodun üstüne gelinir. Örneklenecek nesnemiz Egitmen
             * sınıf türünden olduğu için önce Egitmen sınıfına gittik ve yapıcı metodun üzerine geldik. Ancak bu noktada hatırlamamız gereken şey şu ki Egitmen sınıfı TemelTip sınıfından
             * mirasçı olarak kabul ediliyor. Yani TemelTip sınıfı içerisindeki tüm değerler Egitmen sınıfına miras yolu ile kalıtılıyor. O halde Egitmen sınıfı içerisinde yapıcı metot üzerinde
             * bekleyen derleyici şimdi TemelTip sınıfına giderek alması gerek mirası alacak ve tekrar geri dönüp Egitmen sınıfı içerisindeki yapıcı metodun içerisine girecek. Kısacası
             * örneklememiz gereken E1 nesnesi Egitmen sınıfı türünden olduğu için önce Egitmen sınıfına gittik ve bu sınıf içerisinde bulunan yapıcı metot üzerinde bekledik ardından
             * Egitmen sınıfı TemelTip sınıfının mirasçısı olduğu için gerekli değerleri miras almak ve eğer varsa önce TemelTip sınıfı içerisindeki yapıcı metodu çalıştırmak amacıyla
             * TemelTip sınıfı içerisine geldik. Bu kısımda işimiz bittikten sonra tekrar Mirasçı yani Egitmen sınıfına giderek yapıcı metodumuzu çalıştırdık ve örnekleme işlemimizi
             * tamamladık.
             *
             * Hatırlatıcı Not: Yapıcı metodun çalışması ile birlikte(default ya da ezilmiş fark etmez) sınıf içerisinde bulunan bütün değerler ve örneklenen nesne bellekte yerlerini alır.
             *
             * - Mirasçı => Türetilen Nesne
             * - Miras Bırakan => Türeyen Nesne
             */

            /*
             * Diyelim ki TemelTip sınıfım içerisindeki bir fieldıma default bir değer vermek istiyorum. Böylece TemelTip sınıfı üzerinden ya da TemelTip sınıfından türerilen diğer sınıflar
             * üzerinden yapılan nesne örneklemelerinden sonra default olarak değer verdiğim fieldlarımı verdiğim değerle kullanabileceğim. örnek olarak id fieldıma random bir değer atamak
             * isteyelim. Bu durumda kendimize şu soruyu sormmız gerekir: "Bu random sayı atama işlemini nerelerde yapabilirim?" hatta "Random sayı atama işlemini tam olarak nerede yapmalıyım?"
             * daha doğru bir soru. Bu işlemi iki farklı yerde yapabiliriz. İşlemi TemelTip içerisinde yapmak istediğimizi farz edelim. Eğer ben bu fieldı TemelTip içerisine eklediysem ve
             * TemelTip içerisinde değer almasını istiyorsam, id fieldına random sayı atma metodunu TemelTip sınıfı içerisinde oluşturmalıyım. Dolayısıyla TemelTip nesnesinden türeyen her yerde,
             * oluşturmuş olduğum metodu kullanabileceğim.
             *
             * Peki eğer Egitmen'e özel id'nin çalışmasını istiyorsak? Egitmen sınıfı örneklendiğinde; eğitmenler 200-300 arasında, personeller 400-500, öğrenciler 500-1000 arasında id değeri
             * alsın istiyorsak o halde metodumuzu türeyen nesne(Egitmen, Ogrenci, Personel) üzerinde oluşturma fikri akıllara gelebilir ancak doğru yöntem metodun TemelTip yani türetilen
             * nesne içerisinde oluşturulmasıdır. Oluşturmuş olduğumuz metodu Sanal Metot haline getiririz ve sanal metodumuzu istedimiz sınıfta kullanabiliriz.
             */

            // Türeyen nesneden türetilen nesne içerisinde oluşturulan nesneye erişilemez. Kalıtım tek yönlüdür. Yani bizim uygulamamızda TemelTip nesnesinden diğer nesnelerin değerlerine erişemem.

            // Özel tiplerde Boxing ve Unboxing

            // => Bizim Object nesnemiz nedir? => Bizim en temel nesnemiz nedir?
            // TemelTip bizim temel nesnemiz yani Objectimizdir.
            TemelTip T2;
            // Hangi nesnelerde TemelTip Object görevi görür? => Personel, Egitmen, Ogrenci => TemelTip nesnesinden türedikleri için TemelTip bu nesnelerde Object gibi davranır

            T2 = E1;    // Egitmen nesnemiz olan E1'i TemelTip nesnemiz olan T2'ye atadık.
            E1 = (Egitmen)T2;   // Unboxing

            Personel P1 = new Personel();
            T2 = P1;    // Personel nesnemiz olan P1'i TemelTip nesnemiz olan T2'ye atadık.
            P1 = (Personel)T2;  // Unboxing

            Ogrenci O1 = new Ogrenci();
            T2 = O1;    // Ogrenci nesnemiz olan O1'i TemelTip nesnemiz olan T2'ye atadık.
            O1 = (Ogrenci)T2;   // Unboxing

            // object O3 = T2; => Dönebileceğimiz son yer objecttir.

            // Boxing - Unboxing İşlemini Hatırlayalım
            //object O1 = E1; // Anatip(Object), kendisinden türeyen tipi(Egitmen) tanır ve kendi içerisine parametre olarak kabul eder [Boxing]
            //E1 = (Egitmen)O1; // [Unboxing]

            // Personel ve Ogrenci nesnelerine eklediğimiz yapıcı metorları ve kalıtımı inceliyoruz.
            Personel P2 = new Personel();
            P2.TemelTipMetot1();

            Ogrenci O2 = new Ogrenci();
            O2.TemelTipMetot1();
            // Tıpkı üst satırlarda da bahsettiğimiz üzere önce TemelTip nesnesinin yapıcı metodu çalıştırılır.

            // Ogrenci ve Personel nesneleri için Boxing - Unboxing işlemleri
            object Obj1 = O2;
            O2 = (Ogrenci)Obj1;

            Obj1 = P2;
            P2 = (Personel)Obj1;

            // Ben istiyorum ki türemiş olan tiplerim türeyemesin
            /*
             * object => TemelTip => Personel => X
             *                    => Ogrenci  => X
             *                    => Egitmen  => X
             *
             * Belli bir noktadan sonra kalıtımın sonlanmasını ve hiçbir nesnemin türeyememesini istiyorum. Yanni başka nesne türemiş olan nesneyi kendisine temel tip olarak alamasın.
             * O halde Ogrenci ve Egitmen nesnelerimizi bir ana tip gibi belirleyelim ve onları kalıtmaya çalışırken bunu nasıl engelleyeceğimizi görelim. Bunun için Test nesnesini oluşturduk
             * ve bu nesneyi Egitmen nesnesinden türettik. Ardından Egitmen nesnesine gittik ve "Sealed" anahtar sözcüğünü ekleyerek Egitmen nesnesinin türemesini tamamen engelledik.
             * Sealed anahtar sözcüğü ile mühürlenen nesneler artık kalıtımsal olarak örneklenemez ve en fazla başka bir nesnenin içerisinde InnerType olarak kullanılabilir.
             * Personel nesnesi için herhangi bir işlem yapmadık. Peki neden Persone nesnesini Sealed olarak işaretlemedik?
             *
             * Personel nesnesinin içerisinde bulunan "IsBaslangicTarih, IsBıtısTarih, IzinGunSayisi" fieldları Personel nesnemize özeldir. Ancak bu fieldlar Egitmen nesnesi içerisinde de
             * mevcuttur ve mevcut olan bu fieldları silerek yalnızca Personel nesnesine özel hale getirmeliyiz.(Nesne içine not edildi) Egitmen classımıza baktığımızda ise görürüz ki
             * "Brans, BransSeviye" Egitmen nesnemize özel alanlardır. Ben Egitmen nesnemi Personel nesnemden kalıtmalıyım. Personel nesnem de TemelTip nesnesinden kalıtıldığı için ben
             * hiçbir şey kaybetmeyeceğim aksine programıma daha fazla esneklik kazandırmış olacağım. Dolayısıyla Egitmen nesnem üzerinde bazı modifikasyonlar yapmalıyım. Egitmen nesnemin eski
             * hali yorum satırları ile berlirtilecektir.
             *
             * Kısacası Egitmen nesnem Personel nesnemden kalıtıldı ve Personel nesnem de TemelTip nesnemden kalıtıldı. Dolayısıyla Egitmen nesnem kendinin, Personel nesnemin ve TemelTip nesnemin
             * field ve metotlarını kullanabilir hale gelirken ayrıca Personel nesnem kendinin ve TemelTip nesnesinin field ve metotlarını kullanabilir hale geldi.
             *
             * - Gidiş Yönü -> Egitmen => Personel => TemelTip => Object
             * - Dönüş Yönü -> Object => TemelTip => Personel => Egitmen
             */

            Egitmen E4 = new Egitmen(); // Debug yaparak süreci inceleyebiliriz.

            /*
             * Public : Uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamını taşır.
             * Private : Sadece tanımlandığı Class içerisinde erişilebilir olur.
             * Protected : Normal kullanımda Private özelliklerini taşıyacak şekilde davranır. Ancak kalıtım yolu ile çağırıldığında başka bir Class içerisinde Public olarak kullanılır.
             */

            // Temel tip içerisinde protected olacak şekilde TemelTipMetot2 metodunu oluşturdum. Şimdi yukarıda bahsettiğimiz Protected davranışını inceleyelim. TemelTip nesnesi içerisinde 
            // Protected erişim belirleyicisi ile işaretlediğimiz TemelTipMetot2 metodunu oluşturduk. Bu metodu buradan çağıramıyoruz çünkü Program sınıfımız TemelTip sınıfı tarafından 
            // türetilen bir sınıf değildir ancak TemelTipMetot2 sınıfımızı Ogrenci nesnesi içerisinden çağırabiliriz çünkü Ogrenci nenesi TemelTip nesnesinden türetilmiştir. Dolayısıyla
            // Protected erişim belirleyicisiyle işaretlenen TemelTipMetot2 metodu Program sınıfı içerisinde çağırıldığında Private davranışı sergilerken Ogrenci sınıfı içerisinde çağırıldığında
            // Public davranışı sergiler. Sebebi yukarıda açıklandı.

            TemelTip T3 = new TemelTip();
            // => T3.TemelTipMetot2(); => ulaşamıyoruz

            Ogrenci O4 = new Ogrenci();
            // => O4.TemelTipMetot2(); => ulaşamıyoruz

        }
    }
}
