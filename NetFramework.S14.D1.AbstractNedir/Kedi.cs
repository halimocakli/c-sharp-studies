using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    class Kedi : Memeli
    {
        private string Turu;

        public Kedi(string turu, double en, double boy) : base(en, boy)
        {
            this.Turu = turu;
        }
    }
}
