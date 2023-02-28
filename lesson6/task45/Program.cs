using ClassesLibrary;

int[] array = new ArrayWork().FillArray(10, 0, 10);

int[] rec_array = new int[array.Length];
void CopyArrayRec(int length)
{
    if(length > 0)
    {
        rec_array[length-1] = array[length-1];
        CopyArrayRec(length-1);
    }
}
CopyArrayRec(array.Length);
array[0] = -10000;

Console.WriteLine(string.Join(",",array));
Console.WriteLine(string.Join(",", rec_array));
