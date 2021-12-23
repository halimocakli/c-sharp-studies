using System;

namespace NetFramework.S01.D5.ConsoleKomutlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanGelenDeger = string.Empty;

            //Kullaniciya mesaj gostermek...

            Console.Write("Mesaj 1");
            Console.WriteLine("Mesaj 2");

            Console.Clear();

            //Kullainicidan deger alma işi temel ihtiyacimizdir

            Console.Write("Lütfen adınızı giriniz: ");
            kullanicidanGelenDeger = Console.ReadLine();

            // Elimizde olan değişken ya da değişkenleri kullaniciya mesaj olarak göstermenin birden fazla yöntemi bulunmaktadır.

            // 1. Yöntem
            string mesaj = "Kullanıcının girmiş olduğu isim:" + kullanicidanGelenDeger;
            Console.WriteLine(mesaj);

            Console.Clear();

            // 2. Yöntem
            mesaj = "";
            mesaj = string.Format("Girmiş olduğunuz isim:{0}", kullanicidanGelenDeger);

            // 3. Yöntem
            Console.Clear();
            Console.WriteLine("Girmiş olduğunuz isim: {0}", kullanicidanGelenDeger);
            Console.Clear();


            //Parse&Convert
            Console.WriteLine("Lütfen 1 - 10 Arasında Bir Değer Giriniz: ");
            string gelenDeger = Console.ReadLine();

            // Bu şekilde bir dönüştürme işlemi yanlıştır => int sayi1 = (int) gelenDeger;

            int sayi1 = int.Parse(gelenDeger);          // Yukarıda girdiğimiz string değerini integer değerine döndürebilmek için Parse() komutunu kullandık
            int sayi2 = Convert.ToInt32(gelenDeger);    // Yukarıda girdiğimiz string değerini integer değerine döndürebilmek için Convert() komutunu kullandık

            int toplam1 = sayi2 + 20;
            int toplam2 = sayi1 + 15;

            Console.WriteLine("Toplam değer: {0}", toplam2);
            Console.WriteLine("Toplam değer: {0}", toplam1);

            Console.ReadLine();
            
        }
    }
}
