using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        int countM = CountLetterOccurrences(sentence, 'м');
        int countN = CountLetterOccurrences(sentence, 'н');

        if (countM > countN)
        {
            Console.WriteLine("Больше букв 'м' в предложении.");
        }
        else if (countM < countN)
        {
            Console.WriteLine("Больше букв 'н' в предложении.");
        }
        else
        {
            Console.WriteLine("Количество букв 'м' и 'н' одинаково.");
        }
    }

    static int CountLetterOccurrences(string text, char letter)
    {
        return text.Count(c => c == letter);
    }
}
