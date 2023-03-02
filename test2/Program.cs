using ClassesLibrary;
namespace Test
{
    class Program
    {
        const int LENGTH = 10;
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
            int[] filled_array = new int[LENGTH];
            $"Int Array: [{string.Join(", ", filled_array.FillArray(LENGTH, -10, 10))}]".Print();
            $"Double Array: [{string.Join(", ", filled_array.FillArray(LENGTH, 10).Select(x=> Math.Round(x, 2)))}]".Print();
            $"Char Array: [{string.Join(", ", filled_array.FillArray(LENGTH))}]".Print();
            5.IsEven().Print();
            4.IsEven().Print();
        }
    }
}