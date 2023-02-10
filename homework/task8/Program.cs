Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i <= x; i = i + 2)
{
    Console.Write(i + " ");
}