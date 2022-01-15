using System;   // Bir kütüphane dosyasını uygulama içerisine ekliyoruz
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D1.MetotGenelTanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TEORİ

            /*
             * Programın herhangi bir yerinde kullanılmak ve belirli bir işi yerine getirmek amacıyla tasarlanmış alt programlara metot denir. Metotlar tek başlarına çalıştırılabilen
             * yapılar değildir. Ancak metot, metodu çağıran ana programı destekleyerek fayda sağlar. Metot tekrar çağrılana kadar hiçbir iş yapmadan bekler. Metotlar, çağıran
             * fonksiyon tarafından birtakım bilgiler alır, alınan bu bilgiler çeşitli işlemlerden geçirildikten sonra metodu çağıran fonksiyona yeni bir bilgi gönderilir. Tabii
             * bu her zaman böyle olayabilir, metodun önceden belirlenmiş bir işi vardır, iş yapması için herhangi bir bilgiye ihtiyaç duymayabilir ve iş yaptıktan sonra da kendisini
             * çağıran fonksiyona herhangi bir bilgi iletmeyebilir. Bu durumda metodun çalışması için kendisini uyarmak yeterli olabilir. Metodun iş yapması için kendisini çağıran
             * metottan aldığı bilgilere parametre ya da metot argümanları, kendisini çağıran fonksiyona döndürdüğü bilgiye ise metodun geri dönüş değeri denir. 
             */

            // Kendini tekrar eden ya da sürekli ihtiyaç duyulan ya da operasyonel kodlarımızı, metotlar içerisine yazarak kullanım kolaylığı sağlayabiliriz.
            // .Net Framework içerisinde kullandığımz her komut bir kütüphaneden gelmekte.
            // Örneğin Console.WriteLine() metodunu çağırırken aslında "System" kütüphanesi içerisinde bulunan "Console" Class'ının içerisindeki "WriteLine" metodunu çağırmaktayız.
            // Yani metotlarımız sınıflar içerisinde barınır.
            // Eğer "using System" yazarak kütüphaneyi eklemezsek her komutumuzda sınıfların başına kütüphane ismini de eklememiz gerekir.
            // Bunu anlatabilmnek için "System" kütüpanemizi yorum satırına alalım. Ardında uzun uzadıya metodumuzu yazalım.

            // Kütüphane yokken metot kullanımı => System.Console.WriteLine("Merhaba");
            // Kütüphane varken metot kullanımı => Console.WriteLine("Merhaba");

            // Konsol uygulamalarında default olarak gelen kütüphane System kütüphanesidir.
            // Diğer kütüphaneler de .Net platformu geliştikçe eklenen ve farklı işlevlere sahip kütüphanelerdir.

            // namespace bir kütüphaneye denktir. Başka uygulamalarda namespace'imizi bir kütüphane olarak kullanabiliriz.
            // namespace'i bir boşluk ya da bir alan olarak düşünebiliriz. Bu alanın içerisinde çeşitli uygulamalarda kullanacağımız katmanlarımız yani sınıflarımız olacak.
            // Class'ları küçük paketler olarak adlandırabiliriz. namespace'lerin içinde sınıflar olduğu gibi sınıfların içinde de metotlar vardır.

            // Her metot kendisi için yazılan işi yapar.
            // Peki Main metodu ne işe yarar? Konsol uygulamaları ve form uygulamaları, program başlangıcı olarak Main metodunu tanır.

            // C#'ta bildirilen bütün metotlar mutlaka bir sınıfın içinde olmalıdır. Bir sınıfın üyesi olmayan metotlar bildirilemez.

            /*
             * C#, %100 nesne yönelimli bir programlama dili olduğu için her şeye nesneler üzerinden erişilir. Bir metot kullanılacaksa metodun içinde bulunduğu sınıf türünden
             * bir nesne tanımlanır ve "." operatörü ile metot çağrılır. Ancak "static" olarak tanımlanan metotları çağırmak için nesne tanımlamaya gerek yoktur. Eğer metot,
             * içinde olduğu sınıfın içinden çağırılacaksa metodun sadece adı yazılarak çalıştırılabilir(fonksiyonlarda olduğu gibi); sınıfın dışından çağırılacaksa
             * "SınıfAdi.Metot();
             */

            #endregion

            #region METOT ÖZELLİKLERİ

            /*
             * 1-) Metotlara isim verirken değişken isimlendirme kurallarına uymalıyız. Ancak Main() önceden tanımlanmış bir metot olduğu için Main isimli bir metot tanımlayamayız.
             * 2-) Metotları çağırırken parametreleri eksiksiz girmeliyiz. Eksik parametreleri metot çağrıları geçersizdir.
             * 3-) Metotların geri dönüş değerleri herhangi bir türden olabilir. Geri dönüş değeri olmayan metotlar ise "void" anahtar sözcüğü ile bildirilmelidir.
             * 4-) Metotların geri dönüş değerini uyumlu türden bir nesneye atmak gerekir. Örneğin geri dönüş değeri double türünden olan bir fonksiyonun çağrım ifadesini
             * int türünden bir nesneye açıkça bir tür dönüşümü yapmadan atayamayız. Gizlice tür dönüşümü yapılan türler arasında ise bu sorun yaşanmaz.
             * 5-) Geri dönüş değeri olmayan(void) metotlarda return anahtar sözcüğünü bir ifade ile kullanmak yasaktır. Geri dönüş değeri olmayan metot çağırımlarını
             * herhangi bir nesneye atamak mümkün değildir.
             * 6-) Geri dönüş değerinde yapılan gizli tür dönüşümleri ve tür uyumsuzluk kuralı metot parametreleri için de geçerlidir.
             * 7-) Bir metodun geri dönüş değeri olmayabileceği gibi parametresi de olmayabilir. Parametresi olmayan metotların parametre parantezi boş bırakılır.
             * 8-) Bir metot içerisinde başka bir metot bildirlemez ancak local fonksiyonlar kullanılabilir.
             * 9-) C/C++ dillerinde geri dönüş değeri belirtilmeyen fonksiyonların geri dönüş değeri varsayılan olarak Integer türünden kabul edilir. C#'ta bir metodun
             * geri dönüş değeri mutlaka belirtilmelidir. Geri dönüş değeri herhangi bir veri türü ya da void olabilir.
             * 10-) Metotların içinde tanımlanan değişkenler metodun dışında geçersizdir.
             * 11-) Metot parametre parantezindeki değişkenlerin türlerinin tek tek belirtilmesi gereklidir. "," operatörü ile ortak tür bildirimi yapılamaz.
             * 12-) Metot parametrelerinin, metot gövdesinde yeniden tanımlanması geçerli değildir.
             * 13-) Metotlar içinde tanımlanan değişkenler programın başından sonuna kadar durmaz. Bu değişkenler programın akışı metoda geldiğinde tanımlanır. Metodun işlevi
             * bittiğinde ise bellekten silinir. Programın akışı tekrar metoda geldiğinde değişkenler yeniden tanımlanır ve sonunda yine bellekten silinir. Bu tür değişkenlere
             * "otomatik ömürlü nesneler" denir.
             */

            #endregion

            // Aşağıda hazırladığımız metodu çağıralım.
            Selamla();
            Console.WriteLine();

            // !!! Debug işlemi yaparken metotlarda F10 tuşunu kullanırsak direkt olarak metdou çalıştırır !!!
            // !!! Debug işlemi yaparken metotlarda F11 tuşunu kullanırsak pointerımız metodun içine girer ve metodun içindeki işlemleri kontrol eder !!!

            // Şimdi metotlar kısmını daha iyi anlayabilmek için uygulamamıza yeni bir sınıf ekleyeceğiz ve bu sınıfın içerisinde metot uygulamaları yapacağız.
            // "Ogrenci" Class'ımızı oluşturduk

            Ogrenci O1 = new Ogrenci(); // Nesne oluşturduk
            O1.selamlaOgrenci();
            Console.WriteLine();

            Ogrenci O2 = new Ogrenci();
            Console.WriteLine("public erişim belirleyicisine sahip OgrenciMetot1() adlı metot çağırılıyor...");
            O2.OgrenciMetot1("Halim Can", "Ocaklı");
            Console.WriteLine();

            // O2.OgrenciMetot2(); metodunu içinde bulunduğu class dışında bir classtan çağırmaya çalıştığımızda uyarı alırız.
            // Bu uyarıyı Tool Type kutucu içerisinde "Cannot access private method 'OgrenciMetot2'" here şeklinde görüntüleyebiliriz.
            Ogrenci O3 = new Ogrenci();
            Console.WriteLine("public erişim belirleyicisine sahip OgrenciMetot3() adlı metot çağırılıyor...");
            Console.WriteLine("Bu metot içerisinde bulunan private erişim belirleyicili OgrenciMetot2() metodu da dolaylı olarak çalıştırılmış oluyor...");
            O3.OgrenciMetot3("Halim Can", "Ocaklı");
            Console.WriteLine();

            Console.ReadLine();
        }

        static void Selamla()
        {
            // void, çalışan metottan geriye herhangi bir değerin dönmeyeceğini belirtir.
            // Metodumuzun aldığı herhangi bir parametre yoktur. Sadece aşağıdaki işi yapar.
            Console.WriteLine("Merhaba");
        }
    }
}
