uint Factorial(uint n)
{
    if(n == 0 || n == 1) return 1;
    return n * Factorial(n-1);
}


Console.WriteLine(Factorial(0));
Console.WriteLine(Factorial(1));
Console.WriteLine(Factorial(2));
Console.WriteLine(Factorial(3));
Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(5));
Console.WriteLine(Factorial(6));