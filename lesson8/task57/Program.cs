int[,] matrix = new int[,]
{
    {0,4,2,5,3}, 
    {3,5,6,4,2},
    {5,3,5,1,4}
};

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
int[] CounterDictionary = new int[10];

void Dictionary(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < CounterDictionary.Length; k++)
            {
                CounterDictionary[matrix[i,j]] ++;
            }
        }
    }
}

void PrinCounter(int[] dictionary)
{
    for(int i = 0; i < dictionary.Length; i++)
    {
        if(dictionary[i] != 0)
        {
            Console.WriteLine($"{i} -> {dictionary[i]}");
        }
    }
}

PrintMatrix(matrix);
Dictionary(matrix);
PrinCounter(CounterDictionary);