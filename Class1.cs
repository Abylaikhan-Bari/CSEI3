using System;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Массив целых чисел:");

        foreach (int number in integerArray)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine(); // Для перехода на новую строку после вывода массива.
    }
}
