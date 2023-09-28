using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        double average = CalculateAverageOfEvenAtOddIndices(array);

        Console.WriteLine($"Average of even elements at odd indices: {average}");
    }

    static double CalculateAverageOfEvenAtOddIndices(int[] array)
    {
        int sum = 0;
        int count = 0;

        for (int i = 1; i < array.Length; i += 2) // Start from index 1 (odd indices)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
                count++;
            }
        }

        if (count == 0)
        {
            return 0.0; // Avoid division by zero
        }

        return (double)sum / count;
    }
}
