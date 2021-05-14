using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S07.D9.NamedParametreler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Opsiyonel parametreler konusunda verdiğimiz örnek metottaki b değişkenin varsayılan değerde ama c değişkenini kendimiz vermek istersek
             * ne yapacağız? İçgüdüsel olarak Metot("Halim", , 10); şeklinde bir çağrım aklımıza gelmekte ancak C# dilinde metotlara ek parametre gönderirken
             * ek vigül konarak parametre atlaması yapılamaz. Bu nedenle C# 4.0'dan itibaren metot çağrım ifadelerinde bilinçli olarak parametre adı belirtilerek
             * ilgili parametreyi vermek istediğimizi açıkça beyan edebiliriz. Bu tür parametreler "Named Parameters" ya da "İsimlendirilmiş Parametre" olarak
             * adlandırılmaktadır. Dolayısıyla çağrım işlemini aşağıdaki gibi yapmak mümkündür.
             */

            Metot("Halim", c: 10);

            // Aynı şekilde aşağıdaki çağrım ifadelerinde de hepsi geçerlidir.

            Metot(c:22, a:"Halim", b:"Ocaklı");
            Metot(a:"Halim", b:"Ocaklı");

            // "a" parametresi opsiyonel olmadığı için her durumda mutlaka verilmelidir. Ancak opsiyonel olmasa da isim belirterek parametre vermekte bir sakınca yoktur.
            // Parametreler isimleri ile açıkça gönderildiğinde parametrelerin işlem sırasının çağrım ifadesine göre soldan sağa doğru olma kuralı değişmez.
            // Yani __Metot(b:"Ocaklı", a:"Halim");__ çağrımında işlem sırası ilk olarak "b" değişkenine gelecektir.

            // Opsiyonel ve isimlendirilmiş parametreler yapıcı metotlarda ve indeksleyicilerde de kullanılabilir.

            /*
             * Opsiyonel parametre tanımlanan metotlarda opsiyonel parametreler metot imzası oluşturulurken aynen params anahtar sözcüğünde olduğu gibi ikinci plandadır.
             * Yani tercih edilen metot opsiyonel parametresi olmayan metottur. Örneğin aşağıdaki metot bildirimlerine göre Deneme("Ali","Veli"); şeklindeki bir çağrım
             * sonucunda ekrana "Metot 2" yazacaktır.
             */

            Deneme("Ali", "Veli");

            /*
             * Bu seçim işlemi ancak bütün parametre tipleri birebir uyuştuğunda geçerlidir. 2. Metodun ilk parametresini string yerine object yaptığımızda
             * bu durumda 1. Metot imzaya tam uyumlu olduğu için bu sefer 1. Metot çağırılacaktır.
             */


        }

        public static void Metot(string a, string b = "Halim", int c = 9)
        {
            Console.WriteLine("a = " + a + " b = " + b + " c = " + c.ToString());
        }

        public static void Deneme(string a, string b = "Ali", int c = 7)
        {
            Console.WriteLine("Metot 1");
        }

        public static void Deneme(string a, string b)
        {
            Console.WriteLine("Metot 2");
        }
    }
}
