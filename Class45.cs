using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5 };
        int valueToRemove = 3; // Значение элемента для удаления

        Console.WriteLine("Исходный массив:");
        PrintArray(integerArray);

        integerArray = RemoveElementsByValue(integerArray, valueToRemove);

        Console.WriteLine("Массив после удаления элементов:");
        PrintArray(integerArray);
    }

    static int[] RemoveElementsByValue(int[] array, int value)
    {
        return array.Where(element => element != value).ToArray();
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
