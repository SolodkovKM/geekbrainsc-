using ClassesLibrary;

int m = "Введите индекс строки".PrintGet();
int n = "Введите индекс столбца".PrintGet();

int[,] matrix =  ArrayExtention.FillMatrix(5, 5, 0, 10);

string FindElement(int[,] matrix, int m, int n) => (m < matrix.GetLength(1) && n < matrix.GetLength(0)) ? matrix[m,n].ToString(): "Элемент не найден";
ArrayExtention.PrintMatrix(matrix);
FindElement(matrix, m, n).Print();