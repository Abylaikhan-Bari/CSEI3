using System;

class Program
{
    static void Main()
    {
        double[] array = { 3.0, 9.0, 8.0, 4.0, 5.0, 1.0 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double maxElement = FindMaxElement(array);

        if (maxElement != 0.0)
        {
            DivideArrayByMaxElement(array, maxElement);

            Console.WriteLine("Массив после деления на наибольший элемент:");
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("Массив пустой или все элементы равны нулю.");
        }
    }

    static double FindMaxElement(double[] array)
    {
        if (array.Length == 0)
        {
            return 0.0; // Возвращаем 0, если массив пустой
        }

        double max = array[0];

        foreach (double element in array)
        {
            if (element > max)
            {
                max = element;
            }
        }

        return max;
    }

    static void DivideArrayByMaxElement(double[] array, double maxElement)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= maxElement;
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
