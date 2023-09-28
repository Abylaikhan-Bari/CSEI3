using System;

class Program
{
    static void Main()
    {
        double[] arrayA = new double[5];
        double[,] arrayB = new double[3, 4];

        FillArrayA(arrayA);
        FillArrayB(arrayB);

        PrintArrayA(arrayA);
        PrintArrayB(arrayB);

        double commonMax = FindCommonMax(arrayA, arrayB);
        double commonMin = FindCommonMin(arrayA, arrayB);
        double commonSum = FindCommonSum(arrayA, arrayB);
        double commonProduct = FindCommonProduct(arrayA, arrayB);
        double evenSumArrayA = FindEvenSumArrayA(arrayA);
        double oddColumnSumArrayB = FindOddColumnSumArrayB(arrayB);

        Console.WriteLine("Common maximum element: " + commonMax);
        Console.WriteLine("Common minimum element: " + commonMin);
        Console.WriteLine("Common sum of all elements: " + commonSum);
        Console.WriteLine("Common product of all elements: " + commonProduct);
        Console.WriteLine("Sum of even elements in array A: " + evenSumArrayA);
        Console.WriteLine("Sum of odd columns in array B: " + oddColumnSumArrayB);
    }

    static void FillArrayA(double[] arrayA)
    {
        Console.WriteLine("Enter 5 numbers for array A:");
        for (int i = 0; i < 5; i++)
        {
            arrayA[i] = double.Parse(Console.ReadLine());
        }
    }

    static void FillArrayB(double[,] arrayB)
    {
        Random rand = new Random();
        Console.WriteLine("Array B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                arrayB[i, j] = rand.NextDouble();
            }
        }
    }

    static void PrintArrayA(double[] arrayA)
    {
        Console.WriteLine("Array A:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(arrayA[i] + " ");
        }
        Console.WriteLine();
    }

    static void PrintArrayB(double[,] arrayB)
    {
        Console.WriteLine("Array B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arrayB[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static double FindCommonMax(double[] arrayA, double[,] arrayB)
    {
        double maxArrayA = arrayA[0];
        double maxArrayB = arrayB[0, 0];
        foreach (var item in arrayA)
        {
            if (item > maxArrayA)
            {
                maxArrayA = item;
            }
        }
        foreach (var item in arrayB)
        {
            if (item > maxArrayB)
            {
                maxArrayB = item;
            }
        }
        return Math.Max(maxArrayA, maxArrayB);
    }

    static double FindCommonMin(double[] arrayA, double[,] arrayB)
    {
        double minArrayA = arrayA[0];
        double minArrayB = arrayB[0, 0];
        foreach (var item in arrayA)
        {
            if (item < minArrayA)
            {
                minArrayA = item;
            }
        }
        foreach (var item in arrayB)
        {
            if (item < minArrayB)
            {
                minArrayB = item;
            }
        }
        return Math.Min(minArrayA, minArrayB);
    }

    static double FindCommonSum(double[] arrayA, double[,] arrayB)
    {
        double sumArrayA = 0;
        double sumArrayB = 0;
        foreach (var item in arrayA)
        {
            sumArrayA += item;
        }
        foreach (var item in arrayB)
        {
            sumArrayB += item;
        }
        return sumArrayA + sumArrayB;
    }

    static double FindCommonProduct(double[] arrayA, double[,] arrayB)
    {
        double productArrayA = 1;
        double productArrayB = 1;
        foreach (var item in arrayA)
        {
            productArrayA *= item;
        }
        foreach (var item in arrayB)
        {
            productArrayB *= item;
        }
        return productArrayA * productArrayB;
    }

    static double FindEvenSumArrayA(double[] arrayA)
    {
        double evenSumArrayA = 0;
        foreach (var item in arrayA)
        {
            if (item % 2 == 0)
            {
                evenSumArrayA += item;
            }
        }
        return evenSumArrayA;
    }

    static double FindOddColumnSumArrayB(double[,] arrayB)
    {
        double oddColumnSumArrayB = 0;
        for (int j = 0; j < 4; j++)
        {
            double columnSum = 0;
            for (int i = 0; i < 3; i++)
            {
                columnSum += arrayB[i, j];
            }
            if (j % 2 != 0)
            {
                oddColumnSumArrayB += columnSum;
            }
        }
        return oddColumnSumArrayB;
    }
}
