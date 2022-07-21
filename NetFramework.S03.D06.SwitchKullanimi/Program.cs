using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S03.D6.SwitchKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanGelenDeger1 = string.Empty;
            string kullanicidanGelenDeger2 = string.Empty;

            int sayi1 = 0;
            int sayi2 = 0;

            int sonuc = 0;
            int sonuc2 = 0;

            string kullaniciİslemGiris = string.Empty;

            Console.Write("1.Sayıyı Giriniz: ");
            kullanicidanGelenDeger1 = Console.ReadLine();
            Console.Write("2.Sayıyı Giriniz: ");
            kullanicidanGelenDeger2 = Console.ReadLine();

            sayi1 = int.Parse(kullanicidanGelenDeger1);
            sayi2 = int.Parse(kullanicidanGelenDeger2);

            Console.Clear();

            Console.WriteLine("İşlem Seçiniz\n*************\n");
            Console.WriteLine("Toplama : \"+\"\nÇıkarma : \"-\"\nÇarpma  : \"*\"\nBölme   : \"/\"");

            Console.Write("\nİşlem Seçiniz: ");
            kullaniciİslemGiris = Console.ReadLine();

            switch (kullaniciİslemGiris)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işleminin sonucu = {0}", sonuc);
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    sonuc2 = sayi2 - sayi1;
                    Console.WriteLine("Çıkarma işleminin sonucu = {0}\nİkinci sayıdan birinci sayıyı çıkardığımızda sonuç = {1}", sonuc, sonuc2);
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma işleminin sonucu = {0}", sonuc);
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    sonuc2 = sayi2 / sayi1;
                    Console.WriteLine("Bölme işleminin sonucu = {0}\nİkinci sayı ile birinci sayıyı böldüğümüzde sonuç = {1}", sonuc, sonuc2);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem girişi yapıldı");
                    break;
            }

            Console.ReadLine();
        }
    }
}
