using System;
using System.Collections.Generic;
using System.Linq;

class PythagoeanNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        List<string> data = new List<string>();
        for (int i = 0; i < input; i++)
        {
            data.Add(Console.ReadLine());
        }
        List<string> tempData = data;
        bool isPytharoeanNumbers = false;
        if (input <3)
        {
            Console.WriteLine("No.");
        }
        else
        {
        foreach (var a in data)
            {
                tempData = data.ToList();
                foreach (var b in tempData.ToList())
	            {
                    foreach (var c in tempData)
	                {
                        int numA = Convert.ToInt32(a);                        
                        int numB = Convert.ToInt32(b);
                        int numC = Convert.ToInt32(c);
                        if (numA <= numB)
                        {
                            if (numA == 0)
                            {
                                if (numB == 0 && numC == 0)
                                {
                                    Console.WriteLine("0*0 + 0*0 = 0*0");
                                    isPytharoeanNumbers = true;
                                }
                                else if (numB == numC)
                                {
                                    Console.WriteLine("0*0 + {0}*{0} = {1}*{1}", numB, numC);
                                    isPytharoeanNumbers = true;
                                }
                            }                           
                            else if (numA * numA + numB * numB == numC * numC)
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numA, numB, numC);
                                isPytharoeanNumbers = true;
                            }
                        }                      
                    }                  
	            }             
            }
        if (isPytharoeanNumbers == false)
        {
            Console.WriteLine("No.");
        }
        }        
    }
}
