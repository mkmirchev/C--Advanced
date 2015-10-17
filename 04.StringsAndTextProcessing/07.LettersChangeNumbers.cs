using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class LettersChangeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            string inputData = input[i];
            char leftCh = inputData[0];
            char rightCh = inputData[inputData.Length - 1];
            double num = double.Parse(inputData.Substring(1, inputData.Length - 2));

            if (char.IsUpper(leftCh))
            {
                int beforePossition = leftCh - 'A' + 1;
                num /= beforePossition;
            }
            else
            {
                int beforePossition = leftCh - 'a' + 1;
                num *= beforePossition;
            }
            if (char.IsUpper(rightCh))
            {
                int afrerPossition = rightCh - 'A' + 1;
                num -= afrerPossition;
            }
            else
            {
                int afrerPossition = rightCh - 'a' + 1;
                num += afrerPossition;
            }
            sum += num;
        }
        Console.WriteLine("{0:f2}", sum);
    }
}

