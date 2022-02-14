using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    public class Memeli
    {
        public double Boy;
        public double Agirlik;

        public Memeli(double boy, double agirlik)
        {
            this.Boy = boy;
            this.Agirlik = agirlik;
        }

        public virtual void Konus()
        {
            Console.WriteLine("Ben konusamam");
        }
    }
}
