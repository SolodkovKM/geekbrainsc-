Console.WriteLine("Введите число трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int second = number % 100 / 10;
Console.WriteLine($"{number} -> {second}");