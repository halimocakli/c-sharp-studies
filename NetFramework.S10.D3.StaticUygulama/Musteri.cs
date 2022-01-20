using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevUygulama
{
    public class Musteri
    {
        #region Sanal Database

        // Hatırlatma : ArrayList, kendisine gelen değerleri Object türüne dönüştürerek saklar.
        // Aşağıda oluşturulan musteriDatabase kolleksiyonuna eklenen değerlerin tamamı Musteri sınıfı türünden olacak.
        // Musteri sınıfı türünden değerler kolleksiyona eklenirken Object türüne dönüştürülecek.
        private static ArrayList musteriDatabase;

        #endregion

        // Eğer musteriDatabase ArrayList'ini static yapıcı metot içerisinde new anahtar kelimesi ile örneklemezsem ilk değer olarak "null" alır.
        // Static yapıcı metot kullanmamızın sebebi uygulama içerisinde ilgili nesne çağırılıdığında bir kere çalışmasıdır. Eğer standart yapıcı metot ile
        // işlem yapsaydık her nesne örneklenmesinde kolleksiyonumuz yeniden örneklenecekti ve elimizdeki verileri kaybedecektik.

        #region Static Yapıcı Metot
        // Müşteriyi ilk çağırdığımız anda static yapıcı metodumuz çalışsın ve kolleksiyonumuz new ile örneklenerek yeni kayıt almaya hazır halde beklesin

        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }

        #endregion

        #region Field

        public int MusteriID { get; set; }
        public string Isim { get; set; }
        public string soyisim { get; set; }
        public string sifre { get; set; }

        #endregion

        #region Property -Kapsülleme-

        private string _emailAdres;
        private string _kullaniciAdi;

        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; }
            set
            {
                // Kullanıcı adını alırken bu kısımda kontrol edeceğiz.
                bool kullaniciAdiKontrol = musteriKullaniciAdıKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }

        public string EMailAdres
        {
            get { return this._emailAdres; }
            set
            {
                // Email adresini alırken bu kısımda kontrol edeceğiz.
                bool eMailAdresKontrol = musteriEmailAdresKontrol(value);
                if (eMailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz email adresi sistem içerisinde kayıtlı");
                    this._emailAdres = string.Empty;
                }
                else
                {
                    this._emailAdres = value;
                }
            }
        }

        #endregion

        #region Static Metotlar

        static public void MusteriEkle(Musteri parametreNesneM)
        {
            #region Parametre Kontrol (Program Sınıfından Gelen Değerler)

            if (parametreNesneM != null && !string.IsNullOrEmpty(parametreNesneM._kullaniciAdi) && !string.IsNullOrEmpty(parametreNesneM._emailAdres))
            {
                // Yani yukarıda kullanıcı adı kontrolü yapılmış ve nesne elemanı eklenmiş
                bool eMailAdresKontrol = musteriEmailAdresKontrol(parametreNesneM._emailAdres);
                if (eMailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    musteriDatabase.Add(parametreNesneM);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }

            #endregion
        }

        static private bool musteriKullaniciAdıKontrol(string parametreKullaniciAdi)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                // Girilen kullanıcı adı değeri sanal database içerisinde mevcut mu kontrolü yapacağız.
                // Daha önce Musteri sınıfı türünden değerleri Object türüne dönüştürerek kolleksiyon içerisinde saklamıştık.
                // Şimdi ise bu değerleri kontrol edebilmek için tekrar Musteri sınıfı türünden bir nesneye dönüştürüyoruz.(Unboxing)
                // Bunun ana sebebi yukarıda tanımladığımız field'ların Musteri sınıf türünden olmasıdır. Bu fieldlara erişebilmek dönüştürme işlemi yaptık.

                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.KullaniciAdi == parametreKullaniciAdi)
                {
                    Kontrol = true;
                    break;
                    // Parametre olarak gönderilen kullanıcı adı daha önce girilmiş ya da halihazırda sanal database içerisinde mevcut
                }
            }

            return Kontrol;
        }

        static private bool musteriEmailAdresKontrol(string parametreEmailAdres)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                // Girilen email adresi sanal database içerisinde mevcut mu kontrolü yapacağız.
                // Daha önce Musteri sınıfı türünden değerleri Object türüne dönüştürerek kolleksiyon içerisinde saklamıştık.
                // Şimdi ise bu değerleri kontrol edebilmek için tekrar Musteri sınıfı türünden bir nesneye dönüştürüyoruz.(Unboxing)
                // Bunun ana sebebi yukarıda tanımladığımız field'ların Musteri sınıf türünden olmasıdır. Bu fieldlara erişebilmek dönüştürme işlemi yaptık.
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp._emailAdres == parametreEmailAdres)
                {
                    Kontrol = true;
                    break;
                    // Parametre olarak gönderilen email adresi daha önce girilmiş ya da halihazırda sanal database içerisinde mevcut
                }
            }

            return Kontrol;
        }

        #endregion

    }
}
