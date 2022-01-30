using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    public class Kedi : Memeli
    {
        public string Turu;

        public Kedi(string turu, int boy, int agirlik) : base(boy, agirlik)
        {
            this.Turu = turu;
        }

        public override void Konus()
        {
            Console.WriteLine("Ben bir kediyim!");
        }
    }
}
