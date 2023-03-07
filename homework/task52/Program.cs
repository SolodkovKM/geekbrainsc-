using ClassesLibrary;
using System.Linq;
int[,] matrix = ArrayExtention.FillMatrix(5, 5);
double[] FindAgrColumns(int[,] matrix)
{
    double[] agr = new double[matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        double sumarg = 0;
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sumarg += matrix[j,i];
            if(j == matrix.GetLength(0)-1)
            {
                agr[i] = sumarg / Convert.ToDouble(j+1);
            }
        }
    }
    return agr;
}



ArrayExtention.PrintMatrix(matrix);
Console.WriteLine(string.Join(" ", FindAgrColumns(matrix).Select(x => string.Format("{0:0.00}", x))));

double x = 2.000;
Console.WriteLine(string.Format("{0:0.00}", x));
