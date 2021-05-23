using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class Musteri
    {
        #region Tekil Olarak Kullanılan Fieldlar

        public int MusteriID { get; set; }
        public string TcKimlikNo { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public DateTime OlusturmaTarih { get; set; }
        public int KullaniciID { get; set; }

        #endregion

        #region Inner Type Gerektiren Fieldlar

        // Aşağıdaki propertyler incelendiğinde anlarız ki bu bilgileri MusteriAdres sınıfı türünden bir nesnede tutmak daha mantıklıdır.
        // Dolayısıyla aşağıdaki propertyler MusteriAdres sınıfı içerisine kopyalanır.

        /*
         * public string adresTip { get; set; }
         * public string Il { get; set; }
         * public string Ilce { get; set; }
         * public string Adres { get; set; }
         */

        #endregion

        #region MusteriAdres - MusteriIletisimBilgisi - MustesiSiparisBilgisi - Urun Sınıflarını Musteri Sınıfına Tanıtmak

        public MusteriAdres[] MusteriAdresleri;    // MusteriAdres türünde bir dizi oluşturarak Musteri nesnesi içerisinde MusteriAdres sınıfı fieldlarını barındırmaya başladık
        public MusteriIletisimBilgisi[] MusteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] MusteriSiparisBilgileri;

        #endregion

        public Musteri()
        {
            // Bu yapıcı metot ile sisteme bütün Inner Typelarımızı tanıtıyoruz. Böylece Musteri türünden nesne örneklerken aşağıdaki kolleksiyonlar "null" atanmayacak ve referans hatası almayacak.
            // Diyelim ki aşağıdaki kolleksiyonlardan birinin boyutunu değiştirmek istedim. Bu yapıcı metot içerisinde tek seferde halledebilirim.
            // Ancak Program sınıfı içerisinde de belirttiğimiz üzere diğer yöntem Refactoring ve diğer düzeltmelerde bize çok zaman kaybettirir.
            MusteriAdresleri = new MusteriAdres[5];
            MusteriIletisimBilgileri = new MusteriIletisimBilgisi[3];
            MusteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }

    }
}
