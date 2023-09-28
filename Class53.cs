using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 10},
            {13, 14, 15, 16}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        RemoveColumnsWithDuplicateElements(matrix);

        Console.WriteLine("Матрица после удаления столбцов:");
        PrintMatrix(matrix);
    }

    static void RemoveColumnsWithDuplicateElements(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        List<int> columnsToRemove = new List<int>();

        for (int col = 0; col < colCount; col++)
        {
            HashSet<int> uniqueElements = new HashSet<int>();

            for (int row = 0; row < rowCount; row++)
            {
                int currentElement = matrix[row, col];

                if (uniqueElements.Contains(currentElement))
                {
                    columnsToRemove.Add(col);
                    break;
                }

                uniqueElements.Add(currentElement);
            }
        }

        // Remove the columns in reverse order to avoid shifting column indices
        columnsToRemove.Sort();
        columnsToRemove.Reverse();

        foreach (int colToRemove in columnsToRemove)
        {
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = colToRemove; col < colCount - 1; col++)
                {
                    matrix[row, col] = matrix[row, col + 1];
                }
            }
            colCount--; // Decrease the column count
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
