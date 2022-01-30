using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    public sealed class Televizyon : Urun
    {
        public bool SmartTV { get; set; }
        public bool HDMI { get; set; }
        public string EkranBoyutu { get; set; }
    }
}
