using System;

public class MyArray
{
    private int[] array;

    public MyArray(int[] values)
    {
        array = values;
    }

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            throw new IndexOutOfRangeException("Index is out of range.");
        }
        set
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }

    public int Size => array.Length;

    public static MyArray operator *(MyArray array1, MyArray array2)
    {
        if (array1.Size != array2.Size)
        {
            throw new InvalidOperationException("Arrays must have the same size for multiplication.");
        }

        int[] result = new int[array1.Size];
        for (int i = 0; i < array1.Size; i++)
        {
            result[i] = array1[i] * array2[i];
        }

        return new MyArray(result);
    }

    public static bool operator ==(MyArray array1, MyArray array2)
    {
        if (array1.Size != array2.Size)
        {
            return false;
        }

        for (int i = 0; i < array1.Size; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool operator !=(MyArray array1, MyArray array2)
    {
        return !(array1 == array2);
    }

    public static bool operator <=(MyArray array1, MyArray array2)
    {
        if (array1.Size != array2.Size)
        {
            throw new InvalidOperationException("Arrays must have the same size for comparison.");
        }

        for (int i = 0; i < array1.Size; i++)
        {
            if (array1[i] > array2[i])
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        MyArray array1 = new MyArray(new int[] { 1, 2, 3 });
        MyArray array2 = new MyArray(new int[] { 4, 5, 6 });

        MyArray multiplication = array1 * array2;
        Console.WriteLine("Multiplication result: " + string.Join(", ", multiplication));

        bool areEqual = array1 == array2;
        Console.WriteLine("Are arrays equal? " + areEqual);

        bool lessOrEqual = array1 <= array2;
        Console.WriteLine("Is array1 less than or equal to array2? " + lessOrEqual);
    }
}
