int[] FillArray(int length, int leftnum, int rightnum)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

int[] SwapArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}
int[] filled_array = FillArray(12, -9, 10);
Console.WriteLine($"{string.Join(',', filled_array)} -> {string.Join(',', SwapArray(filled_array))}");