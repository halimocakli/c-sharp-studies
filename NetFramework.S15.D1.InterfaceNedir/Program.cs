using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cengiz Atilla - Interface Teori

            /*
             * Yazım standardı gereği Interfaceler "I" ile başlar.
             * 
             * Abstract ile Interface arasındaki fark => Interface tamamen şablon içeriğe sahiptir.
             * Abstract sınıfın örneklenemediğini hatırlıyoruz. Ancak yine hatırlıyoruz ki Abstract sınıfın içerisinde standart metot oluşturma hakkına da sahiptik.
             * Interface'te bu durum geçerli değildir çünkü Interface içerisindeki bütün tanımlar şablondur, kuraldır, kontrattır!!!
             * Dolayısıyla Interface içerisinde yapıcı metot tanımlanamaz ve dolayısıyla Interface hiçbir şekilde örneklenemez.
             * Abstract sınıf örneklenemese bile kendisinden kalıtılan sınıflar üzeriden nesne örneklemesi yapılabilir ve bu nesneler üzerinden
             abstract sınıfın standart metotları kullanılabilirdi. Ayrıca abstract metotlar da override edilerek katılıtılmış sınıflar üzerinden kullanılabiliyordu.
             *
             * Interface içerisinde metot body'si oluşturulamaz. Gerçek hayatta Abstract'tan daha çok tercih edilirler ve "Tasarım Desenleri"nde kullanılırlar.
             * Interface'ler içerisinde değişken tanımı yapamayız.
             * Interface içerisindeki field ve metotlar için erişim belirleyicisi kullanmak yanlıştır.
             * Kendi başımıza bir uygulama geliştirirken olmazsa olmaz değil ancak ekip ile iş yaparken oldukça gerekli.
             */

            // Peki bir Interface içerisinde neler olur?
            // Field tanımları
            // Metot tanımları
            // Delegate
            // Vb.

            #endregion  
        }
    }
}
