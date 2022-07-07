using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D04.TurDonusumIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BİLİNÇLİ TÜR DÖNÜŞÜMÜ

            byte firstNumber = 100;

            // Bilindiği üzere "byte" değişken tipinin belirli bir değer aralığı vardı.

            byte byteMin = byte.MinValue;
            byte byteMax = byte.MaxValue;

            Console.WriteLine($"Minimum Byte Value : {byteMin}");   // 0
            Console.WriteLine($"Maximum Byte Vakue : {byteMax}");   // 255

            // Belirtilen aralıkların dışında bir byte tipli değişken oluşturamayız.

            int secondNumber = 256;

            // Integer tipinin veri aralığını görelim.

            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            Console.WriteLine($"Minimum Integer Value : {intMin}"); // -2147483648
            Console.WriteLine($"Maximum Integer Vakue : {intMax}"); // 2147483647

            // Byte tipindeki değişkene ait değeri Integer tipindeki değişkene atayabiliriz.
            // Çünkü Integer veri tipinin değer aralığı Byte veri tipinin değer aralığını kapsar.
            // Aşağıda gerçekleştirdiğimiz tür dönüşümü "BİLİNÇLİ TÜR DÖNÜŞÜMÜDÜR"
            int thirdNumber = firstNumber;


            // BİLİNÇSİZ TÜR DÖNÜŞÜMÜ

            // Yukarıda da gördüğümüz gibi Integer veri tipinin değer aralığı -2147483648 ile 2147483647'dir.
            int number1 = 100;

            // Byte veri tipinin değer aralığı ise 0 ile 255'ti.
            // Aşağıdaki işlem ile aslında derleyiciye kefil oluyoruz. Yani diyoruz ki Integer veri tipindeki number1 değişkeni 
            // içerisindeki değer Byte veri tipi değer aralığı içindedir, bana güvenebilirsin. Bu noktadan sonra derleyici,
            // number2 değişkeninin number1 değişkeni içerisindeki değeri kaldırabileceğini düşünür. Bu şekilde gerçekleştirilen
            // tür dönüştürme işlemine "BİLİNÇSİZ TÜR DÖNÜŞÜMÜ" denir.
            byte number2 = (byte)number1;

            Console.ReadLine();
        }
    }
}
