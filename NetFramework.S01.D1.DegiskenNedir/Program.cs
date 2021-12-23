using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D1.DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prototip: veritipi degisken

            string isim;
            isim = "Halim Can Ocaklı";

            Console.Write("Kullanıcı Adı: ");
            Console.WriteLine(isim);

            // Ekran Çıktısı => Kullanıcı Adı: Halim Can Ocaklı

            int sayi1 = 0;

            sayi1 = int.MinValue;
            Console.WriteLine("En düşük değer");
            Console.WriteLine(sayi1);

            sayi1 = int.MaxValue;
            Console.WriteLine("En yüksek değer:");
            Console.WriteLine(sayi1);

            Console.ReadLine();


        }
    }
}
