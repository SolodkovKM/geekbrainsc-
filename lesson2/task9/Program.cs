int random = Random.Shared.Next(10, 100);
int last = random % 10;
int first = random / 10;
if(last > first) Console.WriteLine(last);
else Console.WriteLine(random + " -> " + first);
