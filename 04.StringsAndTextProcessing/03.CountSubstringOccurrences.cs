using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();
        string subStr = Console.ReadLine().ToLower();
        int strLeng = str.Length;
        int count = 0;
        int index = str.IndexOf(subStr);
        while (index >= 0 & index < strLeng)
        {
            count++;
            index = str.IndexOf(subStr, index + 1);
        }
        Console.WriteLine(count);
    }
}

