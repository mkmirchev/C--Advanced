using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class NumberCalculation
{
    static void Main()
    {
        List<string> data = new List<string>(Console.ReadLine().Split());
        decimal a;
        bool isDecimal = decimal.TryParse(data[0],out a);
        if (isDecimal == true)
        {
            List<decimal> input = new List<decimal>();
            foreach (var item in data)
	        {
		       input.Add(Convert.ToDecimal(item));
	        }
            Console.WriteLine("Min: {0:F2} | Max: {1:F2} | Avrg: {2:F2} | Sum: {3:F2} | Prod: {4:F2}",GetMin(input), GetMax(input), Avrg(input), Sum(input), Prod(input));
        }     
        else
	    {
            List<double> input = new List<double>();
            foreach (var item in data)
            {
                input.Add(Convert.ToDouble(item));
            }
            Console.WriteLine("Min: {0:F2} | Max: {1:F2} | Avrg: {2:F2} | Sum: {3:F2} | Prod: {4:F2}", GetMin(input), GetMax(input), Avrg(input), Sum(input), Prod(input));
	    }

    }
        // Minimum value
        public static double GetMin(List<double> list)
        {
            double minValue = double.MaxValue;
            foreach (var number in list)
	        {
		        if (number < minValue)
                {
		            minValue = number;
                }
	        }
            return minValue;
        }
        public static decimal GetMin(List<decimal> list)
        {
            decimal minValue = decimal.MaxValue;
            foreach (var number in list)
            {
                if (number < minValue)
                {
                    minValue = number;
                }
            }
            return minValue;
        }
        // Maximum value
        public static decimal GetMax(List<decimal> list)
        {
            decimal maxValue = decimal.MinValue;
            foreach (var number in list)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            return maxValue;
        }
        public static double GetMax(List<double> list)
        {
            double maxValue = double.MinValue;
            foreach (var number in list)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            return maxValue;
        }
        // Average value
        public static decimal Avrg(List<decimal> list)
        {
            decimal avrg = Sum(list) / list.Count;             
            return avrg;
        }
        public static double Avrg(List<double> list)
        {
            double avrg = Sum(list) / list.Count;
            return avrg;           
        }

        //Sum of elements
        public static decimal Sum(List<decimal> list)
        {
            decimal sum = 0;
            foreach (var number in list)
            {
                sum += number;
            }
            return sum;
        }
        public static double Sum(List<double> list)
        {
            double sum = 0;
            foreach (var number in list)
            {
                sum += number;
            }
            return sum;
        }
        // Production of elements
        public static decimal Prod(List<decimal> list)
        {
            decimal sum = 1;
            foreach (var number in list)
            {
                sum *= number;
            }
            return sum;
        }
        public static double Prod(List<double> list)
        {
            double sum = 1;
            foreach (var number in list)
            {
                sum *= number;
            }
            return sum;
        }
    }


