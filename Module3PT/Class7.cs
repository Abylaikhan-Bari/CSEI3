using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a 20-character string: ");
        string input = Console.ReadLine();

        int digitCount = CountDigits(input);

        Console.WriteLine("Number of digits in the string: " + digitCount);
    }

    static int CountDigits(string input)
    {
        int digitCount = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        return digitCount;
    }
}
