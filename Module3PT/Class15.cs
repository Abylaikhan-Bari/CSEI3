using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 10, 3, 7, 2, 8 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SwapMinAndMax(array);

        Console.WriteLine("Массив после замены минимального и максимального элементов:");
        PrintArray(array);
    }

    static void SwapMinAndMax(int[] array)
    {
        if (array.Length == 0)
        {
            return; // Ничего не делаем, если массив пустой
        }

        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
            else if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        int minValue = array[minIndex];
        array[minIndex] = array[maxIndex];
        array[maxIndex] = minValue;
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
