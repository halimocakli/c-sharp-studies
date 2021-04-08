using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S03.D7.SwitchCaseQuiz
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

            switch (kullanicidanGelenDeger)
            {
                case "1" : Console.WriteLine("Ocak");break;
                case "2" : Console.WriteLine("Şubat"); break;
                case "3" : Console.WriteLine("Mart"); break;
                case "4" : Console.WriteLine("Nisan"); break;
                case "5" : Console.WriteLine("Mayıs"); break;
                case "6" : Console.WriteLine("Haziran"); break;
                case "7" : Console.WriteLine("Temmuz"); break;
                case "8" : Console.WriteLine("Ağustos"); break;
                case "9" : Console.WriteLine("Eylül"); break;
                case "10": Console.WriteLine("Ekim"); break;
                case "11": Console.WriteLine("Kasım"); break;
                case "12": Console.WriteLine("Aralık"); break;
                default:
                    Console.WriteLine("Geçersiz bir değer girdiniz...[1-12]");
                    goto YenidenSecim;
            }

            Console.ReadLine();
        }
    }
}
