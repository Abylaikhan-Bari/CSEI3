using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 5, 9, 4, 2, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double average = CalculateAverage(array);
        Console.WriteLine($"Среднее арифметическое элементов массива: {average}");

        Console.WriteLine("Элементы больше среднего арифметического:");
        PrintElementsGreaterThanAverage(array, average);
    }

    static double CalculateAverage(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        int sum = 0;

        foreach (int element in array)
        {
            sum += element;
        }

        return (double)sum / array.Length;
    }

    static void PrintElementsGreaterThanAverage(int[] array, double average)
    {
        foreach (int element in array)
        {
            if (element > average)
            {
                Console.Write(element + " ");
            }
        }
        Console.WriteLine();
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
