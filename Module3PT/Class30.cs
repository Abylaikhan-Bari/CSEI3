using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        int sentenceCount = CountSentences(text);

        Console.WriteLine($"Количество предложений в тексте: {sentenceCount}");
    }

    static int CountSentences(string text)
    {
        // В этой реализации предполагается, что каждое предложение завершается одним из следующих знаков препинания: '.', '!', или '?'.
        // Мы считаем количество таких знаков препинания в тексте, чтобы определить количество предложений.

        int count = 0;

        foreach (char c in text)
        {
            if (c == '.' || c == '!' || c == '?')
            {
                count++;
            }
        }

        return count;
    }
}
