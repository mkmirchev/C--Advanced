using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"[._a-z]{4,14}?(?=@)@(\w.{1,}?(?=\s))";
        Regex regx = new Regex(pattern);
        foreach (Match match in regx.Matches(input))
        {
            Console.WriteLine(match);
        }
    }
}

