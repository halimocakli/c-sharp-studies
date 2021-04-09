using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S05.D1.DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            // Diziye eleman ekleme

            ogrenciIsimListesi[0] = "Halim Can Ocaklı";
            ogrenciIsimListesi[1] = "Cengiz Atilla";
            ogrenciIsimListesi[2] = "Mustafa Sel";
            ogrenciIsimListesi[3] = "Sabri Ayberk Hocaoğlu";
            ogrenciIsimListesi[4] = "Mert Kurtuluş";


            // Dizi elemanlarını ekrana yazdırma

            Console.WriteLine(ogrenciIsimListesi[1]);

            foreach (string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                Console.WriteLine(ogrenciIsimListesi[i]);
            }

            Console.ReadLine();
        }
    }
}