using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        // input field
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        // declare needed variables;
        int sorter = 0;       
        int counter = 0;  
   
        // the logic of the sorter
        while (counter < input.Count -1)
        {
            if (input[counter + 1] < input[counter])
            {
                sorter = input[counter+1];
                input[counter+1] = input[counter];
                input[counter] = sorter;                
                counter = 0;                             
            }
            else
            {              
                counter++;                                                                
            }
        } 
        // print the sorted numbers
        Console.WriteLine(string.Join(" ", input));
    }
}

