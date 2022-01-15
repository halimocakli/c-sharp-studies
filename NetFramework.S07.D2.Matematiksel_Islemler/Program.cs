using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D2.Matematiksel_Islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            int kullaniciSecim;
            string kontrol = string.Empty;
            Matematik Math = new Matematik();

            do
            {
                YenidenIslemYap:
                Math.menuHazirla();
                kullaniciSecim = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Lütfen işlem yapmak için 1. sayıyı girin: ");
                decimal sayi1 = decimal.Parse(Console.ReadLine());

                Console.Write("Lütfen işlem yapmak için 2. sayıyı girin: ");
                decimal sayi2 = decimal.Parse(Console.ReadLine());

                switch (kullaniciSecim)
                {
                    case 1:
                        Console.WriteLine("\nToplama işleminiz yapılıyor...");
                        Console.WriteLine("Giriğiniz değerlerin toplamı = {0}", Math.toplamaIslemi(sayi1, sayi2));
                        break;
                    case 2:
                        Console.WriteLine("\nÇıkarma işleminiz yapılıyor...");
                        Console.WriteLine("Giriğiniz değerlerin çıkartma sonucu = {0}",
                            Math.cikartmaIslemi(sayi1, sayi2));
                        break;
                    case 3:
                        Console.WriteLine("\nBölme işleminiz yapılıyor...");
                        Console.WriteLine("Giriğiniz değerlerin birbirine bölümü sonucu = {0}",
                            Math.bolmeIslemi(sayi1, sayi2));
                        break;
                    case 4:
                        Console.WriteLine("\nÇarpma işleminiz yapılıyor...");
                        Console.WriteLine("Giriğiniz değerlerin çarpımı = {0}", Math.carpmaIslemi(sayi1, sayi2));
                        break;
                    default:
                        Console.WriteLine("\nYanlış değer girişi yaptınız. Tekrar deneyin.");
                        System.Threading.Thread.Sleep(2000);
                        goto YenidenIslemYap;
                }

                Console.Write("\nYeniden işlem yapmak istiyor musunuz?[E/H]: ");
                kontrol = Console.ReadLine().ToUpper();
            } while (kontrol != "H");

            Console.ReadLine();
        }
    }
}
