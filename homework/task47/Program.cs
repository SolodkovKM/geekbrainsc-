using ClassesLibrary;

int rows = "Введите количество строк".PrintGet();
int columns = "Введите количество столбцов".PrintGet();

double[,] FillMatrix(int rows, int columns, int range = 10)
{
    double[,] matrix = new double[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.NextDouble() * range ;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i,j], 2) + " ");
        }
        Console.WriteLine();
    }
}
double[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);