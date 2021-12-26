using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S02.D1.AritmetikselOperatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            // "+" Toplam Operatörü

            #region Operatörler - Toplama(Tanım)

            int toplamOperatoruSayi1 = 10;
            int toplamOperatoruSayi2 = 15;
            int toplamOperatoruToplam = toplamOperatoruSayi1 + toplamOperatoruSayi2;
            Console.WriteLine("Toplam : " + toplamOperatoruToplam);
            #endregion

            #region Operatörler - Toplama(Ödev)

            Console.WriteLine("Ekran üzerinden girilen iki farklı sayıyı toplayan bir uygulama yazınız...");

            string kullaniciGelenDeger1 = string.Empty;
            string kullaniciGelenDeger2 = string.Empty;

            int odevSayi1 = 0;
            int odevSayi2 = 0;
            int kullaniciToplamDeger = 0;

            Console.Write("Birinci Sayıyı Giriniz: ");
            kullaniciGelenDeger1 = Console.ReadLine();

            Console.Write("İkinci Sayıyı Giriniz: ");
            kullaniciGelenDeger2 = Console.ReadLine();

            odevSayi1 = int.Parse(kullaniciGelenDeger1);
            odevSayi2 = int.Parse(kullaniciGelenDeger2);

            kullaniciToplamDeger = odevSayi1 + odevSayi2;

            Console.WriteLine("Girdiğiniz değerlerin toplamı = {0}", kullaniciToplamDeger);
            #endregion

            // "-" Çıkartma Operatörü

            #region Operatörler - Çıkartma(Tanım)

            int cikartOperatoruSayi1 = 30;
            int cikartOperatoruSayi2 = 10;
            int cikartOperatoruSonuc = cikartOperatoruSayi1 - cikartOperatoruSayi2;
            Console.WriteLine("Çıkartma işlemi sonucu : {0}", cikartOperatoruSonuc);
            #endregion

            #region Operatörler - Çıkartma(Ödev)

            string kullanicidanGelenDegerCikartma1 = string.Empty;
            string kullanicidanGelenDegerCikartma2 = string.Empty;

            int cikartmaSayi1 = 0;
            int cikartmaSayi2 = 0;
            int cikartmaSonucu = 0;

            Console.Write("Birinci Sayıyı Giriniz: ");
            kullanicidanGelenDegerCikartma1 = Console.ReadLine();
            Console.Write("İkinci Sayıyı Giriniz: ");
            kullanicidanGelenDegerCikartma2 = Console.ReadLine();

            cikartmaSayi1 = int.Parse(kullanicidanGelenDegerCikartma1);
            cikartmaSayi2 = int.Parse(kullanicidanGelenDegerCikartma2);
            cikartmaSonucu = cikartmaSayi1 - cikartmaSayi2;
            Console.WriteLine("Çıkartma işleminin sonucu = {0}", cikartmaSonucu);
            #endregion

            // "/" Bölme Operatörü

            #region Operatörler - Bölme(Tanım)

            int bolmeOperatoruSayi1 = 30;
            int bolmeOperatoruSayi2 = 2;
            int bolmeOperatoruSonuc = bolmeOperatoruSayi1 / bolmeOperatoruSayi2;
            Console.WriteLine("Bölme işlemi sonucu = {0}", bolmeOperatoruSonuc);
            #endregion

            // "*" Çarpma Operatörü

            #region Operatörler - Çarpma(Tanım)

            int carpmaOperatoruSayi1 = 10;
            int carpmaOperatoruSayi2 = 2;
            int carpmaOperatoruSonuc = carpmaOperatoruSayi1 * carpmaOperatoruSayi2;
            Console.WriteLine("Çarpma işleminin sonucu = {0}", carpmaOperatoruSonuc);
            #endregion

            // "%" Mod Alma Operatörü

            #region Operatörler - Mod Alma(Tanım)

            // Mod alma işlemi, iki sayının bölümünden kalanı bulmamızı sağlar.

            int modOperatoruSayi1 = 10;
            int modOperatoruSayi2 = 3;
            int modOperatoruSonuc = modOperatoruSayi1 % modOperatoruSayi2;
            Console.WriteLine("Mod işlemi sonucu  {0}", modOperatoruSonuc);

            #endregion

            // "--" ve "++" Operatörleri

            #region Operetörler - "--" ile "++" (Tanım)

            int aritmetikselSayi = 40;
            aritmetikselSayi++;
            aritmetikselSayi--;
            aritmetikselSayi += 5;
            aritmetikselSayi -= 5;
            // Uygulamayı Debug yöntemi ile inceleyebiliriz.

            Console.ReadLine();
            #endregion

        }
    }
}
