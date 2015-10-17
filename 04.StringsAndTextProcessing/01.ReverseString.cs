using System;
using System.Collections.Generic;

class ReverseString
{
    static void Main()
    {
        string str = Console.ReadLine();
        int strLeng = str.Length;
        char[] reversedStr = new char[strLeng];
        int count = 0;
        for (int i = strLeng - 1; i >= 0; i--)
        {
            reversedStr[count] = str[i];
            count++;
        }
        for (int i = 0; i < count; i++)
        {
            Console.Write(reversedStr[i]);
        }
        Console.WriteLine();
    }
}

