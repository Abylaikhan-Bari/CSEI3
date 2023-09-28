using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        if (word.Length >= 3)
        {
            // Удалить третью букву (индекс 2)
            string modifiedWord = word.Remove(2, 1);

            Console.WriteLine("Измененное слово:");
            Console.WriteLine(modifiedWord);
        }
        else
        {
            Console.WriteLine("Слово слишком короткое для удаления буквы.");
        }
    }
}
