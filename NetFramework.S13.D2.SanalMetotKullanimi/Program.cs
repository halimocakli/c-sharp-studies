using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Urun U1 = new Urun();
            //U1.EkranaYaz("Urun nesnesi içerisinden EkranaYaz() metodu çağırıldı.");

            //BaseClass B1 = new BaseClass();
            //B1.EkranaYaz("BaseClass nesnesi içerisinden EkranaYaz() metodu çağırıldı.");

            /*
             * Yukarıda Kalıtım işleminin standart davranışını yeniden gördük.
             * Amacımız, BaseClass içerisinde tanımlı EkranaYaz() metodu üzerinde modifikasyon yapmadığımız sürece metodun, BaseClass üzerinden çalışması ve eğer
             * Urun sınıfı içerisinde EkranaYaz() metodu üzerinde modifikasyon yaparsak metodu çağırdığımızda BaseClass içindeki EkranaYaz() metodu yerine Urun sınıfı
             * içerisindeki EkranaYaz() metodunun çalıştırılması.
             */

            // Virtual ve Override anahtar sözcükler kullanıldıktan sonra programımız:

            Urun U1 = new Urun();
            U1.EkranaYaz("MERHABA");    // => Kalıtıldığı BaseClass nesnesinin içindeki EkranaYaz() metodu yerine kendi içindeki EkranaYaz() metodu çalıştırıldı.

            BaseClass B1 = new BaseClass();
            B1.EkranaYaz("MERHABA");    // => BaseClass olduğu ve kendi içinde Virtual Method olarak barındırdığı için BaseClass içindeki EkranaYaz() metodu çalıştı.

            // Peki Televizyon adında yeni bir sınıf üretir ve Urun nesnesinden kalıttıktan sonra EkranaYaz() metodunu çalıştırırsak hangi EkranaYaz() metodu çalışır?
            // Deneyelim:

            Televizyon T1 = new Televizyon();
            T1.EkranaYaz("Hangisi?");   // => BaseClass içerisindeki EkranaYaz() metodu çalışır çünkü Televizyon sınıfında override edilmiş bir EkranaYaz() metodu yoktur

            /*
             * Televizyon nesnesinin üzerine breakpoint ekleyip debug yaptığımızda göreceğiz ki derleyicimiz kalıtım gereği önce şu sırayla yapıcı metotlara gidecek:
             * BaseClass => Urun => Televizyon -- Yani en temel nesneden Televizyon nesnesine doğru yol aldı. Dolayısıyla uygulama bu istikamette giderken
             * Virtual ve Override olarak işaretlenmiş EkranaYaz(); metotlarını görecek ve böylece Urun nesnesi içerisinde Override olarak işaretlenen EkranaYaz()
             * metodunu çalıştıracak. Bu sebeplerden dolayı ben Televizyon nesnesi üzerinden EkranaYaz(); metodunu çağırdığımda Override olan metodum yazdırılır.
             */

            // NOT: Override ettiğimiz metot kalıtım nesneleri içerisinde Base metot olarak kabul edilir. (Virtual olarak işaretlendiği nesne dışında)

            Console.ReadLine();
        }
    }
}
