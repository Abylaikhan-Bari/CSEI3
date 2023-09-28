using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 9, 8, 4, 5, 1 };

        Console.WriteLine("Элементы массива, которые больше элементов, стоящих перед ними:");
        FindElementsGreaterThanPrevious(array);
    }

    static void FindElementsGreaterThanPrevious(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
