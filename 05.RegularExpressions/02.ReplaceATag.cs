using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceATag
{
    static void Main()
    {
        string input = "<ul><li><a href=\"http://softuni.bg\">SoftUni</a></li></ul>";
        string pattern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";
        Regex regex = new Regex(pattern);
        string newPattern = @"[URL$1]$3[/URL]";
        regex.Replace(input, newPattern);
        if (regex.IsMatch(input) == true)
        {
            Console.WriteLine(regex.Replace(input,newPattern));
        }
        


    }
}
