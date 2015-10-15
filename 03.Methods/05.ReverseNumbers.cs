using System;
using System.Collections.Generic;
using System.Text;

class ReverseNumbers
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine(Reversed(input));
    }

    public static double Reversed(double number)
    {
        StringBuilder sb = new StringBuilder();
        List<char> ch = new List<char>(number.ToString());
        ch.Reverse();
        foreach (var item in ch)
        {
            sb.Append(item);
        }
        string str = sb.ToString();
        double output = double.Parse(str);
        return output;
    }
}

