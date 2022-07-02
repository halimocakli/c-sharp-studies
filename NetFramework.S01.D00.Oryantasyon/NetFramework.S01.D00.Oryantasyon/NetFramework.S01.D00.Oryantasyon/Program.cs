using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D00.Oryantasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsol uygulamalarına ait kodları buraya yazacağız.
            // Ekrana, kullanıcı tarafından görülmesini istediğimiz yazıları yazdırmak için bazı komutları kullanırız.
            // Bunlar:

            Console.WriteLine("Hello World!");
            Console.Write("I'm learning C#");

            // Console.WriteLine() metodu, yazmak istediğimiz yazıyı ekrana yazdırır ve imleci bir alt satıra geçirir.
            // Console.Write(), metodu yazmak istediğimiz yazıyı ekrana yazdırır ve imleci yazının yanında bekletir.

            // Eğer yukarıdaki metotları yazdıktan sonra Console.ReadLine() metodunu kullanmazsak konsol ekranını göremeyiz.
            // Console.ReadLine() metodu kullanıcıdan bir değer bekler ve o değeri bir değişkene ya da boşluğa iletir.
            // Kullanıcıdan değer beklerken kullanıcının konsol ekranını görmesini sağlar.

            Console.ReadLine();
        }
    }
}
