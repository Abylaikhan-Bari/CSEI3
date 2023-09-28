using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        double sum = FindAndSumNumbers(text);

        Console.WriteLine($"Сумма всех чисел в тексте: {sum}");
    }

    static double FindAndSumNumbers(string text)
    {
        double sum = 0;
        MatchCollection numberMatches = Regex.Matches(text, @"[+-]?\d+(\.\d+)?");

        foreach (Match match in numberMatches)
        {
            if (double.TryParse(match.Value, out double number))
            {
                sum += number;
            }
        }

        return sum;
    }
}
