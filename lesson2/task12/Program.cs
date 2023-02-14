Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
if(numA % numB == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток: {numA % numB}");
