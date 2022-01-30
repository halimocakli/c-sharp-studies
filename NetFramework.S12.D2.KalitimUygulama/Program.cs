using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Urun sınıfı BaseClass sınıfından türedi.
             * Televizyon ve Bilgisayar sınıfları Urun sınıfından türedi.
             * Bilgisayar ve Televizyon sınıfları Sealed anahtar sözcüğü ile işaretlenip kalıtımları durduruldu.
             *
             * Urun sınıfı içerisinde bulunan AlisFiyat, SatisFiyat ve KapmanyaFiyat fieldları için propertyler düzenlenerek belli şartlara bağlandı.
             *
             * Bir SanalDatabase sınıfı oluşturuldu ve aşağıda nesne üzerinden atadığımız field değerleri yine nesne üzerinden Liste içerisine aktarıldı.
             * BaseClass sınıfı içerisinde Barkod fieldı için bir property oluşturulup giriş kontrolü sağlandı. Bunu yaparken yine SanalDatabase sınıfına ulaştık, inceleyin.
             */

            Bilgisayar B1 = new Bilgisayar();
            // B1.ID = 1; => BaseClass içindeki propertyde set anahtar sözcüğü private ile işaretlendiği için burada atama yapılamaz.
            B1.Marka = "Dell";
            B1.Model = "G315";
            B1.Islemci = "Intel Core i7 - 9th Gen";
            B1.AlisFiyat = 1000M;
            B1.SatisFiyat = 1500M;
            B1.KapmanyaFiyat = 1200M;
            B1.Barkod = "1234567890";

            SanalDatabase.YeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();
            // B2.ID = 2; => BaseClass içindeki propertyde set anahtar sözcüğü private ile işaretlendiği için burada atama yapılamaz.
            B2.Marka = "Dell";
            B2.Model = "G315";
            B2.Islemci = "Intel Core i7 - 9th Gen";
            B2.AlisFiyat = 1000M;
            B2.SatisFiyat = 1500M;
            B2.KapmanyaFiyat = 1200M;
            B2.Barkod = "1234567890";   // Uyarı alacağız

            SanalDatabase.YeniUrunEkle(B2);

            Bilgisayar B3 = new Bilgisayar();
            // B3.ID = 3; => BaseClass içindeki propertyde set anahtar sözcüğü private ile işaretlendiği için burada atama yapılamaz.
            B3.Marka = "Dell";
            B3.Model = "G315";
            B3.Islemci = "Intel Core i7 - 9th Gen";
            B3.AlisFiyat = 1000M;
            B3.SatisFiyat = 1500M;
            B3.KapmanyaFiyat = 1200M;
            B3.Barkod = "1234567890";
        }
    }
}
