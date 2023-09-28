using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введите номер элемента K (от 0 до " + (size - 1) + "): ");
        int K = int.Parse(Console.ReadLine());

        if (K < 0 || K >= size)
        {
            Console.WriteLine("Некорректный номер элемента K.");
            return;
        }

        int sum1 = SumFromStartToK(array, K);
        int sum2 = SumFromKPlus1ToEnd(array, K);

        if (sum1 > sum2)
        {
            Console.WriteLine($"Сумма элементов от начала до элемента с номером {K} больше.");
        }
        else if (sum1 < sum2)
        {
            Console.WriteLine($"Сумма элементов от элемента с номером {K + 1} до конца больше.");
        }
        else
        {
            Console.WriteLine($"Суммы равны.");
        }
    }

    static int SumFromStartToK(int[] array, int K)
    {
        int sum = 0;
        for (int i = 0; i <= K; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int SumFromKPlus1ToEnd(int[] array, int K)
    {
        int sum = 0;
        for (int i = K + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}
