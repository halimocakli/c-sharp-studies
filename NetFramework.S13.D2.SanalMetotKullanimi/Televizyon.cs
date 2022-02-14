using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    public class Televizyon : Urun
    {
        public Televizyon()
        {
            Console.WriteLine("Televizyon - Yapıcı Metot");
        }

        /*
         * Televizyon nesnesinin üzerine breakpoint ekleyip debug yaptığımızda göreceğiz ki derleyicimiz kalıtım gereği önce şu sırayla yapıcı metotlara gidecek:
         * BaseClass => Urun => Televizyon -- Yani en temel nesneden Televizyon nesnesine doğru yol aldı. Dolayısıyla uygulama bu istikamette giderken
         * Virtual ve Override olarak işaretlenmiş EkranaYaz(); metotlarını görecek ve böylece Urun nesnesi içerisinde Override olarak işaretlenen EkranaYaz()
         * metodunu çalıştıracak
         */
    }
}
