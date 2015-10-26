using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ValidUsername
{
    static void Main()
    {
        string pattern = @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{2,24})(?=[\s\/\\(\)]|$)";
        string input = @"ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref";        
        Regex regx = new Regex(pattern);
        List<string> validNames = new List<string>();
        int biggestSum = 0;
        int bigPos = 0;
        foreach (Match name in regx.Matches(input))
        {
            validNames.Add(name.ToString());
        }
        for (int i = 1; i < validNames.Count; i++)
        {
            int sum = validNames[i].Length + validNames[i - 1].Length;
            if (sum > biggestSum)
            {
                biggestSum = sum;
                bigPos = i;
            }
        }
        Console.WriteLine(validNames[bigPos -1]);
        Console.WriteLine(validNames[bigPos]);
    }
}

