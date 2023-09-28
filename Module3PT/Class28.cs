using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите слово из 12 букв: ");
        string word = Console.ReadLine();

        if (word.Length != 12)
        {
            Console.WriteLine("Слово должно состоять из 12 букв.");
            return;
        }

        // Вариант "а"
        string part1a = word.Substring(0, 4);
        string part2a = word.Substring(4, 4);
        string part3a = word.Substring(8, 4);

        string resultA = part2a + part3a + part1a;

        // Вариант "б"
        string part1b = word.Substring(0, 4);
        string part2b = word.Substring(4, 4);
        string part3b = word.Substring(8, 4);

        string resultB = part3b + part1b + part2b;

        Console.WriteLine($"Результат (вариант \"а\"): {resultA}");
        Console.WriteLine($"Результат (вариант \"б\"): {resultB}");
    }
}
