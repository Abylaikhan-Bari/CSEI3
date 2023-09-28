using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст (для завершения введите точку):");

        int spaceCount = 0;
        char input;

        do
        {
            input = Console.ReadKey().KeyChar;

            if (input == ' ')
            {
                spaceCount++;
            }

        } while (input != '.');

        Console.WriteLine($"\nКоличество введенных пробелов: {spaceCount}");
    }
}
