// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int sum = 0;
void SumOfNumbers(int n)
{
    if (n / 10 > 0)
    {
        SumOfNumbers(n / 10);
    }
    sum += n % 10;
}
int SumOf(int n)
{
    if(n == 0) return 0;
    return n % 10 + SumOf(n / 10);
}

SumOfNumbers(453);
System.Console.WriteLine(sum);
System.Console.WriteLine(SumOf(453));