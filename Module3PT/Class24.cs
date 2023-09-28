using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int N = int.Parse(Console.ReadLine());

        double[] array = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        double maxAbsoluteValue = FindMaxAbsoluteValue(array);

        Console.WriteLine($"Maximum absolute value in the array: {maxAbsoluteValue}");
    }

    static double FindMaxAbsoluteValue(double[] array)
    {
        double maxAbsoluteValue = Math.Abs(array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            double absoluteValue = Math.Abs(array[i]);

            if (absoluteValue > maxAbsoluteValue)
            {
                maxAbsoluteValue = absoluteValue;
            }
        }

        return maxAbsoluteValue;
    }
}
