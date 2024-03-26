using APBD2.Interfejs;
using APBD2.Wyjatki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2.Classes
{
    public class KontenerPłyny(bool czyNiebezpieczny,int wagaWlasna, int maxLadownosc, int wysokosc, int glebokosc) : Kontener(wagaWlasna, maxLadownosc, wysokosc, glebokosc, "L")
    {
        public bool CzyNiebezpieczny { get; } = czyNiebezpieczny;
        
        public void Zaladunek(int waga)
        {
            try
            {
                if (czyNiebezpieczny)
                {
                    if (waga > MaxLadownosc / 2)
                    {
                        throw new OverfillException();
                    }
                    else MasaLadunku = waga;
                }
                else
                {
                    if (waga > MaxLadownosc * 0.9)
                    {
                        throw new OverfillException();
                    }
                    else MasaLadunku = waga;
                }
            }catch (Exception e)
            {
                NotifyHazard();
            }
            
        }
    }
}
