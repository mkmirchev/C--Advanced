using System;
using System.Collections.Generic;
using System.Linq;

class LegoBlocks
{
    static void Main()
    {
        int rowNumbers = int.Parse(Console.ReadLine());
        List<int[]> firstElement = new List<int[]>();
        List<int[]> secondElement = new List<int[]>();        
        bool[] isPerfect = new bool[rowNumbers];
        isPerfect[0] = true;
        int numberOfCells = 0;
        for (int inputElementsReader = 0; inputElementsReader < rowNumbers; inputElementsReader++)
        {
            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            firstElement.Add(inputElements);
        }                          
        for (int inputElementsReader = 0; inputElementsReader < rowNumbers; inputElementsReader++)
        {
            int[] inputElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            secondElement.Add(inputElements);
        }
        int rowLenght = firstElement[0].Count() + secondElement[0].Count();
        bool isAnswer = true;
        for (int i = 1; i < rowNumbers; i++)
        {
            if ((firstElement[i].Count() + secondElement[i].Count()) == rowLenght)
            {
                isPerfect[i] = true;
            }
        }
        for (int index = 0; index < rowNumbers; index++)
        {
            isAnswer = isAnswer & isPerfect[index];         
        }
        
        if (isAnswer == true)
        {
            for (int index = 0; index < rowNumbers; index++)
            {
                Console.Write("[");
                for (int i = 0; i < firstElement[index].Count(); i++)
                {
                    Console.Write(firstElement[index][i] + ", "); 
                }
                secondElement[index].Reverse();
                for (int i = secondElement[index].Count() - 1; i >= 0; i--)
                {
                    Console.Write(secondElement[index][i] + ", ");
                }
                Console.Write("\b\b]");
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 0; i < rowNumbers; i++)
			{
			 numberOfCells += firstElement[i].Count() + secondElement[i].Count();
			}
            Console.WriteLine("There are {0} elements.", numberOfCells);
        }
    }
}

