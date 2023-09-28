using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arrayM = { 1, 2, 3, 4, 5 };
        int[] arrayN = { 3, 4, 5, 6, 7 };

        int[] commonElements = FindCommonElements(arrayM, arrayN);

        Console.WriteLine("Common elements without duplicates:");
        foreach (int element in commonElements)
        {
            Console.Write(element + " ");
        }
    }

    static int[] FindCommonElements(int[] arrayM, int[] arrayN)
    {
        var commonElements = arrayM.Intersect(arrayN).Distinct().ToArray();
        return commonElements;
    }
}
