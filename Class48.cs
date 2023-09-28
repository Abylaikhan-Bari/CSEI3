using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputString = "This is a sample string with some words containing 'a'.";

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(inputString);

        string resultString = RemoveWordsWithLetterA(inputString);

        Console.WriteLine("Строка после удаления слов, содержащих букву 'a':");
        Console.WriteLine(resultString);
    }

    static string RemoveWordsWithLetterA(string input)
    {
        string[] words = input.Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        string[] filteredWords = words.Where(word => !word.Contains('a', StringComparison.OrdinalIgnoreCase)).ToArray();

        return string.Join(" ", filteredWords);
    }
}
