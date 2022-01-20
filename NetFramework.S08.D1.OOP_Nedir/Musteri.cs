using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S08.D1.OOP_Nedir
{
    class Musteri
    {
        // Yapıcı Metot "ctor"
        // ctor yazıp tab tuşuna basınca açılır.
        // Yapıcı metotlar field'ların default değerler almasını sağlar.
        // Biz yapıcı metoda aşağıdaki gibi müdahale edersek default değerini değiştirmiş oluruz.

        // Aşağıdaki yapıcı değişken ile direkt olarak TC numarası ilk değerini belirleriz.

        //public Musteri()
        //{
        //    TCkimlikNo = "1234567890";
        //}

        // Artık TCkimlikNo değişkeni null olarak atanmacak.
        // Bu işleme programlama dilinde ezmek denir. Var olan yapıyı değiştirerek onu ezeriz.

        // Program sınıfı üzerinden parametre göndererek değişkenlere ilk değer ataması yapmak için aşağıdaki yapıcı metotlar kullanılır.

        public Musteri()
        {
            // Normalde olduğu gibi default değerler derleyici tarafından verilir
        }

        public Musteri(string _TCkimlikNo)
        {
            TCkimlikNo = _TCkimlikNo;
        }

        public Musteri(string _TCkimlikNo, string _isim)
        {
            TCkimlikNo = _TCkimlikNo;
            isim = _isim;
        }

        public Musteri(string _TCkimlikNo, string _isim, string _soyIsim)
        {
            TCkimlikNo = _TCkimlikNo;
            isim = _isim;
            soyIsim = _soyIsim;
        }

        /* Musteri sınıfı içerisinde müşterilerimizin bazı bilgilerini tutmak isteriz.
         *
         * - TC Kimlik No
         * - İsim
         * - Soyisim
         * - Cinsiyet
         *
         * Bu bilgilere uygun değişkenler tanımlayarak bilgileri değişkenlerde tutabiliriz.
         */

        // Aşağıda değişken tanımlarken fark ettik ki tanımlanan değişkenlerin başına bir erişim belirleyicisi koymazsak derleyici default olarak "private" tercih eder.
        // Eğer değişkenlerimizi dış dünyaya açmak istemiyorsak ve yalnızca tanımlandığı sınıf içerisinde kullanmak istiyorsak aşağıdaki kullanım uygundur.

        /*
         * string TCkimlikNo;
         * string isim;
         * string soyİsim;
         * int cinsiyet;   // Bay : 717770001 - Bayan : 717770002
         */

        // Dolayısıyla aşağıdaki değişkenleri yalnızca tanımlandıkları sınıfın içerisinde kullanabiliriz. Biz erişebilmek için "public" erişim belirleyicisi kullanacağız.

        public string TCkimlikNo;
        public string isim;
        public string soyIsim;
        public int cinsiyet;   // Bay : 717770001 - Bayan : 717770002

        public bool MusteriKontrol()
        {
            // public metot içerisinde private metodu çağırarak dönen metodu döndürüyoruz.
            bool kontrol = MusteriKontrolDatabase(TCkimlikNo);
            return true;
        }

        private bool MusteriKontrolDatabase(string tckimlikNumarasi)
        {
            // Bu kısımda bizim dışımızda kimsenin ulaşmaması gereken database verileri var diyelim.
            // Mantık : Database'e gidilir. Müşterinin TC Kimlik numarası kontrol edilir ve daha önce kayıt edilip edilmediği bilgisi sorgulanır.
            return true;
        }

    }
}
