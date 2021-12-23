using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D6.ConvertParseFark
{
    class Program
    {
        static void Main(string[] args)
        {
            // String tipindeki bir değişkeni Integer veri tipine dönüştürürken genelde Convert.ToIn32() metodunu ve sınıfını kullanırız.
            // Ancak bu yöntem bazı durumlarda hata verecektir.
            // Metot ve sınıfımızı birlikte inceleyelim; ilk olarak dört adet değişken belirleyelim, değişkenlerin hepsi String veri tipinden değerler alsın.

            string example1 = null;
            string example2 = "123.4567";
            string example3 = "3216549876543216547985465432165496879435132468768860687687068064";
            string example4 = "1576";

            // Convert.ToInt32() => Değer null olarak geldiğinde 0 olarak geriye döndürülür, dolayısıyla metoda giren example1 değişkeni 0 olarak dönecektir.
            // example2 değişkeni Integer veri türü olacak şekilde döndürülemez çünkü değişkenin içindeki değerin formatı buna uygun değil. Bu nedenle
            // derleyiciden "FormatException" hatası alırız. example3 değişkenine baktığımızda ise içerisindeki verinin Maxvalue değerini aştığını görürüz.
            // Bu nedenle program çalıştırıldığında "OverFlowException" hatası ile karşılaşırız.

            // MaxValue => Int32 alabileceği en yüksek değer
            // MinValue => Int32 alabileceği en küçük değer

            // example4 değişkenin baktığımızda ise değişkenin Convert.Int32() formatına uygun veri içerdiğini görürüz. Bu nedenle uygulandığında veri tipi
            // Integer veri tipine sorunsuz olarak dönüştürlecektir.

            int example1ConvertRun = Convert.ToInt32(example1);    // => 0
            int example2ConvertRun = Convert.ToInt32(example2);    // => "FormatException"
            int example3ConvertRun = Convert.ToInt32(example3);    // => "OverFlowException"
            int example4ConvertRun = Convert.ToInt32(example4);

            // Int32.Parse() => Değer null olarak geldiğinde "ArgumentNullException" hatası ile karşılaşılır.
            // Eğer değer Integer değilse "FormatException" hatası ile karşılaşılır.
            // Değişken içerisindeki değer MaxValue değerini aşıyorsa veya MinValue değerinin altında kalıyorsa uygulama çalıştığında "OverFlowException" hatası alırız.

            int example1ParseRun = Int32.Parse(example1);   // => "ArgumentNullException"
            int example2ParseRun = Int32.Parse(example2);   // => "FormatException"
            int example3ParseRun = Int32.Parse(example3);   // => "OverFlowException"
            int example4ParseRun = Int32.Parse(example4);

            // Int32.TryParse() => Değişken null veya Integer olmayan bir tipte geliyor ise sıfır olarak döndürülür. MaxValue ya da MinValue belirtilmemiştir bu nedenle diğer
            // dönüştürme metotlarında karşılaştığımız hatalar yerine Int32.TryParse() kullanımda geri dönüş olarak 0 alırız. Bu sebepten dolayı diğerlerine göre daha iyi ve daha faydalıdır
            // çünkü risk daha azdır.

            int outValue1;
            int outValue2;
            int outValue3;
            int outValue4;

            bool example1TryRun = Int32.TryParse(example1, out outValue1);  // Değer Null olarak geldiği için geriye 0 döner
            bool example2TryRun = Int32.TryParse(example2, out outValue2);  // Değer Integer olmayan bir değer olarak geldiiği için geriye 0 döner
            bool example3TryRun = Int32.TryParse(example3, out outValue3);  // Değer sınırlar dışında olduğu için geriye 0 döner
            bool example4TryRun = Int32.TryParse(example4, out outValue4);
        }
    }
}