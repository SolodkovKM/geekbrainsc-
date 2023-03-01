namespace ClassesLibrary{

    public static class PrintExtentions
    {
        public static int PrintGet(this String message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void Print(this Int32 num)
        {
            Console.WriteLine(num);
        }
        public static void Print(this String text)
        {
            Console.WriteLine(text);
        }
    }
    public static class ArrayExtention
    {
        static void Main(string[] args) { }
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
}