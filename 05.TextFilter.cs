using System;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main(string[] args)
    {   
    string[] bannedWords = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
    StringBuilder bannedText = new StringBuilder(Console.ReadLine());
    string[] bannedWordsAsAsterisks = new string[bannedWords.Count()];

    for (int i = 0; i < bannedWords.Count(); i++)
    {
        bannedWordsAsAsterisks[i] = new string('*', bannedWords[i].Length);
        bannedText.Replace(bannedWords[i], bannedWordsAsAsterisks[i]);
    }
    Console.WriteLine(bannedText);
    }
}

