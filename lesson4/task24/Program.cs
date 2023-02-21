Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

void sum(int num)
{
    int sum = 0;
    for(int i = 0; i <= num; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
}
sum(number);