using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public class Personel
    {
        public static string domainAdres;

        public string Isim { get; set; }

        public string Soyisim { get; set; }

        private string _emailadres;

        public string Emailadres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }

        public int cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her örneklemede çalışan metot [standart yapıcı metot]");
        }

        // Static yapıcı metotlar private olarak tanımlanmalıdır.
        static Personel()
        {
            domainAdres = "firmam.com";
        }
    }
}
