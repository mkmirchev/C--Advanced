using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SentenceExtractor
{
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string input = Console.ReadLine();
        string pattern = @"(\w+\s){1,}\w+?[.!?]";
        Regex rgx = new Regex(pattern);
        foreach (Match mch in rgx.Matches(input))
        {
            if (mch.Value.Contains(keyWord))
            {
                Console.WriteLine(mch);
            }
        }
    }
}

