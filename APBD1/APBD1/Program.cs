Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, User!");
Console.WriteLine("Hello, User2");
Console.WriteLine("Hello, User3");

static double Avg(int[] liczby)
{
    double avggg = 0;
    foreach (int i in liczby)
    {
        avggg += (double)i;
    }
    return avggg / liczby.Length;
}

static int Max(int[] liczby)
{
    int max = liczby[0];
    foreach (int i in liczby)
    {
        if (max < i)
        {
            max = i;
        }
    }
    return max;
}
