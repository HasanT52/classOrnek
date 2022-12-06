using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classOrnek
{
    internal class ucgen
    {
        private int taban;
        private int yukseklik;


        public int Taban
        {
            get { return taban; }
            set { taban = value; }
        }

        public int Yukseklik
        {
            get { return yukseklik;}
            set { yukseklik = value;}   
        }

        public int alanHesapla()
        {
            int alan = (Taban * Yukseklik) / 2;
            return alan;
        }

        public ucgen()
        {
            
        }

        public ucgen(int yukseklik)
        {
            this.yukseklik =yukseklik;
        }

        public ucgen(int yukseklik, int taban)
        {
            this.yukseklik = yukseklik;
            this.taban = taban;
        }


    }
}
