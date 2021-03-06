﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szachy.Figury
{
    class Figura
    {
        protected Pozycja pozycja = null;
        protected Pozycja Pozycja
        {
            get
            {
                return pozycja;
            }
        }
        public event EventHandler PrzesunietoFigure;
        public string kolor;
        protected bool CzyPionowo(Pozycja nowaPozycja)
        {
            return Pozycja.Y == nowaPozycja.Y;
            PrzesunietoFigure;
        }
        protected bool CzyPoziomo(Pozycja nowaPozycja)
        {
            return Pozycja.X == nowaPozycja.X;
            PrzesunietoFigure;
        }
        protected bool CzySkos(Pozycja nowaPozycja)
        {
            return Math.Abs(Pozycja.Y - nowaPozycja.Y) == Math.Abs(Pozycja.X - nowaPozycja.X);
            PrzesunietoFigure;
        }
        public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) || CzySkos(nowaPozycja);
        }
        public Figura(Pozycja pozycja, string kolor)
        {
            this.pozycja = pozycja;
            this.kolor = kolor;
        }

    }
}
