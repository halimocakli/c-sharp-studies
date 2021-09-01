using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D2.InterfaceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir e-mail gönderme programı hazırladık ancak bu program Interfaces konusunun kapsamlı bir şekilde
             * incelebilmesi ve anlaşılması için tamamamen basitleştirildi. Dolayısıyla metotlarımız e-mail göndermek
             * yerine bu işlemi simüle edecekler.
             */

            List<IProductModel> sanalSepet = OrnekVeriEkle();
            CustomerModel musteri = MusteriUret();

            // Ürünlerin sevki için liste içerisindeki bürün ürünler UrunSevk metoduna gönderiliyor
            foreach (IProductModel urun in sanalSepet)
            {
                urun.UrunSevk(musteri);

                // Eğer foreach döngüsü içerisinde incelediğimiz ürünlerden birinin türü DigitalProduct ise aşağıdaki kod bloğu çalışsın
                if (urun is IDigitalProductModel digital)
                {
                    /*
                     * Bu "if" bloğunda DigitalProduct class'ına implement ettiğimiz IDigitalProductModel Interface'ine neden IProductModel Interface'ini 
                     * implement ettiğimizin sebebini öğrenelim. GeriyeKalanIndirmeler property'si IProductModel interface'inde bulunmaz, ancak IDigitalProductModel
                     * inteface'inde mevcuttur. IDigitalProduct interface'i DigitalProduct sınıfına implement edilmiştir. Dolayısıyla GeriyeKalanIndirmeler property'si
                     * DigitalProduct sınıfında mevcuttur. Bu noktada eğer IProductModel interface türüne sahip urun değişkeni üzerinden GeriyeKalanIndirmeler property'sine
                     * ulaşmak istiyorsak IDigitalProductModel interface'ine IProductModel interface'ini implement etmemiz gerekir. Yani;
                     *
                     * 1- GeriyeKalanIndirmeler Property'si IDigitalProductModel Interface içinde mevcuttur
                     * 2- IDigitalProductModel Interface'i, DigitalProduct Class'ına implement edilmiştir
                     * 3- Dolayısıyla GeriyeKalanIndirmeler Property'si DigitalProduct sınıfı içerisinde uygulanır
                     * 4- DigitalProduct Class'ı IProductModel Interface'i içinde bulunan değerlere de sahiptir
                     * 5- Dolayısıyla DigitalProduct Class'ına hem IDigitalProductModel hem de IProductModel Interface'leri implement etmek mantıklıdır
                     * 6- Ancak her iki Interface'i de DigitalProduct Class'ına implement edersek IProductModel üzerinden IDigitalProductModel değerlerine ulaşamayız
                     * 7- Bu durum da bize dar kapsamlı bir uygulama alanı sunar ve bizi kısıtlar
                     * 8- Bu nedenle eğer şu şekilde bir implementasyon yaparsak IProductModel türünden bir değişken üzerinden
                     * DigitalProduct Class değerlerine IDigitalProductModel Interface'i üzerinden de geçerek(onu kullanarak) ulaşabiliriz:
                     *
                     *      => public class DigitalProduct : IDigitalProductModel           ===> Class'a Interface implement ediliyor
                     *      => public interface IDigitalProductModel : IProductModel        ===> Interface'e Interface implement ediliyor
                     *
                     * 9- Eğer IDigitalProductModel ve IProductModel Interface'leri direkt olarak DigitalProduct Class'ına implement edilmiş olsaydı ve
                     * IProductModel Interface'i IDigitalProductModel Interface'ine implement edilmemiş olsaydı aşağıdaki kodda "digital.UrunAdi"
                     * ifadesinden hata alacaktık çünkü UrunAdi bir IProductModel Interface'i değeridir ve IDigitalProductModel Interface'ine
                     * IProductModel Interface'i implement edilmediği için UrunAdi değerine IDigitalProductModel Interface'i üzerinden ulaşamayacaktık.
                     *
                     * 10- Sonuç olarak tüm bu uygulamalar sayesinde daha geniş kullanımlı bir yöntem elde etmiş olduk.
                     */

                    Console.WriteLine($"{digital.UrunAdi} için geriye {digital.GeriyeKalanIndirmeler} indirme kaldı.");
                }
            }

            Console.ReadLine();
        }

        // Geriye CustomerModel sınıfı türünden bir nesne döndüren ve bir müşteri yaratan metot
        private static CustomerModel MusteriUret()
        {
            return new CustomerModel()
            {
                Isim = "Halim Can",
                SoyIsim = "Ocaklı",
                Sehir = "İstanbul",
                EmailAdres = "halimcanocakli@gmail.com",
                TelefonNumarasi = "00000000000"
            };
        }

        // Alışveriş sepetine üç farklı ürün ekleyen ve geriye liste döndüren metot
        private static List<IProductModel> OrnekVeriEkle()
        {
            // Eklediğimiz ürünleri tutacak bir liste nesnesi oluşturuluyor
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { UrunAdi = "Kulaklık" });
            output.Add(new PhysicalProductModel { UrunAdi = "Gömlek" });
            output.Add(new PhysicalProductModel { UrunAdi = "USB Bellek" });
            output.Add(new DigitalProduct { UrunAdi = "Windows 10 Lisans Anahtarı" });
            output.Add(new CourseProductModel { UrunAdi = "C# Advanced Programming" });

            return output;
        }
    }
}