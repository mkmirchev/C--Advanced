using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { '.', ',', '!', '?', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> sortedOutput = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            string reversedStr = StrReverser(input[i]);
            if (input[i] == reversedStr)
            {
                sortedOutput.Add(input[i]);
            }
        }
        sortedOutput.Sort();
        Console.WriteLine(string.Join(", ",sortedOutput));
    }

    static string StrReverser(string strToRev)
    {
        char[] ch = strToRev.ToCharArray();
        Array.Reverse(ch);
        return new string(ch);

    }
}

