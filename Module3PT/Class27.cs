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

        int sum = 0;
        int product = 1;

        foreach (int element in array)
        {
            sum += element;
            product *= element;
        }

        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Произведение элементов массива: {product}");
    }
}
