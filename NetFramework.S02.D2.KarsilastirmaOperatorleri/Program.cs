using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S02.D2.KarsilastirmaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * < : Küçüktür
             * > : Büyüktür
             * <= : Küçük Eşittir
             * >= : Büyük Eşittir
             * == : Eşit İse
             * != : Eşit Değildir/Eşit Değil İse
             * is : Tür Dönüşümlerinde Kullandığımız Operatör
             * as : Tür Dönüşümlerinde Kullandığımız Operatör
             */

            int Sayi1 = 10;
            int Sayi2 = 15;

            #region Küçüktür "<" Operatörü - Tanım

            bool KucukOperatorSonuc = Sayi1 < Sayi2;
            Console.WriteLine(KucukOperatorSonuc);  // True sonucu alınır

            #endregion

            #region Büyüktür ">" Operatörü -Tanım

            bool BuyukOperatorSonuc = Sayi1 > Sayi2;
            Console.WriteLine(BuyukOperatorSonuc);  // False sonucunu alırız 

            #endregion

            #region Küçük Eşittir "<=" Operatörü - Tanım

            bool KucukEsittirSonuc = Sayi1 <= Sayi2;
            Console.WriteLine(KucukEsittirSonuc);   // True sonucunu alırız

            #endregion

            #region Büyük Eşittir ">=" Operatörü - Tanım

            bool BuyukEsitirSonuc = Sayi1 >= Sayi2;
            Console.WriteLine(BuyukEsitirSonuc);    //False sonucunu alırız

            #endregion

            #region "==" ve "!=" Operatörleri - Tanım

            bool esittirOperatorSonuc = Sayi1 == Sayi2;         // False değeri alırız
            bool esitDegildirOperatorSonuc = Sayi1 != Sayi2;    // True değeri alırız

            #endregion

            #region "is" - "as" Operatörleri - Tanım

            object o1 = "Halim";
            // int sayi1 = (int) o1; => bu atama işlemi türler arası uyumsuzluk sebebiyle hata verecektir

            bool veriTipiKontrol = o1 is int;   // o1 nesnesi içinde bulunan değer int veri türü mü? 
            Console.WriteLine(veriTipiKontrol); // False uyarısı alırız

            object o2 = "Halim Can Ocaklı";
            string isim = o2 as string;     // o2 nesnesinin içindeki değeri string olarak isim değişkenine atadık çünkü nesne içindeki değer de string yani uyumlu

            // Yukarıdaki işlemler sonucunda "is" operatörü ile nesne içersindeki değerin, o değeri dönüştürmmek istediğimiz veri türü ile uyumlu olup olmadığını kontrol edip
            // "as" operatörü ile dönüştürme işlemi yapabileceğimizi anladık.

            #endregion

        }
    }
}
