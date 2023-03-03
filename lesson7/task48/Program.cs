using ClassesLibrary;

int m = "Введите количество строк".PrintGet();
int n = "Введите количество столбцов".PrintGet();

int[,] FillMatrix(int length_x, int length_y)
{
    int[,] matrix = new int[length_y, length_x];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(FillMatrix(m,n));