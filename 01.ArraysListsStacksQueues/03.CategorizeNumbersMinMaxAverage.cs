using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CategorizeNumbersMinMaxAverage
    {
        static void Main()
        {
            // input field
            List<float> input = Console.ReadLine().Split(' ').Select(float.Parse).ToList();

            // declare needed variables;
            List<int> dec = new List<int>();
            List<float> flt = new List<float>();

            // divide integer numbers of these with floating point
            foreach (var number in input)
            {
                int result = 0;
                if (int.TryParse(number.ToString(), out result) == true)
                {
                    dec.Add(result);                    
                }
                else
                {
                    flt.Add(number);
                }
            }
            // getting result values for Min, Max, Sum, Average
            float[] fResult = FindMinMaxSumAverage(flt);
            int[] iResult = FindMinMaxSumAverage(dec);

            // printing the results in exact format
            Console.WriteLine("[" + string.Join(" ", flt) + "] -> min: {0:F2}, max: {1:F2}, sum: {2:F2}, average: {3:F2}", fResult[0], fResult[1], fResult[2], fResult[3]);
            Console.WriteLine("[" + string.Join(" ", dec) + "] -> min: {0:F2}, max: {1:F2}, sum: {2:F2}, average: {3:F2}", iResult[0], iResult[1], iResult[2], iResult[3]);
        }

        // making a method which calculates the Min, Max, Sum and Average values of the list of integers
        static int[] FindMinMaxSumAverage(List<int> data)
        {
            int max = data.Max();
            int min = data.Min();
            int sum = data.Sum();
            int average = sum / data.Count;
            int[] result = { min, max, sum, average };
            return result;
           
        }

        // making an overloading of the method FindMinMaxAverage that works with floating point numbers
        static float[] FindMinMaxSumAverage(List<float> data)
        {
            float max = data.Max();
            float min = data.Min();
            float sum = data.Sum();
            float average = sum / data.Count;
            float[] result = { min, max, sum, average };
            return result;

        }
    }

