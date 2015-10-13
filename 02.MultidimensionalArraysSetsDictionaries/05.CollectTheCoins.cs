using System;

class CollectTheCoins
{
    static void Main()
    {   
        //get the game field
        string[] field = new string[4];
        for (int i = 0; i < 4; i++)
        {
            field[i] = Console.ReadLine();
        }
        //get moves
        int x = 0;
        int y = 0;
        char start = field[y][x];
        string moves = Console.ReadLine();
        int steps = moves.Length;
        int path= 0;
        int score = 0;
        int wallhits = 0;
        while (path < steps)
        {
            switch (moves[path])
            {
                case '<':
                    if (x - 1 >= 0)
                    {
                        x--;
                        start = field[y][x];
                        if (start == '$')
                        {
                            score++;
                        }
                    }
                    else
                    {
                        wallhits++;
                    }
                    break;
                case '>':
                    if (x + 1 < field[y].Length)
                    {
                        x++;
                        start = field[y][x];
                        if (start == '$')
                        {
                            score++;
                        }
                    }
                    else
                    {
                        wallhits++;
                    }
                    break;
                case 'V':
                    if (y + 1 <= field.Length - 1 && x < field[y + 1].Length - 1)
                    {
                        y++;
                        start = field[y][x];
                        if (start == '$')
                        {
                            score++;
                        }
                    }
                    else
                    {
                        wallhits++;
                    }
                    break;
                case '^':
                    if (y - 1 >= 0 && x < field[y - 1].Length - 1)
                    {
                        y--;
                        start = field[y][x];
                        if (start == '$')
                        {
                            score++;
                        }
                    }
                    else
                    {
                        wallhits++;
                    }
                    break;
            }
            path++;
        }
        Console.WriteLine("Score = {0}  and wall hitted = {1}", score, wallhits);
    }
}
