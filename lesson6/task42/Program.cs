int x = 13;

void Reverse(string[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        string temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

string binary = "";

void ConvertToBin(int x)
{
    if(x > 0)
    {
        ConvertToBin(x/2);
        binary += x % 2 + ",";
    }
}

ConvertToBin(x);
Console.WriteLine(binary);
string[] array_void = binary.Split(",");
Console.WriteLine(string.Join("",array_void));
Reverse(array_void);
Console.WriteLine(string.Join("",array_void));