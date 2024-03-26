using APBD2.Interfejs;
using APBD2.Wyjatki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2.Classes
{
    public abstract class Kontener : IHazardNotifier
    {
        public static List<Kontener> listaKontenerow = new List<Kontener>();
        private static int id_next = 0;
        public int Id { get; private set; }
        public int MasaLadunku { get; protected set; }
        public int WagaWlasna { get; private set; }
        public int MaxLadownosc { get; private set; }
        public int Wysokosc { get; private set; }
        public int Glebokosc { get; private set; }
        public string NumerSeryjny { get; private set; }

        protected Kontener(int wagaWlasna, int maxLadownosc, int wysokosc, int glebokosc, string kod)
        {
            Id = id_next++;
            MasaLadunku = 0;
            WagaWlasna = wagaWlasna;
            MaxLadownosc = maxLadownosc;
            Wysokosc = wysokosc;
            Glebokosc = glebokosc;
            NumerSeryjny = "KON-" + kod +"-"+ Id;
            listaKontenerow.Add(this);
        }

        public override String ToString() 
        {
            return $"Numer seryjny: {NumerSeryjny}, wysokosc: {Wysokosc}, glebokosc: {Glebokosc}, waga wlasna: {WagaWlasna}, max ladownosc: {MaxLadownosc}, masa ladunku: {MasaLadunku}"; 
        }

        public void Rozladunek()
        {
            MasaLadunku = 0;
        }

        public void Zaladunek(int waga)
        {
            try
            {
                if (waga > MaxLadownosc)
                {
                    throw new OverfillException();
                }
                else MasaLadunku = waga;
            }catch (Exception e)
            {
                NotifyHazard();
            }
            
        }

        public void NotifyHazard()
        {
            Console.WriteLine($"Niebezpieczna sytuacja w kontenerze: {NumerSeryjny}");
        }
    }
}
