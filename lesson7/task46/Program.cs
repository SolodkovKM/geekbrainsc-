using ClassesLibrary;

int m = "Введите количество строк".PrintGet();
int n = "Введите количество столбцов".PrintGet();

int[,] matrix =  ArrayExtention.FillMatrix(m, n, 0, 100);

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
PrintMatrix(matrix);