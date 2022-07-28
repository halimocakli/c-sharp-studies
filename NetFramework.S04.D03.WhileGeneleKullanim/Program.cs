using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S04.D3.WhileGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsü Genel Kullanım

            /*
            while (true)
            {
                // Şart True olduğu süre boyunca döngü çalışmaya devam eder
                // 1- Döngü içindeki kod içerisinde şart False olursa döngü biter
                // 2- Döngü içerisinde break kullanılırsa döngü biter
            }
            */

            #endregion

            #region Örnekli Kullanım : Ekrana 1 - 10 Arası Değerleri Yazdıralım

            // For döngüsü ile işlemin cevabı
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            int sayac = 1;

            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            #endregion

            #region Kullanıcıdan Gelen Sayısal Değeri SAYI - 0 Aralığında Ekrana Yazalım

            int sayi;

            Console.Write("Sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------");


            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }

            #endregion

            Console.Clear();

            #region Kullanıcıdan Gelen Değerlerin Toplamını Bulup 0'dan Küçük Değer Girildiğinde Ekrana Yazdıran Uygulama

            Console.WriteLine("Toplamak istediğiniz sayilari giriniz. \"-1\" Girmeniz halinde proje sonlanacaktır.");

            int sayi2;
            int toplam = 0;
            while (true)
            {
                Console.Write("Sayi giriniz:");
                sayi2 = int.Parse(Console.ReadLine());
                if (sayi2 != -1)
                {
                    toplam += sayi2;
                }
                else
                {
                    Console.WriteLine("\nGirdiğiniz sayıların toplamı = {0}", toplam);
                    break;
                }
            }

            #endregion

            Console.Clear();

            #region Ödev: Sistemin Çalışma Zamanında Oluşturduğu 1 - 10 Arası Bir Değeri Kullanıcının Tahmin Ettiği Program

            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 10);
            int tahminAdedi = 1;

            Console.WriteLine("1 - 10 Arası Sayıyı Tahmin Edin..");

            while (true)
            {
                Console.Write("{0}.Deneme - Sayı Tahmin edin: ", tahminAdedi);
                int sayi3 = int.Parse(Console.ReadLine());

                if (sayi3 == rastgeleSayi)
                {
                    Console.WriteLine("\n{0}. Denemenizde Sayıyı Buldunuz, Tebrikler!", tahminAdedi);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}. denemeniz, Tahmininiz doğru değil, Yeniden Deneyin\n", tahminAdedi);
                    tahminAdedi++;
                }
            }

            Console.Clear();

            #endregion

        }
    }
}
