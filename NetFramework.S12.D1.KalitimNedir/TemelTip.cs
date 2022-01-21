using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class TemelTip
    {
        // Türeyen nesneden türetilen nesne içerisinde oluşturulan nesneye erişilemez. Kalıtım tek yönlüdür. Yani bizim uygulamamızda TemelTip nesnesinden diğer nesnelerin değerlerine erişemem.
        // Personel - Egitmen - Ogrenci tabloları/sınıfları içerisinde bulunan ortak fieldlarımızı bu class içerisinde barındıracağız

        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyIsim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public bool silindi { get; set; }

        // TemelTip sınıfını yukarıda bahsi geçen her üç sınıfa da entegre etmemiz gerekli

        public TemelTip()
        {
            Console.WriteLine("TemelTip nesnesinin yapıcı metodu çalıştı");
            IdAtamaIslemi();
        }

        private void IdAtamaIslemi()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 9000);
            // Metodu yapıcı metot içerisinde çağırmayı unutmayın. Çağırılmamış metot yazılmamış metottur.
        }

        public void TemelTipMetot1()
        {
            Console.WriteLine("TemelTip => Metot 1");
            // TemelTipMetot2(); => Protected erişim belirleyicisi normal şartlarda/class içerisinde Private gibi davranırken içinde bulunduğu classın metotları tarafından çağırılabilir.
        }

        protected void TemelTipMetot2()
        {
            Console.WriteLine("TemelTip nesnesi içerisindeki Protected metot.");
        }
    }
}
