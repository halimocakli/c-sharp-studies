using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    abstract class Memeli
    {
        public double en;
        public double boy;

        public Memeli(double en, double boy)
        {
            this.en = en;
            this.boy = boy;
        }
    }
}
