using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 2, 3, 3, 4, 5, 5, 6, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(integerArray);

        int[] newArray = RemoveElementsWithExactlyTwoOccurrences(integerArray);

        Console.WriteLine("Массив после удаления элементов, которые встречаются ровно два раза:");
        PrintArray(newArray);
    }

    static int[] RemoveElementsWithExactlyTwoOccurrences(int[] array)
    {
        Dictionary<int, int> elementCounts = new Dictionary<int, int>();

        foreach (int element in array)
        {
            if (elementCounts.ContainsKey(element))
            {
                elementCounts[element]++;
            }
            else
            {
                elementCounts[element] = 1;
            }
        }

        List<int> result = new List<int>();

        foreach (int element in array)
        {
            if (elementCounts[element] != 2)
            {
                result.Add(element);
            }
        }

        return result.ToArray();
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
