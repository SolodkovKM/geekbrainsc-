Console.WriteLine("Введите 8 чисел через Enter");
int[] FillArray()
{
    int[] arr = new int[8];
    for(int i = 0; i < 8; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void EchoArray(int[] array)
{
    Console.WriteLine($"[{string.Join(',',array)}]");
}

EchoArray(FillArray());