using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        if (word.Length >= 5)
        {
            char[] wordArray = word.ToCharArray();

            // Поменять местами вторую (индекс 1) и пятую (индекс 4) буквы
            char temp = wordArray[1];
            wordArray[1] = wordArray[4];
            wordArray[4] = temp;

            string modifiedWord = new string(wordArray);

            Console.WriteLine("Измененное слово:");
            Console.WriteLine(modifiedWord);
        }
        else
        {
            Console.WriteLine("Слово слишком короткое для обмена буквами.");
        }
    }
}
