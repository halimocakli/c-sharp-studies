using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace NetFramework.S09.D1.KapsullemeNedir
{
    internal class Musteri
    {
        private int id;
        private string emailAdres;
        public string isim;
        private string _soyisim;

        public Musteri()
        {
            this.id = IDUret();
        }

        private int IDUret()
        {
            Random Rnd = new Random();
            return Rnd.Next(10000, 90000);
        }

        public string SoyIsim
        {
            get
            {
                return this._soyisim;
            }
            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@gmail.com", isim, _soyisim);
            }
        }

        public string EmailAdres
        {
            // get; => Database veya farklı bir veri kaynağından datayı çektiğimizi düşünün. Class'ı çağıran programcı çekilen datayı almak için "get" metodunu kullanır.
            // set; => Dış dünyadan alınan datanın içerisinde private olarak bulunan field içerisine değer ataması yapmak için "set" metodu kullanılır. 

            private set
            {
                this.emailAdres = value;
            }
            get
            {
                return this.emailAdres;
            }
        }

        public int ID
        {
            private set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        // ARA ÖDEV

        private string _tckimliknumarasi = "78895436652";

        public string TCKimlikNumarasi
        {
            get
            {
                return _tckimliknumarasi.Substring(0, 3);
            }
            private set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            // Karakterlerin hepsi sayısal değer
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("TC Kimlik Numarası değerlerinin tamamı sayısal olmalıdır.");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 haneli olmalıdır.");
                }
            }
        }

    }
}
