using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir
{
    public class GenericRepository<T> where T : class // Gelen T tipi Class olamalı
    {
        public GenericRepository()
        {
            // Context : Entity Framework - DBFirst
        }

        public virtual List<T> Getir()
        {
            // Gelen T tipini database üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic kolleksiyon olacak şekilde bir üst katmana dönmek.
            return null;
        }

        public virtual void yeniKayitEkle(T data)
        {
            // Bize gelen T tipi içerisindeki bilgiyi T tipinin işaret etmiş olduğu tabloya ekliyoruz.
        }
    }
}
