using System;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5 };
        int valueToInsert = 6; // Значение элемента для вставки
        int indexToInsert = 2; // Индекс, по которому нужно вставить элемент

        Console.WriteLine("Исходный массив:");
        PrintArray(integerArray);

        integerArray = InsertElementByIndex(integerArray, valueToInsert, indexToInsert);

        Console.WriteLine("Массив после вставки элемента:");
        PrintArray(integerArray);
    }

    static int[] InsertElementByIndex(int[] array, int value, int index)
    {
        int[] newArray = new int[array.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        newArray[index] = value;

        for (int i = index; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
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
