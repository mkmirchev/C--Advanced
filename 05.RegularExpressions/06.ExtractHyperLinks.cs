using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ExtractHyperLinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
            StringBuilder inputData = new StringBuilder();
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                inputData.Append(input);
            }
            string text = inputData.ToString();
            Regex rgx = new Regex(pattern);
            foreach (Match link in rgx.Matches(text))
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (link.Groups[i].Length > 0)
                    {
                        Console.WriteLine(link.Groups[i]);
                    }
                }
            }
        }
    }
}

