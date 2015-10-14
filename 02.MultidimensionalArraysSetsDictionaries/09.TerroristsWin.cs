using System;
using System.Linq;

class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        int firstIndex = input.IndexOf('|');
        int secondIndex = 0;
        int asciiSum = 0;
        int dmgSplash = 0;
        while (firstIndex != -1)
        {            
            secondIndex = input.IndexOf('|', firstIndex + 1);
           
            int bombLength = secondIndex - (firstIndex + 1);
            string bomb = input.Substring(firstIndex + 1, bombLength);

            asciiSum = bomb.ToCharArray().Select(c => (int)c).Sum();
            dmgSplash = asciiSum % 10;

            int bombStartIndex = firstIndex - dmgSplash;
            int bombEndIndex = secondIndex + dmgSplash;

            bombStartIndex = bombStartIndex > 0 ? bombStartIndex : 0;
            bombEndIndex = bombEndIndex < input.Length ? bombEndIndex : input.Length - 1;

            int destroyedArea = bombEndIndex - bombStartIndex + 1;

            input = input.Remove(bombStartIndex, destroyedArea).Insert(bombStartIndex, new string('.', destroyedArea));
            firstIndex = input.IndexOf('|', secondIndex + 1);
        }
        Console.WriteLine(input);
    }
}


