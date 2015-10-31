using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

    class WordCount
    {
        static void Main()
        {
            List<string> words = ReadWords(@"D:\Mirchev\SoftUni\Advanced-C#\06.StreamsAndFiles\03.WordCount\words.txt");
            SortedDictionary<string,int> result = new SortedDictionary<string, int>();
            foreach (var word in words)
            {
                int cnt = CountWords(word , @"D:\Mirchev\SoftUni\Advanced-C#\06.StreamsAndFiles\03.WordCount\text.txt" );
                result.Add(word, cnt);
            }
            List<KeyValuePair<string, int>> sortedRes = result.ToList();
            sortedRes.Sort((firstPair, nextPair) =>
            {
                return nextPair.Value.CompareTo(firstPair.Value);
            });
            StreamWriter results = new StreamWriter(@"D:\Mirchev\SoftUni\Advanced-C#\06.StreamsAndFiles\03.WordCount\result.txt");
            foreach (var sorted in sortedRes)
            {
                results.WriteLine("{0} - {1}", sorted.Key, sorted.Value);
            }                           
            results.Close();

        }
        //method that reads all words from a given file and returns a List<string>
        public static List<string> ReadWords(string path)
        {
            List<string> words = new List<string>();
            try
            {
                StreamReader wordsRead = new StreamReader(path, Encoding.GetEncoding("windows-1251"));
                using (wordsRead)
                {
                    string line;
                    do
                    {
                        line = wordsRead.ReadLine();
                        if (line != null)
                        {
                            words.Add(line);
                        }                       
                    } while (line != null);
                }
                wordsRead.Close();
                return words;
            }
            catch (FileNotFoundException)
            {
                List<string> empty = new List<string>();
                Console.WriteLine("The file with words is not found.");
                return empty;
            }
           
        }
        //method that reads a given text and count how many times a given words is repeated there
        public static int CountWords(string word, string path)
        {
            int count = 0;
            string pattern = @"[A-Za-z]+";
            Regex rgx = new Regex(pattern);
            try
            {
                StreamReader textReader = new StreamReader(path, Encoding.GetEncoding("windows-1251"));
                using (textReader)
                {
                    string line;
                    do
                    {

                        line = textReader.ReadLine();
                        if (line != null)
                        {
                           foreach (Match wrd in rgx.Matches(line.ToLower()))
                        {
                            if (wrd.ToString() == word)
                            {
                                count++;
                            }
                        } 
                        }
                        
                    } while (line != null);
                }
                return count;
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("Text file was not found.");
                return 0;
            }
        }
    }

