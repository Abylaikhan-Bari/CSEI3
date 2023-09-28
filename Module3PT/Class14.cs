using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, -5, 0, 3, -4 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        InvertArrayElements(array);

        Console.WriteLine("Массив после замены элементов на противоположные по знаку:");
        PrintArray(array);
    }

    static void InvertArrayElements(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -array[i];
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
