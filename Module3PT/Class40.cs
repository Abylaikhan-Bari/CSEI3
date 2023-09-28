using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение из 10 слов:");

        string[] sentenceArray = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Слово {i + 1}: ");
            sentenceArray[i] = Console.ReadLine();
        }

        Console.WriteLine("Массив слов:");
        foreach (string word in sentenceArray)
        {
            Console.WriteLine(word);
        }
    }
}
