int SumMtoN(int m, int n)
{
    if(m > n) throw new Exception("M must be smaller then N");
    if(m < n) return n + SumMtoN(m, n-1);
    return n;
}

Console.WriteLine(SumMtoN(1, 15));
Console.WriteLine(SumMtoN(4, 8));
