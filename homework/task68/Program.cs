int Akkerman(int m, int n)
{
    if(m < 0 || n < 0) throw new Exception("M or N must be UINT");
    if(m == 0) return n + 1;
    else if(n == 0) return Akkerman(m-1, 1);
    return Akkerman(m-1, Akkerman(m, n-1));
}

Console.WriteLine(Akkerman(3, 5));
Console.WriteLine(Akkerman(3, 3));
Console.WriteLine(Akkerman(3, -1));