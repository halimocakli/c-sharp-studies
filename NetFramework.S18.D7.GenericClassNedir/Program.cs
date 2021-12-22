using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             * Database  |  Uygulama
             * MSSQL           C#
             *
             * tblMusteri
             * ----------
             * id -> int
             * musteriNumarasi -> Unique Identifier => (GUID)
             * isim            -> nvarchar(50)      => string
             * soyisim         -> nvarchar(50)      => string
             * dogumTarih      -> datetime          => datetime
             *
             * Tasarım deseni olarak UnitOfWorks kullanıyorsak => Generic Class / Generic Interface
             *
             */

            GenericRepository<Musteri> repositoryMusteri = new GenericRepository<Musteri>();
            List<Musteri> musterilerim = repositoryMusteri.Getir();
            repositoryMusteri.yeniKayitEkle(null);

            GenericRepository<Urun> repositoryUrun = new GenericRepository<Urun>();
            repositoryUrun.Getir();
            repositoryUrun.yeniKayitEkle(null);
        }
    }
}
