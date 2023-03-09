// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

using ClassesLibrary;

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] MMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < MMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MMatrix.GetLength(1); j++)
        {
            MMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return MMatrix;
}


int[,] matrix1 = ArrayExtention.FillMatrix(4, 4, 1, 10);
int[,] matrix2 = ArrayExtention.FillMatrix(4, 4, 1, 10);
ArrayExtention.PrintMatrix(matrix1);
Console.WriteLine();
ArrayExtention.PrintMatrix(matrix2);
Console.WriteLine();
ArrayExtention.PrintMatrix(MatrixMultiply(matrix1, matrix2));