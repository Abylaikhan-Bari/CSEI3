using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputString = "This is a sample string with some words like 'wow' and 'level'.";

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(inputString);

        string resultString = HighlightWordsWithSameFirstAndLastLetter(inputString);

        Console.WriteLine("Строка с выделенными словами:");
        Console.WriteLine(resultString);
    }

    static string HighlightWordsWithSameFirstAndLastLetter(string input)
    {
        string pattern = @"\b(\w)\w*\1\b"; // Регулярное выражение для слов с одинаковой первой и последней буквой

        MatchEvaluator evaluator = match =>
        {
            string matchedWord = match.Value;
            return "[" + matchedWord + "]";
        };

        return Regex.Replace(input, pattern, evaluator);
    }
}
