using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D4.RefOutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref anahtar sözcüğü değer tipli değişkenlerin referans tipli değişkenler gibi davranmasına ve bellekte bu şekilde tutulmasına olanak sağlar.

            /*
             * ref anahtar sözcüğü metotlara parametre aktarılırken kullanılır. ref anahtar sözcüğü ile belirtilen parametreler değer tipi de olsa
             * referans olarak aktarılırlar. Genellikle değer tiplerini referans olarak metotlara geçirmeye zorlamak için kullanılır. Aslında ref
             * anahtar sözcüğü, C ve C++ dillerindeki göstericilere benzer bir kullanım sunmaktadır. C/C++ dillerindeki nesneleri adresleriyle
             * fonksiyonlara geçirip nesneleri istediğimiz zaman değiştirebiliriz.
             */

            // x değeri başına ref anahtar sözcüğünü alıp referans tipine dönüştürülmeden önce ilk değer ataması yapılmalıdır.
            int x = 10;
            DenemeRef(ref x); // Metot çağrılırken x parametresi başında ref anahtar sözcüğü kullanılmalıdır.
            Console.WriteLine(x);

            // ref anahtar sözcüğü kullanılırken ilk değer ataması yapılması zorunlu demiştik ancak out anahtar sözcüğünü kullanırken ilk değer ataması mecburi değildir.

            /*
             * out anahtar sözcüğünün kullanımı ref anahtar sözcüğünün kullanımıyla aynıdır. Tek farkı out ile tanımlanmış parametrelere
             * ilk değer verme gibi bir zorunluluğumuz yoktur. İlk değer metot içerisinde verilebilir. .Net 7.0'dan önceki versiyonlarda
             * out anahtar sözcüğü ile kullandığımız değişkene ilk değer ataması yapmak zorundaydık. Ancak bu zorunluluk .Net 7.0 sonrasında
             * ortadan kalkmıştır. Örnek olarak:
             */

            int y;
            DenemeOut(out y);
            Console.WriteLine(y);

            // Bununla birlikte metot çağrım sırasında ilgili parametreyi belirtirken çağrım esnasında da tanımlama yapılabilmektedir. Örneğin:

            bool number = int.TryParse("82", out int z); // z değişkeni metot çağrımı sırasında tanımlanmıştır
            Console.WriteLine(z);

            // ref ve out anahtar sözcükleri gerçek hayat uygulamalarında, belirli bir değerin kopyası üzerinde değil,
            // kendisi üzerinde metot vasıtasıyla değişiklik yapmak istediğimizde kullanılır.

            /*
             * C# 7.0 ile beraber artık ref anahtar sözcüğü kullanılarak, metotlardan değer yerine referans döndürülmesi ve bunların yerel değişkenlerde
             * referans olarak saklanması mümkün hale gelmiştir. ref geri dönüş değeri, Find() metodunda görüldüğü gibi bildirilmektedir.
             * Geri dönüş değeri ref olarak işaretlenen fonksiyonlardan geriye bir değer döndürüleceği zaman da yine Find() metodunda olduğu
             * gibi ref anahtar sözcüğü kullanılmalıdır.
             */

            int[] numbers = {1, 15, -39, 0, 7, 14, -12};
            ref int foundNumber = ref Find(7, numbers);
            foundNumber = 9;
            Console.WriteLine(numbers[4]);

            /*
             * Yukarıdaki örneğin Find() metodunu incelediğimiz zaman "ref numbers[i]" ifadesiyle numbers dizisinin elemanını değil, elemanın referansının
             * döndürüldüğünü görmekteyiz. "ref int foundNumber = ref Find(7, numbers);" ifadesiyle "foundNumber" değişkenine, numbers dizisinin 4. indeksindeki
             * elemanının referansı atanmaktadır. Böylece foundNumber değişkenine atanan her değer aslında dizinin 4. indeksindeki elemanın değerini değiştirecektir.
             *
             * Yukarıdaki ifade, C dilinde kullandığımız pointer yapılarını hatırlatıyor.
             *
             * "ref return" kullandığımız metotları çağırırken de ref anahtar sözcüğünü kullanarak çağırmamız gerekir. Aksi durumda(normal çağrımda olduğu gibi)
             * metot referans değeri yerine değişken değeri dönecektir.
             */

            /*
             * Metoda göndereceğimiz parametreler belirliyken herhangi bir problem yaşamaksızın işlemlerimizi gerçekleştirebilriz.
             * Fakat bazen metotlara göndereceğimiz parametre sayısını önceden kestiremeyebiliriz. Bu durumda C/C++ programcıları
             * göndermek istedikleri parametreleri bir diziye yerleştirip dizinin adresini metoda gönderirler. C# dilinde de buna
             * benzer bir mekanizma vardır. Ancak benzer olan sadece mekanizmanın alt yapısıdır. Biz sanki değişken sayıda parametre
             * alan bir metot varmış gibi istediğimiz sayıda parametreyi bir fonksiyona gönderebiliriz. Bu parametreler metoda dinamik
             * bir dizi içerisinde aktarılır. Zaten metodun içinde bu parametrelerle iş yaparken gelen parametre sayısını almak için
             * dizinin boyutundan faydalanacağız.
             */

            /*
             * Değişken sayıda parametre alan metotlar tanımlamak için "params" anahtar sözcüğü kullanılır. params anahtar sözcüğü
             * değişken sayıda eleman içerebilen bir veri yapısı tanımlar. Metoda gelen her bir parametre bu dizinin bir elemanı
             * olacak şekilde ayarlanır.
             */

            // Yani aslında biz dizi oluşturup bu diziyi parametre olarak fonksiyona göndermiyoruz. Sayıları gönderiyoruz ve onlar metotda dizi haline geliyor.
            // Örnek olarak, Toplam metodu kendisine gönderilen bütün parametrelerin toplamını geri döndürmektedir.

            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(5));
            Console.WriteLine(Toplam(5, 10));
            Console.WriteLine(Toplam(5, 10, 15));
            Console.WriteLine(Toplam(5, 10, 15, 20));

            // Gördüğünüz üzere params metodu kullanıcıya esneklik sağlar.
        }

        static void DenemeRef(ref int x)
        {
            x = 50;
        }

        static void DenemeOut(out int y)
        {
            y = 50; // Main metodu içerisinde ilk değer atanmamış yapılmamış olan değere ilk değer ataması yapılıyor.
        }

        public static ref int Find(int searchedNumber, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedNumber)
                {
                    // burada dizi elemanı değil, şartları sağlayan dizi elemanının adresi döndürülüyor
                    return ref numbers[i];
                }
            }

            throw new IndexOutOfRangeException(searchedNumber + "bulunamadı");
            // "throw" anahtar sözcüğünün kullanımına dair detaylar için Try-Catch konusunu inceleyebilirsiniz.
        }

        static int Toplam(params int[] sayilar)
        {
            // params() metodu, eğer içinde olduğu metot(burada Toplam) birden fazla parametre alıyorsa en sona yazılmalıdır.
            // Yani metot başka parametreler alacaksa o parametreler params() metodundan önce yazılmalıdır.
            if (sayilar.Length == 0)
                return 0;

            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam;
        }
    }
}