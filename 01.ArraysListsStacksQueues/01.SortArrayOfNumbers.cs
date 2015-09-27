using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SortArrayOfNumbers
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            foreach (var number in input)
            {
                Console.Write(number + " ");
            }
            // another way to print the numbers
            //Console.WriteLine(string.Join(" ", input));
        }
    }

