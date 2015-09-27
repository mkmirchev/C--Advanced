using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SequncesOfEqualStrings
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int counter = 1;

            for (int index = 0; index <= input.Count - 1; index++ )
            {
                if (input.Count == 1)
                {
                    Console.WriteLine(input[0]);   
                }
                else if (index < input.Count - 1)
                { 
                if (input[index] == input[counter] )
                    {
                    
                    if (index != input.Count - 2)
                    {
                        Console.Write(input[index] + " ");
                    }
                    else
                    {
                        Console.Write(input[index] + " " + input[counter]);
                        Console.WriteLine();
                    }
                    }
                else if (input[index] != input[counter])
                {
                    Console.Write(input[index]);
                    Console.WriteLine();
                }
                if (input[index] != input[counter] && counter == input.Count - 1)             
                {
                    Console.WriteLine(input[counter]);
                    
                }
                counter++;
                }
            }
           
            }
        }
    

 
