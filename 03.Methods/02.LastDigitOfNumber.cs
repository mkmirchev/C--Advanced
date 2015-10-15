using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string lastDigit = GetLastDigit(a);
        Console.WriteLine(lastDigit);
    }

    public static string GetLastDigit(int number)
    {
        int digit = number % 10;
        string[] digits = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven","eigth", "nine"};
        string result = digits[digit];      
        return result;
    }
}

