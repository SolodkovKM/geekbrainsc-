int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

int[] filled_array = FillArray(123);

int Count(int[] array, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int Count = 0;
    foreach(int i in array)
    {
        if(i > leftnum && i < rightnum) Count++;
    }
    return Count;
}
Console.WriteLine($"{string.Join(',', filled_array)} -> {Count(filled_array, 10, 100)}");