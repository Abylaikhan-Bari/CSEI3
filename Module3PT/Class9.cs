using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        int count = CountWordsWithSameFirstAndLastCharacter(input);

        Console.WriteLine("Number of words with the same first and last character: " + count);
    }

    static int CountWordsWithSameFirstAndLastCharacter(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        return count;
    }
}
