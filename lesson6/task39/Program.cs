using ClassesLibrary;

int[] filled_array = new ArrayWork().FillArray(10, 0, 6);

void Reverse(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
Console.WriteLine($"{string.Join(',',filled_array)}");
Reverse(filled_array);
Console.WriteLine($"{string.Join(',',filled_array)}");