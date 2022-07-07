using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D03.DegiskenlerinFaaliyetAlanlari
{
    class Program
    {
        static string S2 = "Sabri Ayberk Hocaoğlu";
        static void Main(string[] args)
        {
            // Oluşturduğumuz değişkeni kullanabileceğimiz belirli sınırlar vardır.
            // Her bir değişken içerisinde oluşturulduğu süslü parantezler dahilinde geçerlidir.

            string S1 = "Halim Can Ocaklı";
            S1 = "Second Name";
        }
        static void Test()
        {
            // Bu kısımdan S1 değişkenine ulaşmak mümkün değildir.
            // Herhangi bir değişkene kodun her noktasından ulaşabilmek için o değişkenin globalde tanımlı olması gerekir.
            // Örneğin "S2" global bir değişkendir.

            S2 = "Oğuzhan Deniz";
        }
    }
}
