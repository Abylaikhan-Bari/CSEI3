using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        string modifiedSentence = sentence.Replace('е', 'и');

        Console.WriteLine("Измененное предложение:");
        Console.WriteLine(modifiedSentence);
    }
}
