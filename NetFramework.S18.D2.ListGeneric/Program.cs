using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D2.ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Generic => ArrayList'in Generic versiyonu

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");
            // ArrayList elemanları object olarak tutulur

            // <T> : T tipi demek, .Net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek, kavram olarak çokça kullanılır.
            // Generic mimarisi ile birlikte önceden object olarak tuttuğumuz liste elemanlarını artık istediğimiz tipte tutabiliriz. Bu yönteme tip güvenli yöntem denir.
            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            
            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> ListeIsimler = new List<string>();
            ListeIsimler.Add("Halim");
            ListeIsimler.Add("Can");
            ListeIsimler.Add("Aga");

            for (int i = 0; i < ListeIsimler.Count; i++)
            {
                Console.WriteLine(ListeIsimler[i]);
            }

            // Musteri nesnemizin propertylerine değer atanıyor.

            Musteri M1 = new Musteri();
            M1.ID = 1910206523;
            M1.musteriIsim = "Halim Can";
            M1.musteriSoyIsim = "Ocaklı";

            List<Musteri> musteriListe = new List<Musteri>();
            musteriListe.Add(M1);

            // Ya da hızlı nesne örnekleme yöntemini kullanarak aşağıdaki gibi bir uygulama yapabiliriz:

            /*
             *  List<Musteri> musteriListe = new List<Musteri>();
             *  musteriListe.Add()
             *  {
             *          ID = 1910206523,
             *          musteriIsim = "Halim Can",
             *          musteriSoyIsim = "Ocaklı"
             *  });
             *
             */

            foreach (Musteri VARIABLE in musteriListe)
            {
                Console.WriteLine(VARIABLE.musteriIsim);
            }
        }
    }
}
