using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, -5, 9, 4, -2, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int positiveCount = CountPositiveElements(array);
        Console.WriteLine($"Количество положительных элементов: {positiveCount}");
    }

    static int CountPositiveElements(int[] array)
    {
        int count = 0;

        foreach (int element in array)
        {
            if (element > 0)
            {
                count++;
            }
        }

        return count;
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
