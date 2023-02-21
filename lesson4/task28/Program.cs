Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int factor(int num)
{
    int fact = 1;
    int i = 1;
    while(i <= num)
    {
        fact *= i;
        i++;
    }
    return fact;
}

Console.WriteLine($"{num} -> {factor(num)}");
