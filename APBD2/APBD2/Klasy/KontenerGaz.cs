using APBD2.Classes;
using APBD2.Interfejs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2.Klasy
{
    public class KontenerGaz(int cisnienie, int wagaWlasna, int maxLadownosc, int wysokosc, int glebokosc) : Kontener(wagaWlasna, maxLadownosc, wysokosc, glebokosc, "G")
    {
        public int Cisnienie { get; }= cisnienie;

        public void Rozladunek()
        {
            MasaLadunku = (int)(MasaLadunku * 0.05);
        }
    }
}
