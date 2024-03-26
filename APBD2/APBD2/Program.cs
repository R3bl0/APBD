using APBD2.Classes;
using APBD2.Klasy;

internal class Program
{
    private static void Main(string[] args)
    {
        Kontenerowiec kontenerowiec = new Kontenerowiec(10, 20, 5);
        //kontenerowiec.StworzenieKontenera(1); //stworzenie kontenera danego typu i dodanie do na statek 1: na plyny 2: na gaz 3: chlodniczy
        Kontener k1 = new KontenerPłyny(false, 1, 1, 1, 1);
        k1.Zaladunek(1); // zaladowanie ladunku do kontenera
        kontenerowiec.Zaladowanie(k1); // zaladowanie kontenera na statek
        Kontener k2 = new KontenerGaz(2334, 1, 1, 1, 1);
        Kontener k3 = new KontenerChlodniczy("Banany", -11, 1, 1, 1, 1);
        List<Kontener> list = new List<Kontener>();
        list.Add(k2);
        list.Add(k3);
        kontenerowiec.Zaladowanie(list); //zaladowanie listy kontenerow na statek
        kontenerowiec.Rozladowanie(0);// usuniecie kontenera ze statku 
        k1.Rozladunek(); // rozladowanie kontenera
        Kontener k4 = new KontenerChlodniczy("Banany", -11, 34, 1, 1, 1);
        kontenerowiec.Zastap(0, k4); //zastapienie kontenera na statku o danym numerze innym kontenerem
        Kontenerowiec kontenerowiec2 = new Kontenerowiec(10, 20, 5);
        kontenerowiec.Przenies(kontenerowiec2, 1); // przeniesienie kontenera miedzy dwoma statkami
        Console.WriteLine(k1); // dane konteneru 
        Console.WriteLine(kontenerowiec); //dane kontenerowca
        kontenerowiec.DaneLadunek(); // dane ladunku kontenerowca
    }
}