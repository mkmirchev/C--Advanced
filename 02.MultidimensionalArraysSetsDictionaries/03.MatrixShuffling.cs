using System;
using System.Linq;
using System.Collections.Generic;

class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        List<string> input = new List<string>();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        while (true)
        {
            input = Console.ReadLine().Split().ToList();
            if (input[0] == "END")
            {
                break;
            }
            else if (input[0] == "swap")
            {
                if (Convert.ToInt32(input[1]) > rows || Convert.ToInt32(input[2]) > cols ||
                    Convert.ToInt32(input[3]) > rows || Convert.ToInt32(input[4]) > cols || input.Count > 5) 
                {
                    Console.WriteLine("Invalid Input");
                    
                }
                else if (Convert.ToInt32(input[1]) > rows)
                {
                    Console.WriteLine("Invalid Input");
                }
                else if (Convert.ToInt32(input[2]) > cols)
                {
                    Console.WriteLine("Invalid Input");
                }
                else if (Convert.ToInt32(input[3]) > rows)
                {
                    Console.WriteLine("Invalid Input");
                }
                else if (Convert.ToInt32(input[4]) > cols)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    string temp = matrix[Convert.ToInt32(input[1]), Convert.ToInt32(input[2])];
                    matrix[Convert.ToInt32(input[1]), Convert.ToInt32(input[2])] = 
                    matrix[Convert.ToInt32(input[3]), Convert.ToInt32(input[4])];

                    matrix[Convert.ToInt32(input[3]), Convert.ToInt32(input[4])] = temp;
                    for (int k = 0; k < rows; k++)
                    {
                        for (int l = 0; l < cols; l++)
                        {
                            Console.Write(matrix[k,l]);
                        }
                        Console.WriteLine();
                
                }
                }
            }            
        }
    }
}

