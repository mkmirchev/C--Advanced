using System;

class UniCodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u" + String.Format("{0:X4}", (int)input[i]));
        }
    }
}

