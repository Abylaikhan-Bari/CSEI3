using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, -5, 9, -2, 4, -3, 2, -6, 7, -8 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double averageOfNegatives = CalculateAverageOfNegatives(array);
        Console.WriteLine($"Среднее арифметическое отрицательных элементов: {averageOfNegatives}");

        ReplaceMinWithAverage(array, averageOfNegatives);

        Console.WriteLine("Массив после замены минимального элемента:");
        PrintArray(array);
    }

    static double CalculateAverageOfNegatives(int[] array)
    {
        int sum = 0;
        int count = 0;

        foreach (int element in array)
        {
            if (element < 0)
            {
                sum += element;
                count++;
            }
        }

        if (count > 0)
        {
            return (double)sum / count;
        }
        else
        {
            return 0;
        }
    }

    static void ReplaceMinWithAverage(int[] array, double average)
    {
        int minIndex = 0;
        int minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minIndex = i;
                minValue = array[i];
            }
        }

        array[minIndex] = (int)Math.Round(average);
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
