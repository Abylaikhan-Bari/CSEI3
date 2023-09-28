using System;

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int maxEvenIndex = FindMaxEvenIndex(integerArray);

        if (maxEvenIndex != -1)
        {
            Console.WriteLine($"Индекс максимального четного значения в массиве: {maxEvenIndex}");
        }
        else
        {
            Console.WriteLine("В массиве нет четных значений.");
        }
    }

    static int FindMaxEvenIndex(int[] array)
    {
        int maxEvenIndex = -1;
        int maxEvenValue = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0 && array[i] > maxEvenValue)
            {
                maxEvenIndex = i;
                maxEvenValue = array[i];
            }
        }

        return maxEvenIndex;
    }
}
