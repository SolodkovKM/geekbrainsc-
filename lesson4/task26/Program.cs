Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count(int num)
{
    int count = 1;
    do
    {
        num /= 10;
        count++;
    }
    while(num / 10 > 0);
    return count;
}

Console.WriteLine($"{number} -> {count(number)}");