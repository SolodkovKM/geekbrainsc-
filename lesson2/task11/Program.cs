int random_num = Random.Shared.Next(100, 1000);
int first = random_num / 100;
int second = random_num % 10;
Console.WriteLine($"{random_num} -> {first * 10 + second}");