using System;

class BiggerNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int maxAB = GetMax(a, b);
        Console.WriteLine(maxAB);
    }

    public static int GetMax(int a, int b)
    {
        int max = a > b ? a : b;
        return max;
    }
}

