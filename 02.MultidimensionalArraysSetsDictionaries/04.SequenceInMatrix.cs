using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        List<string>[] matrixOne = new List<string>[] { 
        new List<string> { "ha", "ho", "hs", "ha" }, 
        new List<string>{ "fo", "ha", "hw", "hs" }, 
        new List<string>{ "xxx", "xxx", "ha", "xxx" }};
        //List<string>[] matrixOne = new List<string>[] { 
        //new List<string> { "s", "qq", "s"}, 
        //new List<string>{ "qq", "pp", "s"}, 
        //new List<string>{ "pp", "qq", "s"}};
        int matrixLength = matrixOne[0].Count();
        int matrixHeight = matrixOne.Count();
        int max =0;
        string maxS = "";
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixLength; j++)
            {
                int maxSeq = FindMaxSeq(matrixOne,i,j,matrixLength,matrixHeight);
                if (maxSeq > max)
                {
                    max = maxSeq;
                    maxS = matrixOne[i][j];
                }
            }
        }
        PrintResult(max,maxS);        
    }

    //Printing result
    public static void PrintResult(int maxSet, string setElement)
    {
        for (int i = 0; i < maxSet; i++)
        {
            Console.Write(setElement + " ");
        }
        Console.WriteLine();
    }
    
    //Finding the maximal set of equal elements
    public static int FindMaxSeq(List<string>[] matrixOne, int i, int j, int matrixLength, int matrixHeight)
    {       
        int resultR = 1;
        int resultC = 1;
        int resultD = 1;
        int curI = i;
        int curJ = j;
        string currentStr = matrixOne[i][j];
        //checking rows
        while (curJ < matrixLength - 1 && curI < matrixHeight && currentStr == matrixOne[i][curJ + 1])
        {
            currentStr = matrixOne[i][curJ + 1];
            curJ++;
            resultR++;
        }
        curJ = j;
        currentStr = matrixOne[i][j];
        //ckeck cols
        while (curJ < matrixLength && i < matrixHeight - 1 && currentStr == matrixOne[curI + 1][j])
        {
            currentStr = matrixOne[curI + 1][j];
            curI++;
            resultC++;
        }
        curI = i;
        currentStr = matrixOne[i][j];
        //check diagonal
        while (curI < matrixHeight - 1 && curJ < matrixLength - 1 && currentStr == matrixOne[curI + 1][curJ + 1])
        {
            currentStr = matrixOne[curI + 1][curJ + 1];
            curI++;
            curJ++;
            resultD++;
        }
          int result = Math.Max(resultD, Math.Max(resultC, resultR));
        return result;
    }
}

