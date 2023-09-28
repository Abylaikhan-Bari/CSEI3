using System;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5 };
        int indexToRemove = 2; // Индекс элемента для удаления

        Console.WriteLine("Исходный массив:");
        PrintArray(integerArray);

        if (indexToRemove >= 0 && indexToRemove < integerArray.Length)
        {
            integerArray = RemoveElementByIndex(integerArray, indexToRemove);
            Console.WriteLine("Массив после удаления элемента:");
            PrintArray(integerArray);
        }
        else
        {
            Console.WriteLine("Некорректный индекс для удаления элемента.");
        }
    }

    static int[] RemoveElementByIndex(int[] array, int index)
    {
        int[] newArray = new int[array.Length - 1];
        int newArrayIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                newArray[newArrayIndex] = array[i];
                newArrayIndex++;
            }
        }

        return newArray;
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
