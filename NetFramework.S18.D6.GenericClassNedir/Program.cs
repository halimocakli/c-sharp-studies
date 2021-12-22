using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNeDegildir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic olmayan Class tanımımızı yaptık ve içini dolduduk
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.musteriIsim = "Halim Can";
            M1.musteriSoyIsim = "Ocaklı";
            M1.musteriTcKimlikNumarasi = "32154898654";
            M1.musteriNumara = "MS123";
            M1.musteriDogumTarihi = DateTime.Parse("11.12.1997");

            // Şimdi ise Generic Class oluşturalım
            /*
             * Şöyle anlatayım; biz MusteriGenericClass içerisinde bir T tipi belirledik ki bu T tipi opsiyoneldi. Gittik nesne içerisinde normalde int ya da string
             * tür olarak tanımlanmış propertylerden musteriID ve musteriNumara propertylerinin türlerini T tipi olacak şekil değiştirdik. Peki bunları nasıl kullanacağız?
             * Aşağıda olduğu gibi... MusteriGenericClass nesnemizi örneklerken sınıf kısmında tanımlı olan "MusteriGenericClass<T>" deyimini "MusteriGenericClass<int>" haline
             * getirerek nesne içerisinde T tipi olarak belirlediğimiz propertyleri artık int olarak kullanacağımızı bildirdik. Bu propertyleri nesne üzerinden kullanırken
             * beliren tooltype'leri okursak fark edeceğiz ki artık musteriID ve musteriNumara propertyleri int türünden birer property haline geldi.
             */
            MusteriGenericClass<int> MusteriGeneric1 = new MusteriGenericClass<int>();
            MusteriGeneric1.musteriID = 1;
            MusteriGeneric1.musteriNumarasiAl();
            
            // T tipini tıpkı yukarıda olduğu gibi int türünden olmakla birlikte herhangi bir türden de belirleyebiliriz.
            MusteriGenericClass<Guid> MusteriGeneric2 = new MusteriGenericClass<Guid>();
            MusteriGeneric2.musteriNumarasiAl();

            // Bazı arkadaşlarımız bir class oluşturup ilgili veri tiplerini belirlemiş olduğu generic ifadelerle donatıp bu şekilde kullanamak isteyebilir ancak bu yanlıştır.
            // Daha çok N Katmanlı mimaride kullanılır. Yani database üzerinde veri tipleri sabittir ve biz bu verileri alarak işleriz. Onların veri tiplerini kafamıza göre belirleyemeyiz.

        }
    }
}
