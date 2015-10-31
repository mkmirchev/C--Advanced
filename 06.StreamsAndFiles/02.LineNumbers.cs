using System;
using System.Text;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        try
        {
            StreamReader readFile = new StreamReader(@"D:\Mirchev\SoftUni\Advanced-C#\06.StreamsAndFiles\01.OddLines\OddLines.cs", Encoding.GetEncoding("windows-1251"));
            StreamWriter writeFile = new StreamWriter(@"..\..\OddLinesNumbered.txt");
            string line;
            int lineNums = 1;
            using (readFile)
            {
                do
                {
                    line = readFile.ReadLine();
                    writeFile.WriteLine("{0,2}. {1}",lineNums,line);
                    lineNums++;                  
                } while (line != null);
                writeFile.Close();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}
