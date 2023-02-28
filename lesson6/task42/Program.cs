int x = 44;

string binary = "";

void ConvertToBin(int x)
{
    if(x > 0)
    {
        ConvertToBin(x/2);
        binary += x % 2 ;
    }
}

ConvertToBin(x);
Console.WriteLine(binary);