using System;

class Program
{
    static void Main()
    {
        int[] array = { -3, 0, 5, -2, 7, 1 };

        FindFirstPositiveElement(array);
    }

    static void FindFirstPositiveElement(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                Console.WriteLine("Номер первого положительного элемента: " + i);
                Console.WriteLine("Значение первого положительного элемента: " + array[i]);
                return; // Прерываем цикл после нахождения первого положительного элемента
            }
        }

        Console.WriteLine("В массиве нет положительных элементов.");
    }
}
