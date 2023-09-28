using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random random = new Random();

        // Fill the array with random numbers in the range from -100 to 100
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("Original Array:");
        PrintArray(array);

        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        // Find the minimum and maximum elements and their positions
        int minElement = array[0, 0];
        int maxElement = array[0, 0];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }

                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        int sum = 0;

        // Calculate the sum of elements between the minimum and maximum elements
        for (int i = Math.Min(minRow, maxRow); i <= Math.Max(minRow, maxRow); i++)
        {
            for (int j = Math.Min(minCol, maxCol); j <= Math.Max(minCol, maxCol); j++)
            {
                sum += array[i, j];
            }
        }

        Console.WriteLine("Minimum Element: " + minElement);
        Console.WriteLine("Maximum Element: " + maxElement);
        Console.WriteLine("Sum of Elements between Min and Max: " + sum);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
