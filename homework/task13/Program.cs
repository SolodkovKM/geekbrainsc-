Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    int result = num;
    for(int i = 10; result > 1000;)
    {
        result = result / i;
    }
    Console.WriteLine($"{num} -> {result % 10}");
}
else Console.WriteLine("нет 3 цифры");