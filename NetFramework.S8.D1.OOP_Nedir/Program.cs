using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S08.D1.OOP_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Giriş

            /*
             * Nesne yönelim tekniği gerçek hayatı programlar için simüle edecek yöntemler topluluğudur. Her nesnenin kendine has özellikleri vardır.
             * Nesneler birbirlerinden tamamen soyurlaştırılarak farklılaştırılır. Tabi her nesnenin birbirine mesaj gönderebilmesi de son derece doğaldır.
             * Bu gerçek yaşamda da böyledir. OOP tekniğinde gerçek bir sistem parçalara ayrılır ve bu parçalar arasında ilişkiler kurulur. Her bir parça
             * hiyerarşik yapıda olabileceği gibi, parçalar birbirinden tamamen bağımsız da olabilir. Birbirinden bağımsız olan parçalar çeşitli yöntemlerle
             * aralarında haberleşirler, bazen de büyük parçayı önceden tanımlanmış diğer küçük parçalar oluşturur. Burada önemli olan her parçayı etkili
             * bir şekilde tasarlamaktır. Bu parçalardan kastımız daha önce anlatılan sınıf nesnelerinden başka bir şey değildir. Şimdi gelin nesne yönelimli
             * programlama kavramlarını kısaca açıklayalım.
             *
             * 1-) OOP tekniğinin en küçük yapı taşı nesnelerdir (objects). Nesneler, yapılarında veriler bulundururlar. Ayrıca bu nesneler arasında belirli
             * ilişkiler sağlayan fonksiyonlar vardır. Nesnelerin verileri barındırması ve fonksiyonlarla ilişkilendirmesi durumuna SARMALAMA - ENCAPSULATION
             * denir.
             *
             * 2-) Nesne içerisindeki veriler ve fonksiyonlar nesnenin dışarıya nasıl bir hizmet verdiğini belirler. Ancak bu hizmetin ne şekilde verildiği
             * belli değildir. Nesnenin servislerinden faydalanabilmek için nesnenin dış dünyaya sunduğu arayüzü bilmemiz yeterlidir. Nesne yönelimli teknik
             * jargonunda buna BİLGİ SAKLAMA - INFORMATION HIDING denir.
             *
             * 3-) Nesneler birbirlerinden bağımsız olmalarına rağmen aralarında mesajlaşabilirler. Hangi nesnenin hangi nesneye mesaj göndereceği derleme
             * aşamasında belli olmayabilir. Bu durumda nesne yönelimli programlama tekniğinin diğer bir önemli özelliği olan GEÇ BAĞLAMA - LATE BINDING
             * devreye girer.
             *
             * 4-) Derleme zamanında hangi nesnelerin hangi fonksiyonlarının kullanılacağı belli olmayabilir. Ayrıca nesneler arası mesajlaşmanın hangi nesneler
             * arasında olacağı da derleme zamanında belli olmayabilir. Bu durumda nesne yönelimli programla tekniğinin çalışma zamanında bağlama mekanizmasından
             * faydalanılır (LATE BINDING)
             *
             * 5-) Tüm nesneler birer sınıf örneğidir. Sınıflar nesnenin özelliklerini belirler. Nesneler çalışma zamanında oluşturulabileceği gibii derleme
             * zamanında da oluşturulabilir.
             *
             * 6-) Kalıtım yolu ile sınıflar birbirlerinden türetilebilir. Bir sınıf diğer bir sınıftan türediği zaman, türediği sınıfın bütün özelliklerini
             * içerir. Bunun yanında kendine has özellikler de barındırabilir. Nesne yönelimli programlama tekniğinin en önemli kavramı kalıtım yolu ile
             * türetmedir. Kalıtım yolu ile türetilmiş sınıflar ile hiyerarşik bir sınıf organizasyonu gerçekleştirebiliriz. Bunun en güzel örneği .Net
             * sınıf kütüphanesidir.
             *
             * 7-) Nesne yönelimli programlama tekniğinde nesneler çok biçimli olabilir. ÇOK BİÇİMLİLİK - POLYMORPHISM kavramı da türetme ile yakından alakalıdır
             * ve oldukça önemli bir kavramdır. Anlamı, bir nesnenin farklı şekillerde davranabilmesidir.
             */

            #endregion

            #region Tanım - Kullanım

            // Musteri nesnesini sistem bir sınıf olarak tanıyacaktır.
            // Biz bu sınıfa M1 nesnesiyle ulaşacağız. Bu şekilde ulaşabilmek için aşağıdaki gibi örnekleme yapmamız gerekir.
            // new anahtar sözcüğünü kullanarak sistemde M1 nesnesinin bir örneğini oluşturabiliriz.
            // Bu örneklemeden sonra artık bizim sistemimizde bir adet müşterimiz var : M1

            // Peki bir nesneyi oluştururken nesne elemanlarına  sistem tarafından default değer atanması yerine kendimiz değer atamak istediğimizde ne yapabiliriz?
            // new Musteri() ifadesindeki parantezler, oluşturulacak müşteri nesnesini default değerlerle oluşturulması manasına gelir.
            // Bu duruma yapıcı metotlarla müdahale ederek istediğimiz ilk değer atmasını yapabiliriz.
            // Musteri.cs dosyasından işlemlerin nasıl yapıldığını inceleyebiliriz.

            // Musteri.cs dosyasında yapıcı metot kullanarak Musteri() metodunu ezdik. Debug esnasında F11 basarak inceleyebiliriz.
            // Aşağıdaki örneklemeyi gerçekleştirdiğimizde Musteri() metodunun overloadlarını derleyici bize gösterir.
            // Hiç parametre göndermezsek Musteri sınıfı içerisindeki ilk yapıcı metot sayesinde derleyicinin verdiği default değerler fieldlara verilir.

            Musteri M1 = new Musteri();
            M1.TCkimlikNo = "12254401352";
            M1.isim = "Halim Can";
            M1.soyIsim = "Ocaklı";
            M1.cinsiyet = 717770001;    // Bay

            // Tanımladığımız nesne bellek üzerinde nasıl davranır? Şöyle ki;
            // M1 nesnesi önce Stack dediğimiz bellek bölgesinde bir isim/pointer/nokta olarak oluşturulur.
            // Ardından "new Musteri()" ifadesi kullanılır ve Musteri sınıfı, içinde var olan tüm yapılarla berarber Heap denen bellek bölgesinde açılır.
            // Sonuç olarak Musteri M1 = new Musteri(); deyimi ile adı M1 olan bir nesne oluşturulur ve bu M1 nesnesi Musteri sınıfının elemanlarını işaret eder.
            // Bu işlemin ardından Debug yapıp M1 nesnesi üzerine geldiğimizde görürüz ki Musteri sınıfının tüm "field"ları default değerleriyle M1 tarafından işaret ediliyor.
            // Kısacası Musteri sınıfı Heap bölgesinde durur ve bu sınıfa ulaşmak için Stack bölgesinde bulunan M1 nesnesini kullanırız.
            // C/C++ Pointer mantığını aklınıza getirebilirsiniz.
            // Peki başka bir pointer/nesne de Heap bölgesinde açılmış olan Musteri sınıfını gösterebilir mi? Deneyelim;

            Musteri M2 = M1;

            //M1 neyi işaret ediyorsa M2'de aynı şeyi işaret edecek.
            // Buna göre M1 ya da M2 pointerları/nesneleri üzerinden Musteri sınıfı üzerindeki değerlerden birini değiştirirsek, değerler her ikisi için değişecektir.
            // Bunun sebebi iki nesnenin de aynı noktayı işaret etmesidir.

            M2.isim = "Murat";

            // Yukarıdaki işlem sonucunda M2 nesnesinin "isim" değişkeni üzerinde yaptığı güncellemeden sonra M1 nesnesi üzerindeki "isim" değişkeni de güncellenir.

            M1.TCkimlikNo = "48937895324";

            // Yukarıdaki işlem sonucunda M1 nesnesinin "TCkimlikNo" değişkeni üzerinde yaptığı güncellemeden sonra M2 nesnesi üzerindeki "TCkimlikNo" değişkeni de güncellenir.
            // Bu durumu referans tipli davranıştan biliyoruz.

            // Peki tüm bu verilerle işimiz bittiğinde verileri "Heap" belleğinden nasıl sileceğiz? (Heap kalıcı bellek olduğu için üzerinde durduk)
            // C/C++ dillerinde Garbage Collection dediğimiz sisteme benzer bir sistem C# dilinde mevcuttur.
            // .Net Frameworkte bulunan Garbage Collector, bellekten düşen ve atıl kalan nesneleri siler.
            // Aşağıdaki işlemler ile M1 ve M2 nesneleri artık Heap belleğinde bulunan Musteri sınıfının fieldlarını işaret etmez.
            // Heap belleğinde atıl kalan değerler dispose edilmek üzere Garbage Collector'a gönderilir ve silinir.
            // Dolayısıyla anlamalıyız ki Heap bölgesindeki datayı koruyabilmemiz için o datayı işaret eden pointerın o datayı sürekli işaret etmesi gerekir.

            M2 = null;
            M1 = null;

            // Datalar ramden düştü.

            // Aşağıdaki şilme sonucunda "Sytem.NullReferenceException" hatası alırız.
            // Bu hata M2.isim ifadesinden kaynaklanır çünkü M2 artık bir nesneyi işaret etmemektedir.
            // Nesneyi, örnekleme işlemi yapmadan önce kullanmaya çalıştığımızda da aynı hatayı alabiliriz.

            // string isim = M2.isim;  // Kontrol işlemi => Hata alacağız

            // Yeni işlemlerimiz için tekrar aşağıdaki fieldlar ile çalışmaya başlayalım
            M1.TCkimlikNo = "12254401352";
            M1.isim = "Halim Can";
            M1.soyIsim = "Ocaklı";
            M1.cinsiyet = 717770001;

            // Müşterinin TC Kimlik numarası kontrol edilir ve daha önce kayıt edilip edilmediği bilgisi sorgulanır.
            bool musteriKontrol = M1.MusteriKontrol();

            #endregion

            #region Ödev

            //Araç Sınıfı İnceleme

            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyati = 28000;
            A1.SatisFiyati = 32000;
            A1.MaxIndirimTutari = 1500;
            // A1.Fiyat => Kapsülleme konusu......
            A1.FiyatBelirle(31000);
            A1.BilgileriGoruntule();

            #endregion
        }
    }

    // Solutions klasörü üzerinde class dosyası açabileceğimiz gibi namespace'te de class tanımlayabiliriz
    /*
     * class Musteri
     * {
     *
     * }
     */
}
