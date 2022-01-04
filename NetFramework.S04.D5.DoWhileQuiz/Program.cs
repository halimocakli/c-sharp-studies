using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S04.D5.DoWhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ödev 1

            // Do-While içerisinde kullanıcıya kullanıcı adı ve password sorun
            // Eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın
            // Eğer yanlış giriş yapıyorsa Do-While döngüsüne devam edin.
            // Kullanıcı Adı: Demo
            // Şifre: Demo

            string kullaniciAdi = "Demo";
            string sifre = "Demo";
            string kullaniciAdiGiriş = string.Empty;
            string sifreGiris = string.Empty;

            do
            {
                Console.Write("Kullanıcı Adı: ");
                kullaniciAdiGiriş = Console.ReadLine();
                Console.Write("Şifre: ");
                sifreGiris = Console.ReadLine();

                if (kullaniciAdiGiriş != kullaniciAdi || sifreGiris != sifre)
                {
                    Console.WriteLine("\nŞifre ya da kullanıcı adınızı yanlış girdiniz. Lütfen yeniden deneyin.\n");
                }
                else
                {
                    Console.WriteLine("\nGirdiğiniz bilgiler doğrudur.");
                }
            } while (kullaniciAdiGiriş != kullaniciAdi || sifreGiris != sifre);

            #endregion

            Console.Clear();

            #region Ödev 2

            /*
             * Kullanıcıdan 1 - N arasında bir sayı alınacak ve bilgisayar bu sayı aralıkları içerisinden
             * rastgele bir sayı seçecek. Ardından kullanıcı bilgisayarın rastgele seçtiği sayıyı bulmaya
             * çalışacak. Bulamaması durumunda program çalışmaya devam edecek ve deneme sayısı kaydedilecek.
             * Sayı bulunduğu zaman program duracak ve demene sayısı ekrana yazdırılacak.
             */

            int kullaniciGiris = 0;
            int tahminAdedi = 1;

            Console.Write("Sayı aralığınızın Tavan değerini giriniz: ");
            int tavanDeger = int.Parse(Console.ReadLine());

            Console.WriteLine("Bilgisayar 1 ile {0} arasından bir sayı tercih edecek...", tavanDeger);

            Random rastgele = new Random();
            int rndSayi = rastgele.Next(1, tavanDeger);
            Console.WriteLine("Bilgisayar sayıyı seçti. Şimdi tahmin zamanı.");

            do
            {
                Console.Write("\n{0}. Deneme - Sayı Girişi Yapın: ", tahminAdedi);
                kullaniciGiris = int.Parse(Console.ReadLine());

                if (kullaniciGiris == rndSayi)
                {
                    Console.WriteLine("\nTebrikler {0}. Denemede Sayıyı Buldunuz!", tahminAdedi);
                }
                else
                {
                    Console.WriteLine("Tekrar Deneyin.");
                    tahminAdedi++;
                }
            } while (kullaniciGiris != rndSayi);


            #endregion
        }
    }
}
