using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D7.Var_Object_Dynamic_Farklari
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            string y = "Merhaba";

            var z = "selam";
            var w = 10;

            /* Yukarıda "int" ve "string" türlerinde iki değişken görüyoruz. Aşağıda ise "int" ve "string" türünde olduğunu
             * görebildiğimiz iki değerin "var" türüne atandığını görüyoruz. Buradan çıkardığımız sonuca göre "var" değişken türü,
             * kendisine atanan değerin türüne dönüşür yani uyum sağlar. Yukarıda ise "var" türünün "string" ve "int" türlerine
             * dönüştüğünü görebiliyoruz.
             *
             * Peki hangi durumlarda "var" türünü kullanırız?
             *
             * Diyelim ki bir veritabanımız var. Bu veri tabanından sisteme bazı bilgileri alıp bu bilgiler üzerinde incelemeler
             * yapmak istiyoruz ancak alacağımız bilgilerin/değerlerin türünü bilmiyoruz. Bu durumda "var" türünü kullanarak bilgiler
             * üzerinde işlem yapabiliriz.
             *
             * foreach (var VARIABLE in COLLECTION)
               {
                
               }
             *
             * Yukarı "foreach" döngü yapısını görmekteyiz. Aldığımız bilgileri bu yapı üzerinden yazdıracağımızı düşünelim.
             * VARIABLE veritabanından aldığımız bilgileri/değeleri temsil ederken COLLECTION veritabanımızı temsil eder.
             * Dolayısıyla veritabanı üzerinden gelen her bilgi "var" türü olarak kabul edilir ve incelenir.
             */

            string a = z;   // Dikkat ederseniz daha önce türünü "var" olarak belirlediğim "z" değerini string türünden bir değişkene atayabildim.
            // !!! UNUTMAYIN "var" TİPLİ BİR DEĞİŞKENE İLK ATANAN DEĞERİN TİPİ NEYSE SONRASINDA DA O TİP ÜZERİNDEN MANİPÜLASYONLAR YAPILIR
            // YANİ "z" DEĞİŞKENİNE ARTIK ANCAK "string" TÜRÜNDEN DEĞERLER ATANABİLİR


            // "object" türünün "var" türünden farkı tam olarak budur. "object" türüne, tıpkı "var" türünde olduğu gibi (türü fark etmeksizin) her
            // değişkeni atayabilirim. Ancak atadığım değişkeni, kendisiyle aynı türe sahip başka bir değere atadığımda hata alırım. Bunun sebebi ise
            // "var" türü kendisine atanan değişkenin türüne dönüşürken "object" türü ise halihazırda C#'taki bütün türlerin türediği tür olduğu için
            // kendisi dışında başka türe dönüşmez. Her değer ona atanabilir ama "object" türünden bir değişken başka bir değişkene atanacaksa
            // türlerin kesin olarak bilinmesi ve bu doğrultuda Unboxing işlemi yapılması gerekir.

            object o = 5;
            object k = "Merhaba";

            // string s = k;   => Unboxing yapmadığımız için hata alacağız
            string s = (string)k;  // Unboxing işlemi yaptık ve atama işlemi başarı ile gerçekleştirildi.

            /*
             * C# tip denetimi ve güvenliği konusunda sıkı önlemler almaya çalışan bir dildir. Dolayısıyla bir değişkenin tipi atandığı diğer değişkenin tipi
             * ile uyuşmuyorsa derleme zamanında hata alırız. Ancak bazı durumlarda derleme zamanında değişken tipli tanımlamalara ihtiyaç duyabiliriz.
             * Bu doğrultuda C# 4.0 ile "dynamic" tipi üretildi. dynamic tipini bir bukalemun gibi düşünebiliriz çünkü kılıktan kılığa girer. "dynamic" tipi
             * bütün tiplere dönüşebilir.
             */

            dynamic i;
            dynamic str;

            i = 10;
            str = "Bu bir string'tir";

            Console.WriteLine("i'nin tipi: " + i.GetType());
            Console.WriteLine("i'nin değeri: " + i);

            //i'ye int tipiymiş gibi davranalım
            i = i * 10;
            Console.WriteLine("i'nin yeni değeri: " + i);

            Console.WriteLine("str'nin tipi: " + str.GetType());
            Console.WriteLine("str'nin değeri: " + str);

            //str'ye string tipiymiş gibi davranalım
            str = str.ToUpper();
            Console.WriteLine("s'nin yeni değeri: " + str);

            i = "i'nin tipi değişti";//Bu atamayla i'nin tipi otomatik olarak değişti
            Console.WriteLine("i'nin değeri: " + i);
            Console.WriteLine("i'nin yeni tipi: " + i.GetType());

            // Yukarıdaki kod bloğunu çalıştırırsak aşağıdaki çıktıyı elde ederiz

            /*
             
               i'nin tipi: System.Int32
               i'nin değeri: 10
               i'nin yeni değeri: 100
               
               str'nin tipi: System.String
               str'nin değeri: Bu bir string'tir
               str'nin yeni değeri: BU BİR STRİNG'TİR
               
               i'nin değeri: i'nin tipi değişti
               i'nin yeni tipi: System.String

             */

            /*
             * Yukarıdaki uygulamada göreceğiniz üzere "dynamic" tipi derleme zamanında istediğimiz gibi kullanabiliyoruz.
             * "i" değişkeninin tipini "dynamic" olarak belirledik, daha sonra "i" değişkenine int tipiymiş gibi manipülasyonlarda bulunduk.
             * Ardından "i" değişkenine "string" tipiymiş gibi manipülasyonlarda bulunduk ve hata almadık çünkü "i" değişkeninin tipini en başında
             * "dynamic" olarak belirledik. Bununla birlikte "str" değişkeni için de durumlar aynı. Fark ettiğiniz üzere tipini "dynamic" olarak
             * belirlediğimiz "str" değişkenine "string" tipinde bir değer atayıp "String" sınıfının metotlarını kullanabildik.
             *
             * Burada dikkat etmemiz gereken nokta şu: "dynamic" türünde tanımladığımız değişkenler üzerinde hata verecek işlemler yaparsak bu
             * hataları derleme zamanında almayız. Ancak programımızı çalıştırdığımızda "çalışma zamanında" hata alırız. Örneği aşağıda.
             *
             *
             *
               dynamic s;
               s = "karakter katarı";
               s = s * 2; // Çalışma zamanı hatası

             */


            // VAR - DYNAMIC - OBJECT ÖZETİ

            // "object" => .NET Framework içerisindeki herhangi bir tipte değişken alabilir
            // "object" => Derleyici, object değişkene atanan değişken/nesne hakkında bilgi sahibidir, yani o nesnenin standart metotlarını kullanabilir
            // "object" => Bir metoda parametre olarak gönderilebilir ya da bir metodun dönüş tipi olabilir
            // "object" => Farklı bir tip ataması yapıldığında boxing-unboxing işlemleri yapılmalıdır
            // "object" => Unboxing işlemi için ilk atama esnasında "object" tipine dönüştürülen değişkenin asıl tipini bilmek gerekir, aksi halde hata oluşur

            // "dynamic" => Herhangi bir tipte değişken olabilir, herhangi bir tipte değişkene dönüşebilir
            // "dynamic" => Derleyici, "dynamic" değişkene atanan değişken/nesne hakkında bilgi sahibidir, dolayısıyla o nesnenin standart metotlarını kullanabilir
            // "dynamic" => Bir metoda parametre olarak gönderilebilir veya metodun dönüş tipi olabilir
            // "dynamic" => Tip dönüşümü yani boxing/unboxing gerekmemektedir
            // "dynamic" => Tip dönüşümü hataları derleme zamanında anlaşılmaz ancak bir tip dönüşümü hatası varsa çalışma zamanında hata alırız

            // "var" => Herhangi bir tipte bir değişken olabilir fakat bir başlangıç değerine sahip olmalıdır.
            // "var" = Derleyici nesne hakkında bilgi sahibidir, nesne hangi tipteyse ona göre intellisense ile bilgi edinmek mümkündür.
            // "var" => Bir metoda parametre olarak geçilemez ya da bir metodun dönüş tipi olamaz.
            // "var" => Tip dönüşümü (boxing - unboxing) gerekmemektedir.
            // "var" => Tip dönüşümü derleme sırasında gerçekleşir. Hata varsa derleme yapılmaz.

            Console.ReadLine();
        }
    }
}
