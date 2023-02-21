Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

void Sum(int num)
{
    int sum = 0;
    foreach(int numb in NumToArray(num, CountOfDigits(num)))
    {
        sum += numb;
    }
    Console.WriteLine(sum);
}

int CountOfDigits(int num)
{
    int count = 0;
    for(count = 1; num/10 != 0; count++) num /= 10;
    return count;
}

int[] NumToArray(int num, int count)
{
    int[] numArr = new int[count];
    for(int i = 0; i <= count-1; i++)
    {
        numArr[i] = num%10;
        num /= 10;
    }
    return numArr;
}
Sum(num);