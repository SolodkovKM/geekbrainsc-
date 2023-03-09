// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// rows {0, 0, 0, 0, 1, 2, 3, 3, 3, 3, 2, 1, 1, 1, 2, 2}
// cols {0, 1, 2, 3, 3, 3, 3, 2, 1, 0, 0, 0, 1, 2, 2, 1}
// 10 9 8 7

using ClassesLibrary;

void SpiralFillMatrix(int[,] matrix)
{
    int[] rows = new int[16] {0, 0, 0, 0, 1, 2, 3, 3, 3, 3, 2, 1, 1, 1, 2, 2};//WayLogic(matrix).Item1;
    int[] cols = new int[16] {0, 1, 2, 3, 3, 3, 3, 2, 1, 0, 0, 0, 1, 2, 2, 1};//WayLogic(matrix).Item2;
    int num = 1;
    for (int i = 0; i < rows.Length; i++)
    {
        matrix[rows[i], cols[i]] = num;
        num++;
    }
}

// (int[], int[]) WayLogic(int[,] matrix)
// {
//     int[] rows = new int[16];
//     int[] cols = new int[matrix.GetLength(1)];
//     int num = 0;
//     for(int i = 0; i < rows.Length; i++)
//     {
//         if(i < matrix.GetLength(0))
//         {
//             rows[i] = num;
//         }
//         else if(i <= matrix.GetLength(0) + matrix.GetLength(1))
//         {
//             rows[i] = num;
//             num++;
//         }
//         else if(i <= matrix.GetLength(0) * 2 + matrix.GetLength(1))
//         {
//             rows[i] = num;
//         }
//         else if(i <= matrix.GetLength(0)*2 + matrix.GetLength(1) * 2)
//         {
//             rows[i] = num;
//             num--;
//         }
//     }
//     return (rows, cols);
// }

int[,] matrix = new int[4, 4];
SpiralFillMatrix(matrix);
ArrayExtention.PrintMatrix(matrix);