Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
void cube(int num) 
{
    for(int i = 1; i <= num; i ++ )
    {
        Console.Write($"{i*i*i} ");
    }
}
cube(number);