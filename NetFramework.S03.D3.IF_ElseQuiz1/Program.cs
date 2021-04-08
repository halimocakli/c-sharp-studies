using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S03.D3.IF_ElseQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ekran üzerinden girilen üç farklı not değerine göre öğrencinin ortalamasını hesaplayan,
             * hesaplanan ortalama değerine göre öğrencinin durumunu " Geçtiniz" veya "Kaldınız" şeklinde
             * ekrana yazan uygulamayı yazalım.
             *
             * 1- İşlem yapmak istediğimiz veri tiplerindeki değişkenlerimizi tanımlayalım
             * 2- Ekran üzerinden aldığımız değerleri, tür dönüşümü ile integer olarak tanımladığımız değerlerin üzerinde alalım.
             * 3- Kullanıcıdan aldığımız değerlere göre ortalama hesabı yapalım.
             * 4- Yapmış olduğumuz ortalama hesabının sonuç değerine göre uygulamamızda kara yapılarını kullanarak kullanıcıya mesaj verelim.
             */

            string isimSoyisim = string.Empty;

            int not1 = 0;
            int not2 = 0;
            int not3 = 0;

            double ortalama = 0;

            string ogrenciNot1 = string.Empty;
            string ogrenciNot2 = string.Empty;
            string ogrenciNot3 = string.Empty;

            Console.WriteLine("Lütfen ortalamasını hesaplamak istediğiniz öğrencinin bilgilerini giriniz");

            Console.Write("İsim-Soyisim: ");
            isimSoyisim = Console.ReadLine();

            Console.Write("Lütfen 1. not değerinizi giriniz: ");
            ogrenciNot1 = Console.ReadLine();

            Console.Write("Lutfen 2. not değerini giriniz: ");
            ogrenciNot2 = Console.ReadLine();

            Console.Write("Lütfen 3. not değerini giriniz: ");
            ogrenciNot3 = Console.ReadLine();

            not1 = int.Parse(ogrenciNot1);
            not2 = int.Parse(ogrenciNot2);
            not3 = int.Parse(ogrenciNot3);

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 50)
            {
                Console.WriteLine("\nMerhaba {0}", isimSoyisim);
                Console.WriteLine("Ortalamanız = {0}, Geçtiniz.", ortalama);
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }

            Console.Read();
        }
    }
}
