using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szachy.Figury
{
    class Krolowa : Figura
    {
        public Krolowa(Pozycja pozycja, string kolor)
            : base(pozycja, kolor)
        {
            this.pozycja = pozycja;
            this.kolor = kolor;
        }
        public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) || CzySkos(nowaPozycja);
        }
    }
}
