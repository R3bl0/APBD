using APBD2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2.Klasy
{
    public class Kontenerowiec
    {
        public static List<Kontenerowiec> listaKontenerowcow = new List<Kontenerowiec>();
        public List<Kontener> kontenery = new List<Kontener>();
        private static int id_next = 0;
        public int Id { get; private set; }
        public int Predkosc { get; }
        public int MaxLiczbaKontenerow { get; } 
        public int MaxWagaKontenerow { get; }
        
        public Kontenerowiec(int predkosc, int maxLiczbaKontenerow, int maxWagaKontenerow)
        {
            Id = id_next++;
            Predkosc = predkosc;
            MaxLiczbaKontenerow = maxLiczbaKontenerow;
            MaxWagaKontenerow = maxWagaKontenerow;
            listaKontenerowcow.Add(this);
        }
        public void Zaladowanie(Kontener kontener)
        {
            kontenery.Add(kontener);
        }

        public void Zaladowanie(List<Kontener> lista)
        {
            foreach (var kontener in lista) Zaladowanie(kontener);
        }

        public void ZaladowanieKontenera(int idKontenera, int waga)
        {
            kontenery[idKontenera].Zaladunek(waga);
        }

        public void StworzenieKontenera(int typ)
        {
            int waga;
            int max;
            int wysokosc;
            int glebokosc;

            switch (typ)
            {
                case 1:
                    Console.WriteLine("Podaj parametry kontenera na płyny: czy ładunek jest niebezpieczny, waga własna, maksymalna ładowność, wysokość, głębokość");
                    bool czyNiebezpieczny = Convert.ToBoolean(Console.ReadLine());
                    waga = Convert.ToInt32(Console.ReadLine());
                    max = Convert.ToInt32(Console.ReadLine());
                    wysokosc = Convert.ToInt32(Console.ReadLine());
                    glebokosc = Convert.ToInt32(Console.ReadLine());
                    Kontener kontener1 = new KontenerPłyny(czyNiebezpieczny, waga, max, wysokosc,glebokosc);
                    kontenery.Add(kontener1);
                    break;
                case 2:
                    Console.WriteLine("Podaj parametry kontenera na płyny: cisnienie, waga własna, maksymalna ładowność, wysokość, głębokość");
                    int cisnienie = Convert.ToInt32(Console.ReadLine());
                    waga = Convert.ToInt32(Console.ReadLine());
                    max = Convert.ToInt32(Console.ReadLine());
                    wysokosc = Convert.ToInt32(Console.ReadLine());
                    glebokosc = Convert.ToInt32(Console.ReadLine());
                    Kontener kontener2 = new KontenerGaz(cisnienie, waga, max, wysokosc, glebokosc);
                    kontenery.Add(kontener2);
                    break;
                case 3:
                    Console.WriteLine("Podaj parametry kontenera na płyny: typ produktu, temperatura, waga własna, maksymalna ładowność, wysokość, głębokość");
                    String typ_produktu = Console.ReadLine();
                    int temperatura = Convert.ToInt32(Console.ReadLine());
                    waga = Convert.ToInt32(Console.ReadLine());
                    max = Convert.ToInt32(Console.ReadLine());
                    wysokosc = Convert.ToInt32(Console.ReadLine());
                    glebokosc = Convert.ToInt32(Console.ReadLine());
                    Kontener kontener3 = new KontenerChlodniczy(typ_produktu, temperatura, waga, max, wysokosc, glebokosc);
                    kontenery.Add(kontener3);
                    break;
                default:
                    Console.WriteLine("Blad wyboru");
                    break;
            }
        }

        public void Rozladowanie(int id)
        {
            kontenery.RemoveAt(id);
        }

        public void Zastap(int id, Kontener kontener)
        {
            kontenery[id] = kontener;
        }

        public void Przenies(Kontenerowiec kontenerowiec, int idKonteneru)
        {
            kontenerowiec.Zaladowanie(kontenery[idKonteneru]);
            Rozladowanie(idKonteneru);
        }

        public void DaneLadunek()
        {
            Console.WriteLine("Ładunek:");
            if (kontenery.Count == 0)
            {
                Console.WriteLine("Brak");
            }else foreach (var i in kontenery) Console.WriteLine(i.ToString());
        }

        public void DaneKontenerowce()
        {
            Console.WriteLine("Lista kontenerowców: ");
            if (listaKontenerowcow.Count == 0)
            {
                Console.WriteLine("Brak");
            }
            else foreach (var i in kontenery) Console.WriteLine(i.ToString());
        }

        public override string ToString()
        {
            return $"Statek {Id} (predkosc: {Predkosc} wezlow, Max liczba kontenerow: {MaxLiczbaKontenerow}, Max waga kontenerow: {MaxWagaKontenerow} ton, Aktualna liczba kontenerow: {kontenery.Count})";
        }
    }
}
