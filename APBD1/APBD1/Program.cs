Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, User!");
Console.WriteLine("Hello, User2");
Console.WriteLine("Hello, User3");

static double Avg(int[] liczby)
{
    double avg = 0;
    foreach (int i in liczby)
    {
        avg += (double)liczby[i];
    }
    return avg / liczby.Length;
}
