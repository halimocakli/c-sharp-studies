using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    public class Ogrenci
    {
        public string Isim { get; set; }
        public string Soyiisim { get; set; }
        public string EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metottur.");
            
            // Static olmayan metotlar static metotları çağrılabilir.
            Test2();
            // Tersi durum geçerli değildir. Çünkü Static olmayan metotların metot olarak kullanılmasından önce örneklenmiş olmaları gereklidir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği ALINMADAN kullanılabilir.");
        }
    }
}
