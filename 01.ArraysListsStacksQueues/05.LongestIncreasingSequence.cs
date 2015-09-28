using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<List<int>> sequences = new List<List<int>>();
        sequences.Add(new List<int>());
        int listNumber = 0;
        int maxLenght = 0;
        int longestArr = 0;
        for (int i = 0; i < input.Count - 1; i++)
        {
            if (input[i] < input[i + 1])
            {
                sequences[listNumber].Add(input[i]);
                if (i == input.Count - 2)
                {
                    sequences[listNumber].Add(input[i+1]);
                }
            }
            else
            {
                sequences[listNumber].Add(input[i]);
                sequences.Add(new List<int>());
                listNumber++;
                if (i == input.Count - 2)
                {
                    sequences[listNumber].Add(input[i + 1]);
                }
            }
        }
        foreach (var arr in sequences)
        {
            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < sequences.Count; i++)
        {
            if (maxLenght < sequences[i].Count)
        	{
                maxLenght = sequences[i].Count;
                longestArr = i;
        	}
        }
        Console.WriteLine("Longest: " + string.Join(" ", sequences[longestArr]));
    }
}

        
    

