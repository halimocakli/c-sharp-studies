using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D01.DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prototip-> veriTipi degiskenAdi = deger;

            // String tipinde bir değişken üzerinde çalışalım
            string name;
            name = "Halim Can Ocaklı";

            Console.Write("User Name: ");
            Console.WriteLine(name);

            // Int tipinde bir değişken üzerinde çalışalım.
            int number = 0;

            number = int.MinValue;
            Console.Write("The Maximum Value: ");
            Console.WriteLine(number);

            number = int.MaxValue;
            Console.Write("The Minimum Value: ");
            Console.WriteLine(number);

            // Aşağıda bazı String metotları incelenmektedir.
            name = "halim can ocaklı";

            string upperCharacter = name.ToUpper();
            string lowerCharacter = name.ToLower();
            string subString = name.Substring(2, 4);

            Console.WriteLine(upperCharacter);
            Console.WriteLine(lowerCharacter);
            Console.WriteLine(subString);

            // Char değişken tipini inceleyelim.
            // Örnek => User Choice = A;
            // Tek bir karakter saklamak istediğimizde String ya da Char veri tipini kullanabiliriz.
            // Ancak tek bir karakteri saklarken, efektif kaynak kullanımı bakımından Char veri tipi daha mantıklı bir seçimdir.

            string userChoiceString = "A";
            char userCoiceChar = 'A';

            Console.WriteLine(userChoiceString);
            Console.WriteLine(userCoiceChar);

            // Tam sayı değişken tiplerini inceleyelim.

            // BYTE
            // Byte değişkeni 0 ile 255 arasında olan tam sayıları tutabilir. Sabit aralık dışında değer verilemez.
            // 8 bit alan kapladığından dolayı daha büyük rakamlara ihtiyaç olmayacak alanlar için kullanılabilir.
            byte byteValue = 10;

            // Byte veri tipinde oluşturulabilecek minimim ve maksimum değeri görelim.
            byte minByteValue = byte.MinValue;
            byte maxByteValue = byte.MaxValue;

            Console.WriteLine($"Minimum Byte Value : {minByteValue}");
            Console.WriteLine($"Maximum Byte Value : {maxByteValue}");

            // INTEGER
            // Integer veri tiplerini rakamsal ifadeler için kullanırız.Ondalıklı veya kesirli sayıları kabul etmez
            // ve yalnızca tam sayı değeri girmeniz gerekmektedir.  -2.147.483.648  ile +2.147.483.647 arasında değer almaktadır.
            // Bellek üzerinde kapladığı alan “4 Bayt” dır.
            int intValue = 100;

            // Int tipi ile oluşturulabilecek minimum ve maksimum değerleri görelim.
            int minIntValue = int.MinValue;
            int maxIntValue = int.MaxValue;

            Console.WriteLine($"Minimum Integer Value : {minIntValue}");
            Console.WriteLine($"Maximum Integer Value : {maxIntValue}");

            // Ondalıklı sayıları saklayabileceğimiz değişken tiplerini inceleyelim.

            // DOUBLE
            // Özel veya aksi bir durum belirtmediğiniz sürece, C# üzerinde tanımladığınız her kesirli sayı birer ‘Double’ veri
            // tipi olarak algılanır. ‘Double’ olarak tanımladığınız veri tiplerinin sonuna “D” veya küçük “d” koyabilirsiniz.
            // Fakat bu zorunlu bir kural değildir! Veri tipinin ‘double’ olduğunu belirtmek için bu yol kullanılır.
            // Bellekte 8 Bayt yer kaplar ve alacağı maksimum basamak sayısı 16‘dır.
            // Double veri tipinin barındırabileceği boyut Integer veri tipinden büyük olduğu için içerisinde Integer 
            // veri tipinde bir değer saklayabilir.

            double doubleValue0 = 10.2D;
            double doubleValue1 = 11.2d;
            double doubleValue2 = 10;

            // Double veri tipi ile oluşturulabilecek minimum ve maksimum değerleri görelim.
            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            Console.WriteLine($"Minimum Value of Double Data Type : {doubleMinValue}");
            Console.WriteLine($"Maximum Value of Double Data Type : {doubleMaxValue}");

            // DECIMAL
            // Ondalıklı veri tiplerinin en büyüğü ve bellekte en çok yer kaplayandır. Mantığında double ve float gibi kesirli
            // sayıları barındırmak için kullanılır fakat asıl kullanım alanları finans sektörü ve parasal değer hesaplamalarıdır.
            // Bunun sebebi ise ‘decimal’ veri tipi kesin sonuçlar elde etmek istediğiniz kullanılır. Float ve Double veri tiplerinde
            // ondalıklı sayılar ile işlem yaparken yazdığının veri tipinin son hanesi “5” den küçükse bunu ekrana yazdırmaz ama
            // decimal’de bu durum söz konusu değildir. Veriyi net ve tam olarak hesaplar herhangi bir yuvarlama işlemi yapmaz.
            // Bu nedenle parasal hesaplamalar yaparken her daim decimal kullanılır! Bellekte 16 Bayt yer kaplar ve 29 haneye kadar
            // destekler. Ayrıca Decimal veri tipinde bir değer tanımlarken değerin sonuna 'M' koymak zorunludur.

            decimal decimalValue = 10.2M;

            // Decimal veri tipi ile oluşturulabilecek minimum ve maksimum değerleri görelim
            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            Console.WriteLine($"Minimum Value of Decimal Data Type : {decimalMinValue}");
            Console.WriteLine($"Maximum Value of Decimal Data Type : {decimalMaxValue}");

            // FLOAT
            // Kullanım ve yapı bakımından ‘double’ veri tipi ile aynı özellikleri sahiptir. Aralarında ki tek fark ise ‘float’,
            // 7 haneli sayılara kadar izin verir ve bellekte kapladığı alan ‘double’ veri tipinin yarısı kadar yani 4 Bayt‘dır.
            // Float olarak tanımlanan bir veri tipinin sonuna “F” veya “f” harfini koymanız gerekmektedir.

            float floatValue0 = 10.2F;
            float floatValue1 = 11.5f;

            // Float veri tipi ile oluşturulabilecek minimum ve maksimum değerleri görelim

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;

            Console.WriteLine($"Minimum Value of Float Data Type : {floatMinValue}");
            Console.WriteLine($"Maximum Value of Float Data Type : {floatMaxValue}");

            // MANTIKSAL VERİ TİPİ - BOOL
            // “Doğru” ve “Yanlış” olmak üzere iki değer alan veri tipidir.  Uygulama içerisinde true(doğru) ve false(yanlış)
            // değer ataması yapılmaktadır. Kontrol işlemlerinde sıklıkla kullanılmaktadır. Başlangıçta default olarak false
            // değeri atanır.

            bool userResult0 = true;
            userResult0 = false;

            bool userResult1;
            userResult1 = true;

            // ZAMANSAL DEĞİŞKEN TİPİ
            // DateTime tarih/saat bilgisini içinde tutan bir değişken tipi olarakta kullanılır ama asıl kullanım alanı tarih/saat
            // bilgisinin çekilmesi ve tarih/saat bilgisi üzerinde değişlikler yapılmasıdır. Web ve Masaüstü programlarımız da genelde
            // tarih bilgisini tutarız ve bu tarih bilgisini DateTime üzerinde çekip DateTime ile oluşturduğumuz değişkenin içine atarız.

            DateTime dateAndTime = DateTime.Now;
            Console.WriteLine(dateAndTime);

            Console.ReadLine();
        }
    }
}
