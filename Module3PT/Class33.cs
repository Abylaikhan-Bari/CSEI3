using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        int indexOfA = sentence.IndexOf('а');

        if (indexOfA != -1)
        {
            Console.WriteLine("Буква 'а' есть в предложении.");
            Console.WriteLine("Порядковый номер первой буквы 'а': " + (indexOfA + 1));
        }
        else
        {
            Console.WriteLine("Буквы 'а' нет в предложении.");
        }
    }
}
