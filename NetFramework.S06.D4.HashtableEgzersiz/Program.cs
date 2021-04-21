using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S06.D4.HashTableOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hahtable içerisine ENG -TR olacak şekilde data ekleyeceğiz.
             * Yeni kayıt eklemek istiyormusunuz E/H
             * E : Yeni kayıt ekleme işlemi devam etsin, 
             * H : Tüm listeyi yazdırın. 
             * 
             * Var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden ... şeklinde sistemimizde bulunmaktadır.
             */

            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("...Sözlüğe Kelime Ekleyin...");
                Console.Write("EN : ");
                string engKelime = Console.ReadLine();

                bool kontrol = sozlukVeriTabani.ContainsKey("eng");
                if (kontrol)
                {
                    Console.WriteLine(
                        "Eklemek istediğiniz değer olan {0} sözlük içerisinde bulunmaktadır. {1} değerin Türkçe karşılığıdır.",
                        engKelime, sozlukVeriTabani[engKelime].ToString());
                }
                else
                {
                    Console.WriteLine("{0} İngilizce değerin Türkçe karşılığını yazın: ", engKelime);
                    string turkceKelime = Console.ReadLine();

                    sozlukVeriTabani.Add(engKelime, turkceKelime);
                    Console.WriteLine("Değer ekleme işlemi başarılı...");
                }

                Console.Write("Yeni değer eklemek istiyor musunuz?(E/H): ");
            } while (Console.ReadLine().ToUpper() != "H");

            // 1. Yöntem
            //.Keys proporty kullanılarak key değerleri üzerinde dolaşılıyor
            // her bir key'i item temsil ediyor
            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("ENG : {0} = TR : {1}", item, sozlukVeriTabani[item]);
            }

            // 2. Yöntem

            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                // Console.WriteLine(item.GetType().Name); // item'ın tipini öğrendik => DictionaryEntry
                Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
            }
        }
    }
}
