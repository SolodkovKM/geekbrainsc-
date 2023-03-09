// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] cube = new int[2,2,2] 
{
    {
        {12,34},
        {22,53}
    },
    {
        {45,87},
        {65,87}
    }
};

void ShowArraysOfCube(int[,,] cube)
{
    for(int i = 0; i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for(int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
ShowArraysOfCube(cube);