using System;

class GenericArraySort
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5};
        string[] strs = { "zaz","cba", "baa", "azis"};
        DateTime[] dates = { new DateTime(2003,3,1), new DateTime(2005,1,12), new DateTime(2001,1,1)};
        SortArrays(numbers);
        SortArrays(strs);
        SortArrays(dates);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < strs.Length; i++)
        {
            Console.Write(strs[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < dates.Length; i++)
        {
            Console.Write(dates[i] + " ");
        }
    }
    static T[] SortArrays<T>(T[] array) where T: IComparable
    {
        int min;
        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int k = i+1; k < array.Length; k++)
            {
                if (array[k].CompareTo(array[i]) < 0)
                {
                    min = k;
                }
            }
            if (min !=i)
            {
                T temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }
        return array;
    }
}

