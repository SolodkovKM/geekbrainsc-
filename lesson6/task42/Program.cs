int x = 13;

void ConvertToBin(int x)
{
    if(x > 0)
    {
        ConvertToBin(x/2);
        Console.Write(x % 2 );
    }
}

//ConvertToBin(x);

void forcycle(int end, int i = 0)
{
    if( i < end)
    {
        forcycle(end, i+1);
    }
    Console.Write(i);
}
forcycle(5);