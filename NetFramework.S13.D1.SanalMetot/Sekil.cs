using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    public class Sekil
    {
        public double Boy;
        public double En;

        public Sekil(double boy, double en)
        {
            this.Boy = boy;
            this.En = en;
        }

        public virtual double Alan()
        {
            return 0;

        }
    }
}
