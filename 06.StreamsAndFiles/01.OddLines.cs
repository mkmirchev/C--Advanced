using System;
using System.Text;
using System.IO;

class OddLines
{
    static void Main()
    {
        try
        {
            StreamReader readOddLines = new StreamReader(@"..\..\OddLines.cs", Encoding.GetEncoding("windows-1251"));
            string line;
            int lineNums = 0;
            using (readOddLines)
            {
                do
                {
                    line = readOddLines.ReadLine();
                    lineNums++;
                    Console.WriteLine("Line {0,2} : {1}", lineNums, line);
                    line = readOddLines.ReadLine();                    
                    lineNums++;
                } while (line != null);
            }
        }
        catch (FileNotFoundException)
        {

            Console.WriteLine("File not found.");
        }
    }
}

