using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class Urun
    {
        public int urunID { get; set; }
        public string urunTanim { get; set; }
        public decimal urunFiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun yapıcı metodu çalıştı...");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
