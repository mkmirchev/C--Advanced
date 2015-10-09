using System;

class FillTheMatrix
{
    static void Main()
    {        
        string topBot = "down";
        string direction = topBot;
        string botTop = "up";
        int maxNumber = 16;
        int row = 0;
        int col = 0;
        int[,] matrix = new int[4,4]; //first matrix
        int[,] matrixTwo = new int[4, 4]; //second matrix
        //filling first matrix
        for (int i = 1; i <= maxNumber; i++)
        {
            if (row < 4 && col < 4)
            {
                matrix[row, col] = i;
                row++;
            }
            if (row == 4)
            {
                col++;
                row = 0;
            }
        }
        row = 0;
        col = 0;
        //filling second matrix
        for (int index = 1; index <= maxNumber; index++)
        {
            if (direction == "down" && row < 4 && col < 4)
            {
                 matrixTwo[row, col] = index;
                 row++;
                 if (row == 4 && col < 4)
                 {
                     col++;
                     direction = botTop;
                     row = 3;
                 }
            }
            else if (direction == "up" && row < 4 && col < 4)
            {
                 matrixTwo[row, col] = index;
                 row--;
                 if (row == -1 && col < 4)
                 {
                     col++;
                     direction = topBot;
                     row = 0;
                 }
            }
        }
        Console.WriteLine("First Filled Matrix");
        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(" {0,2} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Second Filled Matrix");
        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(" {0,2} ", matrixTwo[i, j]);
            }
            Console.WriteLine();
        }
    }
}

