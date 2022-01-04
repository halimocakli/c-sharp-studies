using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S06.D2.ArrayListOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();
            
            do
            {
                Console.WriteLine("Menu\n************************\n");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Güncelle");
                Console.WriteLine("5 - Değer Sırala");
                Console.WriteLine("6 - Değer Sil");
                Console.WriteLine("7 - Uygulama Çıkış");
                Console.WriteLine("\n************************");
                Console.Write("Lütfen Seçim Yapınız: ");

                kullaniciSecim = Console.ReadLine();

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.WriteLine("\nTek değer eklemek için \"1\" tuşlayın");
                        Console.WriteLine("Birden fazla değer eklemek için \"2\" tuşlayın");
                        Console.Write("Tuşlama yapın: ");
                        string degerEklemeSecim = Console.ReadLine();

                        switch (degerEklemeSecim)
                        {
                            case "1":
                                Console.Write("\nYeni eleman ekleyin: ");
                                degerListesi.Add(Console.ReadLine());
                                Console.WriteLine("Değeriniz listeye başarıyla eklendi.");
                                break;
                            case "2":
                                string devamSecim = string.Empty;
                                do
                                {
                                    Console.Write("\nYeni eleman ekleyin: ");
                                    degerListesi.Add(Console.ReadLine());

                                    Console.Write("Eklemeye devam etmek istiyor musunuz?(E/H): ");
                                    devamSecim = Console.ReadLine();
                                } while (devamSecim.ToUpper() == "E");
                                Console.WriteLine("Değerleriniz listeye başarıyla eklendi.");
                                break;
                        }

                        System.Threading.Thread.Sleep(2000);
                        break;  //Case1 break

                    case "2":
                        Console.WriteLine("\nDeğerleriniz listeleniyor...");
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("--------------------------------------");
                        Console.Write("Devam etmek için bir tuşa basın.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz: ");
                        string arananDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(arananDeger);

                        if (kontrol)
                        {
                            int arananDegerIndex = degerListesi.IndexOf(arananDeger);
                            string bulunanDeger = degerListesi[arananDegerIndex].ToString();
                            Console.WriteLine("Aradığınız değer: {0}\n Bulunduğu indeks: {1}", bulunanDeger, arananDegerIndex);
                        }
                        else
                        {
                            Console.WriteLine("Listede böyle bir eleman yok.");
                            Console.WriteLine("Listeye bu değeri eklemek ister misiniz?(E/H): ");
                            string cevap = Console.ReadLine();

                            if (cevap.ToUpper() == "E")
                            {
                                Console.Write("Yeni eleman ekleyin: ");
                                degerListesi.Add(Console.ReadLine());
                                Console.WriteLine("Değeriniz listeye başarıyla eklendi.");

                                System.Threading.Thread.Sleep(2000);
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz: ");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} Değerini hangi değer ile güncellemek istiyorsunuz?: ", kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();

                        if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciYeniDegerIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerListesi[kullaniciYeniDegerIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Değeriniz başarıyla güncellendi...");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz değer listede bulunmamaktadır...");
                        }

                        System.Threading.Thread.Sleep(2000);

                        break;
                    case "5":
                        Console.WriteLine("Listenizi A - Z doğrultusunda sıralamak için \"1\" tuşlayınız");
                        Console.WriteLine("Listenizi Z - A doğrultusunda sıralamak için \"2\" tuşlayınız");
                        Console.Write("\nTuşlama yapın: ");
                        string siralamaSecim = Console.ReadLine();

                        switch (siralamaSecim)
                        {
                            case "1":
                                degerListesi.Sort();
                                break;
                            case "2":
                                degerListesi.Sort();
                                degerListesi.Reverse();
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Belirli bir değeri silmek için \"1\" tuşlayınız");
                        Console.WriteLine("Liste içerisindeki tüm değerleri silmek için \"2\" tuşlayınız");
                        Console.Write("Lütfen tuşlama yapın: ");
                        string degerSilmeSecim = Console.ReadLine();

                        switch (degerSilmeSecim)
                        {
                            case "1":
                                Console.Write("Silmek istediğiniz değeri giriniz: ");
                                string silinecekDeger = Console.ReadLine();

                                if (degerListesi.Contains(silinecekDeger))
                                {

                                    int silinecekIndexDeger = degerListesi.IndexOf(silinecekDeger);
                                    degerListesi.RemoveAt(silinecekIndexDeger);
                                    Console.WriteLine("Değer başarıyla silindi...");
                                }
                                else
                                {
                                    Console.WriteLine("Değer bulunamadı.");
                                }

                                System.Threading.Thread.Sleep(2000);
                                break;
                            case "2":
                                Console.WriteLine("Liste içindeki tüm değerler siliniyor...");
                                degerListesi.Clear();
                                degerListesi.TrimToSize();
                                break;
                        }
                        break;
                    default:
                        break;
                }

                Console.Clear();
            } while (kullaniciSecim != "7");

            Console.ReadLine();
        }
    }
}
