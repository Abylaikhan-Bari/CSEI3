using System;
using System.Linq;

public class ArrayContainer
{
    private int[] numbers;

    public ArrayContainer(int[] values)
    {
        numbers = values;
    }

    public int SumOfElements => numbers.Sum();

    public static bool operator <(ArrayContainer left, ArrayContainer right)
    {
        return left.SumOfElements < right.SumOfElements;
    }

    public static bool operator >(ArrayContainer left, ArrayContainer right)
    {
        return left.SumOfElements > right.SumOfElements;
    }
}

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        ArrayContainer container1 = new ArrayContainer(array1);
        ArrayContainer container2 = new ArrayContainer(array2);

        bool isContainer1Smaller = container1 < container2;
        bool isContainer2Smaller = container1 > container2;

        Console.WriteLine($"Container 1 < Container 2: {isContainer1Smaller}");
        Console.WriteLine($"Container 1 > Container 2: {isContainer2Smaller}");
    }
}
