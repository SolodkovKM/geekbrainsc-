Console.Clear();
Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
if(numA == numB * numB || numB == numA * numA) Console.WriteLine("Да");
else Console.WriteLine("Нет");
