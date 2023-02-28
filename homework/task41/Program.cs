Console.WriteLine("Введите длинну массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int count = 0;
for(int i = 0; i < length; i++)
{
    Console.WriteLine("Введите число");
    if(!int.TryParse(Console.ReadLine(), out int n))
    {
        Console.WriteLine("Это не число");
        i--;
    }
    else
    {
        array[i] = n;
        if(array[i] > 0) count++;
    }
}
Console.WriteLine($"[{string.Join(",",array)}] -> {count}");