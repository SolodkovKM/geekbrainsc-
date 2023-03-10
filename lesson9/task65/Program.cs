void NaturalValues(uint n, uint m)
{
    if (n > m) throw new Exception("Число n не может быть больше m");
    if (m > n) NaturalValues(n, m - 1);
    Console.Write(m + " ");
}

NaturalValues(5, 10);
Console.WriteLine();
NaturalValues(6, 3);