using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S01.D3.SabitTanimlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;

            sayi = 1001;    // sayi değişikeni const olmadığı için hata almayız

            const int ortakBolumDeger = 2;

            int sonuc = sayi / ortakBolumDeger;

            // ortakBolumDeger = 3;    //ortakBolumDeger değişkeni const deger olduğu için hata alırız.
        }
    }
}
