using System;
using System.Collections.Generic;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> eventInfo = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] input;
        string city = string.Empty;
        string place = string.Empty;
        string performer = string.Empty;
        string eventInput = Console.ReadLine();

        while (eventInput != "END")
        {
            input = eventInput.Split(new char[] {';'},StringSplitOptions.RemoveEmptyEntries);
            city = input[0];
            place = input[1];
            performer = input[2];
            if (!eventInfo.ContainsKey(city))
            {
                eventInfo[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!eventInfo[city].ContainsKey(place))
            {
                eventInfo[city][place] = new SortedSet<string>();
            }
           
                eventInfo[city][place].Add(performer);
            
            
            eventInput = Console.ReadLine();
        }
        foreach (var cityPair in eventInfo)
        {
            Console.WriteLine(cityPair.Key);
            foreach (var placePairs in cityPair.Value)
            {
                Console.WriteLine("->{0}:{1}", placePairs.Key, String.Join(", ", placePairs.Value));
            }
           
        }
    }
}

