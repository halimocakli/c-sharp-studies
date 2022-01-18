using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D7.DegiskenSayidaParametreAlanMetotlar_ParamsMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Params metoduna önceki derslerde değinmiştik ancak bu kısımda daha detaylı bir şekilde anlatmaya çalışacağız. Şimdiye kadar
             * gördüğümüz metotların hepsi de belirli sayıda parametreler almaktaydı. Çünkü bir metottan beklentimizi ve metoda göndereceğimiz
             * parametrelerin sayısını önceden biliyorduk. Fakat bazen metotlara göndereceğimiz parametre sayısını önceden kestiremeyebiliriz.
             * Bu durumda C/C++ programcıları göndermek istedikleri parametreleri bir diziye yerleştirip dizinin adresini metoda gönderirler.
             * C# dilinde de buna benzer bir mekanizma vardır. Ancak benzer olan sadece mekanizmanın alt yapısıdır. Biz sanki değişken sayıda
             * parametre alan metot varmış gibi istediğimiz sayıda parametreyi bir fonksiyona gönderebiliriz. Bu parametreler metoda dinamik
             * bir dizi içinde aktarılır. Zaten metodun içinde bu parametreler ile iş yaparken gelen parametre sayısını almak için dizinin
             * boyutundan faydalanılır.
             */

            // Değişken sayıda parametre alan metotlar tanımlamak için "params" anahtar sözcüğü kullanılır.
            // "params" anahtar sözcüğü değişken sayıda eleman içerebilen bir veri yapısı tanımlar. Metoda gelen her parametre dizi elemanı olur.

            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(5));
            Console.WriteLine(Toplam(5, 10));
            Console.WriteLine(Toplam(5, 10, 15));
            Console.WriteLine(Toplam(5, 10, 15, 20));

            /*
             * Bir metot sadece değişken sayıda parametre alabildiği gibi normal sabit parametre ile beraber değişken sayıda parametre de alabilir.
             * Örneğin aşağıdaki programdaki Yaz() metodunda ilk parametre sabit olup bu ilk parametre ile diğer parametrelerin ekrana nasıl yazdırılacağı
             * belirtiliyor. Birinci parametreden sonra gelen değişken sayıdaki parametreler ise ekrana yazılacak parametreleri göstermektedir. "params" ile
             * tanımlanan dizi object türünden olduğu için her türlü nesneyi parametre olarak fonksiyona gönderebiliyoruz.
             */

            Yaz(1, "deneme", 2, 25F, 26.5);
            Yaz(0, 1, 2, 3, 'c');
            Yaz(1);

            Console.WriteLine();
            /*
             * Değişken sayıda parametre içeren metotlar, aşırı yüklenmiş metotlar olduğunda değerlendirmeye alınmaz. Örneğin aşağıdaki programda her iki metodun
             * çağrılması mümkün olmasına rağmen ikinci Oku() metodu çağrılacaktır.
             */

            Oku(0, 5);

            // Ancak eğer;

            Oku(0, 5, 10);


            // şeklinde bir çağrım yapmış olsaydık birinci Oku() fonksiyonu çağrılırdı.

            // NOT => İyi bir programcı aşırı yüklenmiş metotlara aynı görevi vermelidir. İsimleri aynı olan metotlar hemen hemen aynı görevi yapmalıdır.
            
            Console.ReadLine();
        }

        static int Toplam(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            else
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

                return sum;
            }
        }

        static void Yaz(int bicim, params object[] nesne)
        {
            if (nesne.Length == 0)
            {
                return;
            }

            if (bicim == 0)
            {
                foreach (object VARIABLE in nesne)
                {
                    Console.Write(VARIABLE.ToString() + " ");
                }
            }

            else
            {
                foreach (object VARIABLE in nesne)
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
            }
        }

        static void Oku(int a, params object[] numbers)
        {
            Console.WriteLine("Birinci Oku() metodu çalıştı");
        }

        static void Oku(int a, object b)
        {
            Console.WriteLine("İkinci Oku() metodu çalıştı");
        }
    }
}
