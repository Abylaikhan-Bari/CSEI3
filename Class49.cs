using System;

class Program
{
    static void Main()
    {
        string inputString = "This is a sample string with some words containing 'a'.";

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(inputString);

        string resultString = RemoveWordsWithLastWordLetters(inputString);

        Console.WriteLine("Строка после удаления слов, содержащих буквы последнего слова:");
        Console.WriteLine(resultString);
    }

    static string RemoveWordsWithLastWordLetters(string input)
    {
        string[] words = input.Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 2)
        {
            return input; // Нет последнего слова для сравнения
        }

        string lastWord = words[words.Length - 1];

        string[] filteredWords = Array.FindAll(words, word => !word.Contains(lastWord, StringComparison.OrdinalIgnoreCase));

        return string.Join(" ", filteredWords);
    }
}
