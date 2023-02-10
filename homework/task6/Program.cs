Console.WriteLine("Введите число");
isdigit(Convert.ToInt32(Console.ReadLine()));

void isdigit(int num) 
{
    if(num%2 == 0)
    {
        Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}