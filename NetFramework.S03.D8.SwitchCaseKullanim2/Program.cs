using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S03.D8.SwitchCaseKullanim2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanGelenDeger = string.Empty;

            // Goto kullanımı için bir başlık tanımlaması yapalım

            YenidenSecim:
            Console.Write("Lütfen bulunduğunuz ayın sayısal değerini yazınız: ");
            kullanicidanGelenDeger = Console.ReadLine();

            // Bir projenin bölümlerine Faz denir
            // Case yapısı gruplar halinde kullanılabilir

            switch (kullanicidanGelenDeger)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("1.Faz");
                    break;

                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("2.Faz");
                    break;
                
                case "10":
                case "11":
                case "12":
                    Console.WriteLine("3.Faz");
                    break;

                default:
                    Console.WriteLine("Geçersiz bir değer girdiniz...[1-12]");
                    goto YenidenSecim;
            }
            Console.ReadLine();
        }
    }
}
