using System;

class FirstLargetThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5};
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6};
        int[] sequenceThree = { 1, 1, 1 };
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    public static int GetIndexOfFirstElementLargerThanNeighbours(int[] arr)
    {
        int index = 0;
        bool isLarger = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && i < arr.Length - 1)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                isLarger = true;
                index = i;
            }
        }
        else if (i == 0)
        {
            if (arr[i] > arr[i + 1])
            {
                isLarger = true;
                index = i;
            }
        }
            else if (i == arr.Length - 1)
        {
            if (arr[i] > arr[i - 1])
            {
                isLarger = true;
                index = i;
            }
        }
        if (isLarger == true)
        {
            return index;
        }
        }
       
        return -1;
    }
}
