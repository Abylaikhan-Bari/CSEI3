using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, -5, -2, 4, -8, 0 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int sum = SumOfEvenNegativeElements(array);

        Console.WriteLine($"Сумма четных отрицательных элементов: {sum}");
    }

    static int SumOfEvenNegativeElements(int[] array)
    {
        int sum = 0;

        foreach (int element in array)
        {
            if (element < 0 && element % 2 == 0)
            {
                sum += element;
            }
        }

        return sum;
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
