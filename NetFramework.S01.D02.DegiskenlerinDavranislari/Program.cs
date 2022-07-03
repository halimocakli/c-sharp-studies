using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D02.DegiskenlerinDavranislari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tüm sınıflar birer referans tipidir.
            // Referans tipleri Heap bölgesinde saklanırlar.

            Car firstCarDefinition = new Car();   // firstCarDefinition için Haep bölgesinde yer ayırıldı.

            firstCarDefinition.label = "Opel";
            firstCarDefinition.model = "Corsa";
            firstCarDefinition.color = "Blue";

            Console.WriteLine($"First Car Label: {firstCarDefinition.label}");
            Console.WriteLine($"First Car Model: {firstCarDefinition.model}");
            Console.WriteLine($"First Car Color: {firstCarDefinition.color}");


            Car secondCarDefinition = firstCarDefinition;
            // secondCarDefinition değikeni firstCarDefinition değişkeni ile aynı adresi gösteriyor.
            // Yeni bir yer ayrılmadı.
            // Dolayısıyla secondCarDefinition içindeki değerleri değitirirsek firstCarDefinition içindeki değerler de değişir

            Console.WriteLine($"Second Car Label: {secondCarDefinition.label}");
            Console.WriteLine($"Second Car Model: {secondCarDefinition.model}");
            Console.WriteLine($"Second Car Color: {secondCarDefinition.color}");

            secondCarDefinition.color = "Grey";
            secondCarDefinition.model = "Astra";

            Console.WriteLine($"Second Car Label: {secondCarDefinition.label}");
            Console.WriteLine($"Second Car Model: {secondCarDefinition.model}");
            Console.WriteLine($"Second Car Color: {secondCarDefinition.color}");

            Console.WriteLine($"First Car Label: {firstCarDefinition.label}");
            Console.WriteLine($"First Car Model: {firstCarDefinition.model}");
            Console.WriteLine($"First Car Color: {firstCarDefinition.color}");

            // Referans tipleri, eğer kod içerisinde onları işaret eden herhangi bir değişken kalmazsa bellekten düşer.

            firstCarDefinition = null;
            secondCarDefinition = null;

            // Diğer taraftan String veri ile ürettiğimiz değişkenlerin davranışlarını inceleyelim.
            string firstVariableValue = "Halim Can Ocaklı";
            string secondVariableValue = "Sabri Ayberk Hocaoğlu";

            Console.WriteLine($"First Variable Value : {firstVariableValue}");
            Console.WriteLine($"Second Variable Value : {secondVariableValue}");

            // İkinci değişkendeki string değeri birinci değişkene kopyalayalım.
            // Buradaki işlem referans tiplerdeki gibi değildir, burada referans gösterme değil kopyalama işlemi gerçekleşir.
            firstVariableValue = secondVariableValue;

            Console.WriteLine($"First Variable Value : {firstVariableValue}");
            Console.WriteLine($"Second Variable Value : {secondVariableValue}");

            secondVariableValue = "Oğuzan Deniz";

            Console.WriteLine($"First Variable Value : {firstVariableValue}");
            Console.WriteLine($"Second Variable Value : {secondVariableValue}");

            Console.ReadLine();
        }
    }

    class Car
    {
        public string label;
        public string model;
        public string color;
    }
}
