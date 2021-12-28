using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S04.D2.ForeachGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bu döngü metodu genelde Koleksiyonlar üzerinde çalıştırılır ve read-only metottur. Dolayısıyla üzerinde dolaştığımız dizi elemanlarını değiştiremeyiz.
            // Database üzerinde işlem yaparken ve her bir eleman üzerinde dolaşırken Foreach döngüsünü kullanmak standarttır.

            #region Genel Kullanım
            /*
                string[] Isimler = new[] { "Halim Can Ocaklı", "Mustafa Gökmen", "Cengiz Atilla" };

                // Dizi içerisindeki bütün stringler tek tek item üzerine alınır ve item dizi içerisindeki tek bir değeri işaret eder.

                foreach (string item in Isimler)
                {
                    Console.WriteLine(item);
                }
            */
            #endregion


            #region Örnek Uygulamalar


            #region Uygulama 1

            /*
             * İnteger veri tipinde bir dizi oluşturalım. Kullanıcımız dizinin kaç elemanlı olacağı
             * bilgisini bize versin ve dizi içerisindeki elemanlara değer ataması yapsın. Daha sonra
             * dizi içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir uygulama
             * yazalım.
             */
            
            /*
                Console.Write("Lütfen oluşturmak istediğiniz dizinin boyutunu giriniz: ");
                int boyut = Convert.ToInt32(Console.ReadLine());

                int toplam = 0;
                double ortalama = 0;
                int[] uygulamaDizi = new int[boyut];

                for (int i = 0; i < uygulamaDizi.Length; i++)
                {
                    Console.Write("Dizinin {0}. elemanının değerini giriniz: ", i + 1);
                    uygulamaDizi[i] = Convert.ToInt32(Console.ReadLine());
                    toplam += uygulamaDizi[i];
                }

                Console.WriteLine("Dizi Değerleri Yazdırılıyor...");

                foreach (int item in uygulamaDizi)
                {
                    Console.WriteLine("Dizinin Değeri = {0}", item);
                }

                ortalama = (double)toplam / boyut;

                Console.WriteLine("Dizi değerlerinin toplamı = {0}", toplam);
                Console.WriteLine("Dizi değerlerinin ortalaması = " + ortalama);
            */
            #endregion


            #region Uygulama 2

            /*
             * 20 elemanlı bir integer dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 10 arasındaki değerler ile dolduralım.
             * Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım.
             */

            int[] uygulamaDizi = new int[20];

            Random rastgele = new Random();

            for (int i = 0; i < uygulamaDizi.Length; i++)
            {
                uygulamaDizi[i] = rastgele.Next(1, 10);
            }

            Console.WriteLine("Dizi elemanları yazdırılıyor...");

            int dortSayaci = 0;
            int sayac = 1;

            foreach (int VARIABLE in uygulamaDizi)
            {
                if (VARIABLE == 4)
                    dortSayaci++;

                Console.WriteLine("{0}.Dizi elemani = {1}", sayac, VARIABLE);
                sayac++;
            }

            Console.WriteLine("\nDizideki \"4\" adedi = {0}", dortSayaci);


            #endregion


            #endregion
        }
    }
}
