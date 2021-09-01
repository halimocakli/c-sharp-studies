using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    public class PhysicalProductBaseClass
    {
        // Bu sınıfı, Class Inheritence ve Interface Implementation farkını/ilişkisini ortaya koymak için oluşturduk

        /*
         * Eğer bir sınıfın başka bir sınıftan miras almasını ve aynı anda bu sınıfa Interface implement edilmesini istiyorsak
         * önce kalıtacak/miras bırakacak sınıf, sonra ise implement edilecek Interface ismi yazılır. Örnek olarak,
         *
         * public class PhysicalProductModel : PhysicalProductBaseClass, IProductModel
         * 
         * Bir sınıf yalnız ama yalnız bir başka sınıftan kalıtılabilirken birden çok interface bu aynı sınıfa implement edilebilir,
         * çünkü Interface'ler içinde diğer sınıflarda kullanılması icap eden metot, property vs'leri bulunduran kontratlardır.
         * Dolayısıyla aşağıdaki notasyonu kullanmak yanlış olacaktır:
         *
         * public class PhysicalProductModel : PhysicalProductBaseClass, DigitalProduct, CustomerModel IProductModel
         *
         * Aşağıdaki notasyon doğrudur:
         *
         * public class PhysicalProductModel : IProductModel, ISampleModel, ISampleModel2, ISampleModel3
         */
    }
}