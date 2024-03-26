using APBD2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2.Klasy
{
    internal class KontenerChlodniczy(String typ, int temperatura, int wagaWlasna, int maxLadownosc, int wysokosc, int glebokosc) : Kontener(wagaWlasna, maxLadownosc, wysokosc, glebokosc, "C")
    {
        public String Typ { get; } = typ;
        public int Temperatura { get; } = temperatura;
    }
}
