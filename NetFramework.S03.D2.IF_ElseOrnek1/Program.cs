using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S03.D2.IF_ElseOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekran üzerinden girilen kullanıcı adı ve şifre değerlerine göre sisteme giriş yapmaya çalışalım
            // Kullanıcı Adı: Demo
            // Şifre: 1234

            string kullaniciAdi = "";
            string sifre = "";

            Console.Write("LÜtfen kullanıcı adınızı giriniz: ");
            kullaniciAdi = Console.ReadLine();

            Console.Write("Lütfen şifrenizi giriniz: ");
            sifre = Console.ReadLine();

            if (kullaniciAdi == "Demo" && sifre == "1234")
            {
                Console.WriteLine("Giriş yaptınız, tebrikler");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı girişi...");
            }

            Console.ReadLine();
        }
    }
}
