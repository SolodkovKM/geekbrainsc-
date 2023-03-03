using System.Security.Cryptography.X509Certificates;

namespace ClassesLibrary{

    public static class PrintExtentions
    {
        public static int PrintGet(this String message)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out int num)) return num;
            else
            {
                string error = "It's not number, try again";
                PrintGet(error);
                return 0;
            }
        }
        public static void Print(this Int32 num) {Console.WriteLine(num);}
        public static void Print(this String text){Console.WriteLine(text);}
        public static void Print(this Boolean booltext){Console.WriteLine(booltext);}
        public static string PrintArray(this Array array) => string.Join(", ", array);
    }
    public static class ArrayExtention
    {
        static void Main(string[] args){}
        public static int[,] FillMatrix(int length_x, int length_y, int leftnum = 0, int rightnum = 10)
        {
            int[,] matrix = new int[length_y, length_y];
            for(int i = 0; i < length_y; i++)
            {
                for(int j = 0; j < length_x; j++)
                {
                    matrix[i,j] = Random.Shared.Next(leftnum, rightnum);
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
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
        public static double[] FillArray(this Array array, int length, double range)
        {
            double[] rand_arr = new double[length];
            for (int i = 0; i < rand_arr.Length; i++)
            {
                rand_arr[i] = Random.Shared.NextDouble()* range;
            }
            return rand_arr;
        }
        public static int[] FillArray(this Array array, int length, int leftnum, int rightnum)
        {
            int[] rand_arr = new int[length];
            for (int i = 0; i < rand_arr.Length; i++)
            {
                rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
            }
            return rand_arr;
        }
        public static char[] FillArray(this Array array, int length)
        {
            char[] rand_arr = new char[length];
            for(int i = 0; i < rand_arr.Length; i++)
            {
                rand_arr[i] =(char)(Random.Shared.Next(0, 256) + '0');
            }
            return rand_arr;
        }
    }
    public static class IntExstention
    {
        public static bool IsEven(this int v) => v % 2 == 0;
    }
}