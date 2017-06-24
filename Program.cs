using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szachy.Figury;

namespace szachy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p, Kolor.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));
            PrzesunietoFigure=InfoOPresunieciu;
            szachownica.IleFigur();
        }
        
        static void InfoOPrzesunieciu()
        {
            Console.Writeline('Przesunięto figurę");
        }

        sealed class Toolbox {
            private static SomeOtherClass Szachownica = new SomeOtherClass1();
            private Toolbox() {
            }
            static Toolbox() {
            }
            public static SomeOtherClass SomeOtherClass1Instance {
                get {
                return Szachownica;
                }
            }
        }        public abstract class Figura {
            public static Figura FiguraFactory(String figuraType) {
                switch (figuraType) {
                    case "Goniec":
                    return new GoniecFigura();
                    case "Pion":
                    return new PionFigura();
                    case "Krol":
                    return new KrolFigura();
                    case "Krolowa":
                    return new KrolowaFigura();
                    default:
                    break;
                }
            throw new System.NotSupportedException("The Figura type " + figuraType + " is not recognized.");
            }
        }
    }
}
