using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);

        Console.WriteLine("Number of words in the sentence: " + wordCount);
    }

    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
