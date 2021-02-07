using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D2.ReferansTipDavranis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tüm sınıflar birer referans tipidir.
            // Referans tipleri Heap bölgesinde saklanırlar.

            araba arabaTanimi1 = new araba();   // arabaTanimi1 için Haep bölgesinde yer ayırıldı.

            arabaTanimi1.marka = "Opel";
            arabaTanimi1.model = "Corsa";
            arabaTanimi1.renk = "Mavi";

            araba arabaTanim2 = arabaTanimi1;   // arabaTanim2 değikeni arabaTanimi1 değişkeni ile aynı adresi gösteriyor.
                                                // Yeni bir yer ayırılmadı.
                                                // Dolayısıyla arabaTanim2 içindeki değerleri değitirirsek arabaTanimi1 içindeki değerler de değişir


            arabaTanim2.renk = "Gri";
            arabaTanim2.model = "Astra";

            // Referans tipleri, eğer kod içerisinde onları işaret eden herhangi bir değişken kalmazsa bellekten düşer

            arabaTanimi1 = null;
            arabaTanim2 = null;

        }
    }

    class araba
    {
        public string marka;
        public string model;
        public string renk;
    }
}
