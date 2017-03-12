using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szachy.Figury
{
    class Pion : Figura
    {
        public Pion(Pozycja pozycja, string kolor) : base(pozycja, kolor)
        {
            this.pozycja = pozycja;
            this.kolor = kolor;
        }
        public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja);
        }
    }
}
