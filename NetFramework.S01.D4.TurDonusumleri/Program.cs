using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D4.TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;

            // Bilinçli Tür Dönüşümü

            int sayi2 = 125;

            sayi1 = (byte)sayi2;    // int veri türünden değer byte veri türüne dönüştürüldü

            Console.WriteLine(sayi1);
            
            // Bilinçsiz Tür Dönüşümü

            double sayi3 = 10;

            sayi3 = sayi2;  //Double veri tipi İnt veri tipinden boyut olarak üstün olduğu için sorun çıkmaz

            // Checked - Unchecked

            sayi2 = 512;
            sayi1 = (byte)sayi2;    // Değer kaybı yaşanacak ancak uyarı alınmayacak çünkü
                                    // derleyici default olarak yazılan kodları unchecked olarak izler.

            unchecked 
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2;
            }

            /*checked
            {
                // Özellikle para,altın vs. gibi dönüşümlerde checked kullanmak faydalı
                sayi2 = 512;
                sayi1 = (byte)sayi2;    // overflow yaşancak ve uyarı alınacak
            }*/

            // object veri tipi tüm .net veri tiplerinin atasidir.

            object temelTip = sayi2;
            temelTip = sayi3;
            temelTip = new
            {
                marka = "Opel",
                model = "Corsa",
            };

            // Boxing İşlemi...

            temelTip = sayi2;   // Boxing İşlemi
            sayi2 = (int) temelTip; // Unboxing İşlemi

            Console.Write("");



        }
    }
}
