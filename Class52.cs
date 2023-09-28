using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        ZeroColumnsWithEvenDiagonalElement(matrix);

        Console.WriteLine("Матрица после обнуления столбцов:");
        PrintMatrix(matrix);
    }

    static void ZeroColumnsWithEvenDiagonalElement(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            if (matrix[i, i] % 2 == 0)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    matrix[j, i] = 0;
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
