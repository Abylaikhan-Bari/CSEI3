using System;

class Program
{
    static void Main()
    {
        double[] array = { 10.0, 5.0, 15.0, 2.0, 7.0, 20.0 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double average = CalculateAverage(array);
        Console.WriteLine($"Среднее значение элементов массива: {average}");

        double deviationThreshold = 0.5; // 50% отклонение

        Console.WriteLine("Элементы, сильно отклоняющиеся от среднего значения:");
        FindAndPrintDeviantElements(array, average, deviationThreshold);
    }

    static double CalculateAverage(double[] array)
    {
        double sum = 0;

        foreach (double element in array)
        {
            sum += element;
        }

        return sum / array.Length;
    }

    static void FindAndPrintDeviantElements(double[] array, double average, double threshold)
    {
        for (int i = 0; i < array.Length; i++)
        {
            double deviation = Math.Abs(array[i] - average) / average;

            if (deviation > threshold)
            {
                Console.WriteLine($"Элемент с индексом {i}: {array[i]}, Отклонение: {deviation:P}");
            }
        }
    }

    static void PrintArray(double[] array)
    {
        foreach (double element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
