//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int[,] matrix = new int[,]
{
    {4,4,2,5,3},
    {3,5,6,4,2},
    {5,3,5,1,4}
};

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

(int, int) FindRowColWithMinValue(int[,] matrix)
{
    int colMin = 0;
    int rowMin = 0;
    int minValue = matrix[colMin, rowMin];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                colMin = i;
                rowMin = j;
            }
        }
    }
    return (colMin, rowMin);
}

int[,] RemoveFoundedColRow(int[,] matrix, int colMin, int rowMin)
{
    int[,] eMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < eMatrix.GetLength(0); i++)
    {
        int row = 0;
        int col = 0;
        if(i == rowMin)
        {
            row++;
        }
        for(int j = 0; j < eMatrix.GetLength(1); j++)
        {
            if(j == colMin+1)
            {
                col++;
            }
            eMatrix[i,j] = matrix[i+row, j+col];
        }

    }
    return eMatrix;
}

(int colMin, int rowMin) = FindRowColWithMinValue(matrix);
int[,] eMatrix = RemoveFoundedColRow(matrix, colMin, rowMin);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(eMatrix);