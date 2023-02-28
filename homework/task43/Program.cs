using ClassesLibrary;

int b1 = new Print().PrintReadInt("Введите b1");
int k1 = new Print().PrintReadInt("Введите k1");
int b2 = new Print().PrintReadInt("Введите b2");
int k2 = new Print().PrintReadInt("Введите k2");

if((b2-b1)%(k1-k2) == 0)
{
    int x = (b2-b1)/(k1-k2);
    int y = k1 * x + b1;
    Console.WriteLine($"b1:{b1} k1:{k1} b2:{b2} k2:{k2} -> {x}:{k1 * x + b1}");
} 
else 
{
    double x = (double)(b2-b1)/(k1-k2);
    double y = (double)(k1 * x + b1);
    Console.WriteLine($"b1:{b1} k1:{k1} b2:{b2} k2:{k2} -> {x}:{y}");
}
