using System;
using System.Collections.Generic;
using System.Linq;

class StuckNumbers
{
    static void Main()
    {
        int setLenght = int.Parse(Console.ReadLine());
        List<string> data = Console.ReadLine().Split().ToList();
        data.Distinct();
        List<string> tempData = data;       
        bool isEquals = false;
        if (data.Count() < 4)
        {
            Console.WriteLine("No.");
            return;
        }
        else
        {
            foreach (var a in data)
            {
                tempData = data.ToList();
                tempData.Remove(a);
                foreach (var b in tempData.ToList())
                {
                    tempData.Remove(b);
                    foreach (var c in tempData.ToList())
                    {
                        tempData.Remove(c);
                        foreach (var d in tempData)
                        {
                            if (a + b == c + d)
                            {
                                Console.WriteLine("{0}|{1} = {2}|{3}", a, b, c, d);
                                isEquals = true;
                            }
                        }
                        tempData.Add(c);
                    }
                    tempData.Add(b);
                }
                tempData.Add(a);
            }
            if (isEquals == false)
            {
                Console.WriteLine("No.");           
            }
        }
    }
}

