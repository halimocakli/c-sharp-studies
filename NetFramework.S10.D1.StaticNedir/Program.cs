using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Static metotlar gerçek hayatta nerelerde kullanılır?
             *
             * - Nesne örneğinin alınmasını istemediğimiz farklı metotları, parça parça ve birarada tutabileceğimiz ve kullanabileceğimiz projelerde yardımcı metot olarak kullanılır.
             * - Dağınık yapıda olan ve belli amaçlara hizmet eden küçük metotlarımızı static metot altında tutarız. Bir paket gibi düşünün.
             * - Oluşturulan herhangi bir nesnenin kendine özel ve farklı classlara bağımlı metotlarını (Proje içerisinde özel olduğu için) static metot olarak kullanırız.
             * - Class içerisinde bir static field tanımı yapar ilgili field içerisine bir değer ataması yaparız. Daha sonra uygulama içerisinde N kadar farklı yerde oluşturmuş
             * olduğumuz static field'ımıza ulaşıp değerimizi okuruz. Bir field'ın değerini değiştirme ihtiyacı duyarsak, static field olduğu için tek seferde field'ımızın  proje içerisinde
             * kullanıldığı tüm noktalardaki değerini değiştirebiliriz.
             * - [ Uygulama ] => [ ozelHelper ] => [ DLL ]
            */

            // Static : Nesne örneği almadan yani obje yaratmadan direkt olarak sınıf üzerinden ulaşabildiğimiz metot, field, sınıf elemanları
            // Static elemanlar bir sınıfın global düzeydeki elemanlarıdır. Yani static üyeleri kullanmak için herhangi bir nesne tanımlamamıza gerek yoktur.
            // Örnek olarak;
            Ogrenci.Test2();
            // Gördüğünüz üzere Test2 static metodunu kullanabilmek için herhangi bir nesne tanımlamadık.
            // Programı başlattığımız anda static olan bir yapıcı metot çalıştı ve class içerisinde tanımlı olan,
            // static field, static metot gibi bütün static sınıf elemanları, "Static" dediğimiz bellek bölgesinde oluşturuldu.
            // Kısacası tanımlandığı sınıf üzerinden static metodumuza ulaşabiliriz.
            // Static metotlar static olmayan metorlar içerisinden çağrılabilir.
            // Tersi durum geçerli değildir. Çünkü Static olmayan metotların örneklenmesi gereklidir.

            // "Stack" bölge içerisinde pointer'ımızı oluşturalım.
            Ogrenci O1;
            // Stack bölgede pointer oluşturduk.

            O1 = new Ogrenci();
            // Yukarıda yaptığımız örnekleme işlemi sonucunda static olmayan sınıf elemanları "Heap" bellek bölgesinde oluşturuldu
            // ve daha önce Stack bölgede oluşturulan O1 nesnesi/pointer'ı bu elemanları işaret etmeye başladı.

            O1.Test1();
            // Test 1 metodumuz static olmadığı için onu kullanabilmek amacıyla Ogrenci sınıfına bağlı O1 nesnesini oluşturmak zorunda kaldık.
        }
    }
}
