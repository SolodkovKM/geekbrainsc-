using ClassesLibrary;
namespace Test
{
    class Program
    {
        static int Sum(params int[] parameters)
        {
            int result = 0;
            for(int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            const int LENGTH = 10;
            int[] filled_array = new int[LENGTH];
            $"Int Array: [{string.Join(", ", filled_array.FillArray(LENGTH, -10, 10))}]".Print();
            $"Double Array: [{string.Join(", ", filled_array.FillArray(LENGTH, 10).Select(x=> Math.Round(x, 2)))}]".Print();
            $"Char Array: [{string.Join(", ", filled_array.FillArray(LENGTH))}]".Print();
        }
    }
}