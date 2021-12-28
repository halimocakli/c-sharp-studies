using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S04.D1.ForGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü Genel Kullanımı

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ben bir for döngüsüyüm");
            }

            #endregion

            #region Ekran Üzerine 1 - 10 Arası Değerleri Yazdıralım

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            #endregion

            #region 1 - 100 Arasındaki Sayıları Ekrana Yazdıralım

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + 1);
            }

            #endregion

            #region 1 - 100 Arasındaki Çift Sayıları Ekrana Yazdıralım

            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            #endregion

            #region 1 - 100 Arasındaki Tek Sayıları Ekrana Yazdıralım

            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Küçük Bir Ödev

            // 1 - 100 Arasındaki değerlerin toplamını yazdıralım

            int toplam = 0;

            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }

            Console.WriteLine("Değerlerin toplamı = {0}", toplam);

            // 1 - 100 Arasındaki çift değerlerin toplamını ekrana yazdıralım

            toplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine("Çift değerlerin toplamı = {0}", toplam);

            // 1 - 100 Arasındaki tek değerlerin toplamını ekrana yazdıralım

            toplam = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine("Tek değerlerin toplamı = {0}", toplam);

            #endregion

            Console.Clear();

            /*
            #region Faktöriyel Ödevi

            string kullaniciGirilenDeger = string.Empty;

            int j;
            int sayi;
            int fakt = 1;

            Console.Write("Lütfen faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            kullaniciGirilenDeger = Console.ReadLine();

            sayi = int.Parse(kullaniciGirilenDeger);

            for (j = 1; j <= sayi ; j++)
            {
                fakt *= j;
            }

            Console.WriteLine("Girdiğiniz sayınının faktöriyeli = {0}", fakt);
            Console.ReadLine();

            #endregion
            */

            /*
            #region Sonsuz Döngü Oluşturmak

            // Sonsuz döngü içerisinde göreceğimiz keywordler şunlardır:
            // Break : Kullanıldığı yerde döngüyü ya da projeyi vs. sonlandırır.
            // Continue : Kullanıldığı yerde kullanıldığı şartları görmezden geleri ve proje devam eder.
            int sayac = 0;
            for (; ; )
            {
                //if (sayac == 2)
                //    break;
                sayac++;

                if (sayac == 2)
                    continue;

                Console.WriteLine(sayac);
                Console.WriteLine("Merhaba, ben bir sonsuz döngüyüm.");
            }

            Console.ReadLine();

            #endregion
            */

            #region İç İçe For Döngüsü

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Çarpım Tablosu Ödevi

            for (int k = 0; k <= 10; k++)
            {
                for (int z = 0; z <= 10; z++)
                {
                    int carpimSonuc = k * z;
                    Console.WriteLine("{0} x {1} = {2}", k, z, carpimSonuc);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            #endregion
        }
    }
}
