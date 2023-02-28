Console.WriteLine("Введите число");
int f = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci(int f)
{
    if(f <= 2) return new int[] {0, 1};
    int[] fib = new int[f];
    fib[0] = 0;
    fib[1] = 1;
    for(int i = 2; i < f; i++)
    {
        fib[i] = fib[i-1] + fib[i-2];
    }
    return fib;
}
Console.WriteLine(string.Join(" ", Fibonacci(f)));