using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        try
        {
            // Attempt to access elements beyond the array bounds
            for (int i = 0; i <= numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Array processing completed.");
        }

        Console.ReadKey();
    }
}
