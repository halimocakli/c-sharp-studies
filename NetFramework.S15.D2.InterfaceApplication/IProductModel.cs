using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    public interface IProductModel
    {
        string UrunAdi { get; set; }

        bool SiparisGerceklesmeKontrol { get; }

        void UrunSevk(CustomerModel iCustomer);
    }
}
