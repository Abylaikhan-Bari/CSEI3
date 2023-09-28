using System;

class Program
{
    static void Main()
    {
        double[] arrayA = { 3.5, -1.2, 5.7, -2.3, 4.8, -3.1, 2.4, -6.5, 7.2, -8.9, 9.1, -0.6, 1.7, -2.8, 3.9, -4.0, 5.1, -6.2, 7.3, -8.4 };

        Console.WriteLine("Исходный массив A:");
        PrintArray(arrayA);

        double[] arrayB = FilterPositiveElementsWithEvenIndex(arrayA);

        Console.WriteLine("Массив B из положительных элементов массива A с четным индексом:");
        PrintArray(arrayB);

        double sumOfSquares = CalculateSumOfSquares(arrayB);
        Console.WriteLine($"Сумма квадратов элементов массива B: {sumOfSquares}");
    }

    static double[] FilterPositiveElementsWithEvenIndex(double[] array)
    {
        int count = 0;

        foreach (double element in array)
        {
            if (element > 0 && count % 2 == 0)
            {
                count++;
            }
        }

        double[] resultArray = new double[count];
        int index = 0;

        foreach (double element in array)
        {
            if (element > 0 && index % 2 == 0)
            {
                resultArray[index] = element;
                index++;
            }
        }

        return resultArray;
    }

    static double CalculateSumOfSquares(double[] array)
    {
        double sum = 0;

        foreach (double element in array)
        {
            sum += element * element;
        }

        return sum;
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
