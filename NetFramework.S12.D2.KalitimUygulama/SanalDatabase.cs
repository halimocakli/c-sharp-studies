using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    public static class SanalDatabase
    {
        private static ArrayList DB = new ArrayList();

        public static void YeniUrunEkle(BaseClass data)
        {
            // Metot argümanı olarak BaseClass türünden data nesnesini aldık. Böylece BaseClass sınıfından türeyen tüm sınıflar türünden nesne bu metoda parametre gönderebilecek.

            if (data != null && !string.IsNullOrEmpty(data.Barkod))
            {
                DB.Add(data);
            }
        }

        public static bool DbBarkodKontrol(string barkod)
        {
            bool kontrolIslemi = false;
            if (DB != null && DB.Count > 0) // 
            {
                for (int i = 0; i < DB.Count; i++)
                {
                    // Liste elemanlarına ulaşma konusunu işlerken değindiğimiz gibi, listeler, içine aldıkları elemanları object türüne dönüştürür.
                    // Dolayısıyla liste elemanlarına ulaşma işlemi yaparken liste içindeki elemanları dışarı çıkartmak için unboxing yapılır.
                    // DB[i] içerisinde object türüyle tutulan B1 - B2 - B3 nesneleri (Program.cs'e bakın) BaseClass türüne dönüştürülerek erişim sağlanıyor. 
                    BaseClass BC = (BaseClass)DB[i];

                    if (BC.Barkod == barkod)
                    {
                        kontrolIslemi = true;
                    }
                }
            }

            return kontrolIslemi;
        }
    }
}
