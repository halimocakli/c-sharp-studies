using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.AbstractClassOrnek
{
    abstract class Sekil
    {
        protected int mBoy;
        protected int mEn;

        public Sekil(int boy, int en)
        {
            this.mBoy = boy;
            this.mEn = en;
        }

        abstract public int Boy
        {
            get;
            set;
        }

        abstract public int En
        {
            get;
            set;
        }

        abstract public int Alan();
        abstract public void EkranaYaz();
    }

    class Dortgen : Sekil
    {
        private bool mKaremi;

        public Dortgen(int boy, int en) : base(boy, en)
        {
            KareKontrol();
        }

        public bool Karemi
        {
            get { return mKaremi; }
        }

        override public int Boy
        {
            get { return mBoy; }
            set
            {
                mBoy = value;
                KareKontrol();
            }
        }

        override public int En
        {
            get { return mEn; }
            set
            {
                mEn = value;
                KareKontrol();
            }
        }

        private void KareKontrol()
        {
            if (mBoy == mEn)
            {
                mKaremi = true;
            }
            else
            {
                mKaremi = false;
            }
        }

        override public int Alan()
        {
            return mEn * mBoy;
        }

        override public void EkranaYaz()
        {
            Console.WriteLine("Dörtgenin Eni: " + mEn);
            Console.WriteLine("Dörtgenin Boyu: " + mBoy);
            Console.WriteLine("Karemi mi?: " + (mKaremi ? "Evet" : "Hayır"));
            Console.WriteLine("Dörtgenin Alanı: " + Alan());
            Console.WriteLine();
        }
    }

    class Ucgen : Sekil
    {
        private string UcgenTipi;

        public Ucgen(string Tur, int boy, int en) : base(boy, en)
        {
            UcgenTipi = Tur;
        }

        override public int Boy
        {
            get { return mBoy; }
            set
            {
                mBoy = value;
            }
        }

        override public int En
        {
            get { return mEn; }
            set
            {
                mEn = value;
            }
        }

        override public int Alan()
        {
            return (mBoy * mEn) / 2;
        }

        override public void EkranaYaz()
        {
            Console.WriteLine("Üçgenin Eni: " + mEn);
            Console.WriteLine("Üçgenin Boyu: " + mBoy);
            Console.WriteLine("Üçgenin Tipi: " + UcgenTipi);
            Console.WriteLine("Dörtgenin Alanı: " + Alan());
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sekil[] sekil = new Sekil[3];

            sekil[0] = new Ucgen("Eşkenar", 6, 5);
            sekil[1] = new Dortgen(6, 5);
            sekil[2] = new Dortgen(4, 4);

            foreach (Sekil VARIABLE in sekil)
            {
                VARIABLE.EkranaYaz();
            }

            Console.ReadLine();
        }
    }
}
