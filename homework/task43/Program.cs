using ClassesLibrary;

int b1 = "Введите b1".PrintGet();
int k1 = "Введите k1".PrintGet();
int b2 = "Введите b2".PrintGet();
int k2 = "Введите k2".PrintGet();

if((b2-b1)%(k1-k2) == 0)
{
    int x = (b2-b1)/(k1-k2);
    int y = k1 * x + b1;
    $"b1:{b1} k1:{k1} b2:{b2} k2:{k2} -> {x}:{k1 * x + b1}".Print();
} 
else 
{
    double x = (double)(b2-b1)/(k1-k2);
    double y = (double)(k1 * x + b1);
    $"b1:{b1} k1:{k1} b2:{b2} k2:{k2} -> {x}:{y}".Print();
}
