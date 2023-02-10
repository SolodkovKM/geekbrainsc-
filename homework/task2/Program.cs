Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
findmax(a, b);
void findmax(int a, int b)
{
    if(a > b) {
        Console.WriteLine("max: " + a + " min: " + b);
    }
    else {
        Console.WriteLine("max: " + b + " min: " + a);
    }
}