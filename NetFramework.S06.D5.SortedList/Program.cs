using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S06.D5.SortedListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedList, HashTable ve ArrayList yapılarının karışımı gibidir. Hem key-value ikililerini kullanabiliyor hem de key-value çiftine bir indeks numarasına göre erişebiliyoruz.
            // SortedList yapısının en belirgin özelliği ise adından da anlaşılacağı üzere sıralı olmasıdır. Sıralama işlemi temel veri türleri için büyüklük ve küçüklüğe göredir.
            // Ancak kendi karşılaştırma modelimizi de IComparer arayüzünü kullanarak oluşturabiliriz.
            // HashTable gibi parametre olarak key ve value değerleri alan bir kolleksiyondur.
            // HashTable'dan farklı olarak aldığı değerleri "key" değerlerine göre  A-Z yönünde sıralar.
            // Tüm keyler benzersiz ve tür olarak aynı olmalıdır. Aksi halde sıralama yapılamaz.
            // Yardımcı metotları ArrayList ve HashTable ile aynıdır.
            // SortedList yapısında sıralama Key elemanları üzerinden yapılır.
            // SortedList koleksiyonunun elemanlarına ulaşmak için Keys ve Values özellikleri kullanılabileceği gibi DictionaryEntry sınıfı da kullanılabilir.
            // Dictionary sınıfı her bir key-value ikilisini temsil etmek için kullanılır.

            string[] Kelimeler = {"Araba", "Masa", "Defter", "Kitap", "Okul"};
            SortedList Sozluk = new SortedList();

            Sozluk.Add("Araba", "Car");
            Sozluk.Add("Masa", "Table");
            Sozluk.Add("Kalem", "Pencil");
            Sozluk["Kitap"] = "Book";
            Sozluk["Bilgisayar"] = "Computer";

            EkranaYaz(Sozluk);

            for (int i = 0; i < Kelimeler.Length; i++)
            {
                if (Sozluk.ContainsKey(Kelimeler[i]))
                {
                    Console.WriteLine(Kelimeler[i] + " = " + Sozluk[Kelimeler[i]]);
                }
                else
                {
                    Console.WriteLine(Kelimeler[i] + ", sözlükte bulunamadı");
                }
            }

            Console.WriteLine();
            Sozluk.Add("Çizgi", "Line");    // Alfabetik özelliği incelenerek listeye yerleştirilir.

            EkranaYaz(Sozluk);
            Console.WriteLine();

            Console.WriteLine("Sıralı listede toplam {0} eleman bulunmaktadır.", Sozluk.Count);
            Console.WriteLine("Bu elemanlar: ");

            ICollection keys = Sozluk.Keys;

            foreach (string str in keys)
            {
                Console.WriteLine(str + "-");
            }

            Console.ReadLine();
        }

        public static void EkranaYaz(SortedList sList)
        {
            foreach (DictionaryEntry VARIABLE in sList)
            {
                Console.WriteLine("{0, -12} :{1, -12}", VARIABLE.Key, VARIABLE.Value);
            }
            Console.WriteLine();
        }
    }
}
