using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<char, int> result = new Dictionary<char, int>();
        List<char> keyHolder = new List<char>();
        char ch;
        int inpLength = input.Length;
        int count = 0;
        int charCount = 0;
        while (count < inpLength)
        {
            ch = input[count];
            for (int i = 0; i < inpLength; i++)
            {
                if (ch == input[i])
                {
                    charCount++;
                }                
            }
            if (keyHolder.Contains(ch) == false)
            {
                keyHolder.Add(ch);
                result.Add(ch, charCount);
            }
            keyHolder.Distinct();
            charCount = 0;
            count++;
        }
        keyHolder.Sort();
        foreach (var pair in keyHolder)
        {
            Console.WriteLine("{0} : {1} time/s", pair, result[pair]);
        }
    }
}

