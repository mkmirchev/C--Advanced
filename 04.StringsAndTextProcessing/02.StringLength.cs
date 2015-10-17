using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        int strLeng = input.Length;
        if (strLeng >= 20)
        {
            for (int i = 0; i < 20; i++)
            {
                sb.Append(input[i]);
            }
            
        }
        else if (strLeng < 20)
        {
            for (int i = 0; i < strLeng; i++)
            {
                sb.Append(input[i]);
            }
            for (int i = 0; i < 20 - strLeng; i++)
            {
                sb.Append('*');
            }
        }
        Console.WriteLine(sb);
    }
}

