// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

using ClassesLibrary;

void SortRow(int[] array)
{
    Array.Sort(array);
}

void SortMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = new int[matrix.GetLength(1)];
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i,j];
        }
        SortRow(row);
        for(int k = 0; k < row.Length; k++)
        {
            matrix[i,k] = row[k];
        }
    }
}

int[,] matrix = ArrayExtention.FillMatrix(7, 9);
ArrayExtention.PrintMatrix(matrix);
SortMatrix(matrix);
System.Console.WriteLine();
ArrayExtention.PrintMatrix(matrix);