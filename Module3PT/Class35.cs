using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        char[] sentenceArray = sentence.ToCharArray();

        for (int i = 2; i < sentenceArray.Length; i += 3)
        {
            sentenceArray[i] = 'а';
        }

        string modifiedSentence = new string(sentenceArray);

        Console.WriteLine("Измененное предложение:");
        Console.WriteLine(modifiedSentence);
    }
}
