int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

int AggNum(int[] array)
{
    int count = 0;
    foreach(int i in array)
    {
        if(i % 2 == 0) count++;
    }
    return count;
}

int[] filled_array = FillArray(10, 100, 1000);
Console.WriteLine($"[{string.Join(',', filled_array)}] -> {AggNum(filled_array)}");