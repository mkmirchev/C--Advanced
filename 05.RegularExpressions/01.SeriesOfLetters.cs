using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SeriesOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"([a-z])\1+|([a-z]{1})";           
        Regex rx = new Regex(pattern);
        StringBuilder sb = new StringBuilder();
        foreach (Match mch in rx.Matches(input))
        {
            sb.Append(mch.ToString()[0]);
        }
        Console.WriteLine(sb);
    }
}

