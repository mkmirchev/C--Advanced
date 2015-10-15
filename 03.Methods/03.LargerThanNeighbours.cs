using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(input, i));
        }
    }
    public static bool IsLargerThanNeighbours(int[] numbers, int currnetNumber)
    {
        bool isLarger = false;
        if (currnetNumber > 0 && currnetNumber < numbers.Length - 1)
        {
            if (numbers[currnetNumber] > numbers[currnetNumber - 1] && numbers[currnetNumber] > numbers[currnetNumber + 1])
            {
                isLarger = true;
            }
        }
        else if (currnetNumber == 0)
        {
            if (numbers[currnetNumber] > numbers[currnetNumber + 1])
            {
                isLarger = true;
            }
        }
        else if (currnetNumber == numbers.Length - 1)
        {
            if (numbers[currnetNumber] > numbers[currnetNumber - 1])
            {
                isLarger = true;
            }
        }
        return isLarger;
    }
}


