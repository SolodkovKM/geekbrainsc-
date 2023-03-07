int[,] matrix = new int[,]
{
    {0,4,2,5,3}, 
    {3,5,6,4,2},
    {5,3,5,1,4}
};

void TransMatrix(int[,] matrix)
{
    int[,] tMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for(int i = 0; i < tMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tMatrix.GetLength(1); j++)
        {
            tMatrix[i,j] = matrix[j,i];
        }
    }
    PrintMatrix(tMatrix);
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

PrintMatrix(matrix);
Console.WriteLine();
TransMatrix(matrix);