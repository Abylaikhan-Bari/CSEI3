using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        int countPlus = CountCharacterOccurrences(text, '+');
        int countMinus = CountCharacterOccurrences(text, '–'); // Обратите внимание, что это символ "–", а не "-" (они разные).

        Console.WriteLine($"Количество символов '+' в тексте: {countPlus}");
        Console.WriteLine($"Количество символов '–' в тексте: {countMinus}");
    }

    static int CountCharacterOccurrences(string text, char character)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (c == character)
            {
                count++;
            }
        }

        return count;
    }
}
