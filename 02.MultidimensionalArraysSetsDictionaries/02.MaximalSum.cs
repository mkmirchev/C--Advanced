using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximalSum
{
    static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int[]> matrix = new List<int[]>();
        int[] searchRange = new int[] { matrixSize[0] - 2, matrixSize[1] - 2 };
        List<int> searchMax = new List<int>();
        int maxSum = 0;
        int maxX = 0;
        int maxY = 0;
        int currentSum = 0;
        for (int i = 0; i < matrixSize[0]; i++)
        {           
            int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            matrix.Add(rowElements);                                                          
        }
        for (int i = 1; i <= searchRange[0]; i++)
        {
            for (int k = 1; k <= searchRange[1]; k++)
            {
                foreach (var arr in matrix)
                {
                    searchMax.Add(matrix[i - 1][k - 1]);
                    searchMax.Add(matrix[i - 1][k]);
                    searchMax.Add(matrix[i - 1][k + 1]);
                    searchMax.Add(matrix[i][k - 1]);
                    searchMax.Add(matrix[i][k]);
                    searchMax.Add(matrix[i][k + 1]);
                    searchMax.Add(matrix[i + 1][k - 1]);
                    searchMax.Add(matrix[i + 1][k]);
                    searchMax.Add(matrix[i + 1][k + 1]);
                    currentSum = searchMax.Sum();
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxX = k;
                        maxY = i;
                    }
                    searchMax = new List<int>();
                }
            }  
        }
        Console.WriteLine("Sum = {0}", maxSum);
        for (int index = maxY-1; index < maxY+2; index++)
        {
            for (int indx = maxX-1; indx < maxX+2; indx++)
            {
                Console.Write(matrix[index][indx] + " ");
            }
            Console.WriteLine();
        }    
    }
}

