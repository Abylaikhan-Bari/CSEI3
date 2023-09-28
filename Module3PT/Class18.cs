using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 5, 9, 4, 2, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minOddIndexValue = FindMinValueAtOddIndexes(array);

        Console.WriteLine($"Минимальное значение среди элементов с нечетными индексами: {minOddIndexValue}");
    }

    static int FindMinValueAtOddIndexes(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        int min = array[0];

        for (int i = 2; i < array.Length; i += 2)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
