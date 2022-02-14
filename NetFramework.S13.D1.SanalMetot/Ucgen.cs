
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    public class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {
        }

        public override double Alan()
        {
            return (En * Boy) / 2;
        }
    }
}
