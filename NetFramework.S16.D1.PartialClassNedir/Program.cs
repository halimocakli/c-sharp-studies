using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.ID = 1;
            M1.Isim = "Halim Can";
            M1.SoyIsim = "Ocaklı";
            M1.eMailAdres = "halimcanocakli@gmail.com";

            int sonuc = M1.YeniKayit(M1);
            if (sonuc > 0)
            {
                Console.WriteLine("Musteri kaydı girildi.");
            }

            Ogrenci O1 = new Ogrenci();
            O1.ogrenciID = 2;
            O1.ogrenciIsim = "Halim Can";
            O1.ogrenciSoyIsim = "Ocaklı";
            O1.ogrenciNumarasi = "1910206523";
        }
    }
}
