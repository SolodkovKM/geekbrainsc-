void NaturalValue(uint n)
{
    if (n > 1) NaturalValue(n - 1);
    Console.Write(n + " ");
}
NaturalValue(9);
Console.WriteLine();
NaturalValue(11);