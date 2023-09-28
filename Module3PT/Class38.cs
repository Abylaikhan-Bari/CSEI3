using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        int digitCount = CountDigits(text);

        Console.WriteLine($"Количество цифр в тексте: {digitCount}");
    }

    static int CountDigits(string text)
    {
        int digitCount = 0;

        foreach (char character in text)
        {
            if (char.IsDigit(character))
            {
                digitCount++;
            }
        }

        return digitCount;
    }
}
