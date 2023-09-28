using System;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int maxIndex = FindMaxIndex(integerArray);

        Console.WriteLine($"Индекс максимального значения в массиве: {maxIndex}");
    }

    static int FindMaxIndex(int[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым.");
        }

        int maxIndex = 0;
        int maxValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxIndex = i;
                maxValue = array[i];
            }
        }

        return maxIndex;
    }
}
