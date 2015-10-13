using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class PhoneBook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string input = " ";
        char splitter = '-';
        int splitIndex = 0;
        while (true)
        {   
            input = Console.ReadLine();
            if (input == "search")
            {
                break;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == splitter)
                {
                    splitIndex = i;
                }
            }
            phonebook.Add(input.Substring(0, splitIndex), input.Substring((splitIndex + 1), input.Length - splitIndex - 1));
            input.DefaultIfEmpty();
        }
        while (true)
        {
            input = Console.ReadLine();
            if (input == "exit")
            {
                break;               
            }
            if (phonebook.ContainsKey(input))
            {
                Console.WriteLine("{0} -> {1}", input, phonebook[input]);
            }
            else
            {
                Console.WriteLine("The contact {0} does not exist.", input);
            }
        }
    }
}

