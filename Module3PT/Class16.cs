using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 5, 9, 4, 2, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minValue, maxValue;
        FindMinAndMax(array, out minValue, out maxValue);

        int difference = maxValue - minValue;
        Console.WriteLine($"Минимальный элемент: {minValue}");
        Console.WriteLine($"Максимальный элемент: {maxValue}");
        Console.WriteLine($"Разность максимального и минимального элементов: {difference}");
    }

    static void FindMinAndMax(int[] array, out int min, out int max)
    {
        if (array.Length == 0)
        {
            min = max = 0;
            return;
        }

        min = max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            else if (array[i] > max)
            {
                max = array[i];
            }
        }
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
